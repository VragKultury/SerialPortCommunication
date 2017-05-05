using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RF_Control;

namespace RF_Control
{
    public partial class WorkMode : Form
    {
        int channel;
        ushort attenuation = MainForm.Attenuator_val;
        ushort band = MainForm.Filters_band;
        
        public WorkMode()
        {
            InitializeComponent();
        }
        
        private void MsgFormatForm_Load(object sender, EventArgs e)
        {
            MainForm.msgManager.MsgManagerInit();
            channel = (int)((MainForm.Frequency - 520000) / 250) + 1;
            if (MainForm.Frequency > 2500000)
            {
                channel = 7921;
            }
            else if (MainForm.Frequency < 500000)
            {
                channel = 1;
            }
            this.Channel_TB.Text = channel.ToString("G");
            this.FilterBand_Scroll.Value = band;
            this.FilterBand_text.Text = "Ширина полосы фильтра: " + band.ToString("D");
        }

        private void Channel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Channel_TextChanged(object sender, EventArgs e)
        {
            if ((Int32.Parse(this.Channel_TB.Text) < 7922) && (Int32.Parse(this.Channel_TB.Text) > 0))
            {
                channel = Int32.Parse(this.Channel_TB.Text);
            }
            else
            {
                this.Channel_TB.Text = channel.ToString();
            }
            MainForm.Frequency = 520000 + ((channel - 1) * 250);
            double chan_txt = (double)MainForm.Frequency_convert(MainForm.SEND_TYPE.FREQ_TYPE);
            this.Channel_text.Text = "(Частота " + (chan_txt / 1000).ToString() + " МГц)";
        }


        private void Attenuation_UD_ValueChanged(object sender, EventArgs e)
        {
            UInt16 _att = (ushort)this.Attenuation_UD.Value;
            if ((_att < 32) && (_att >= 0))
            {
                attenuation = (ushort)this.Attenuation_UD.Value;
            }
            else if (_att == 32)
            {
                attenuation = 31;
            }
            this.Attenuation_UD.Value = attenuation;
            MainForm.Attenuator_val = attenuation;
            this.Attenuation_text.Text = attenuation.ToString() + " дБ ослабления";
        }

        private void Accept_button_Click(object sender, EventArgs e)
        {
            MainForm.Timer_edit = true;
            MainForm.TimeDelay = int.Parse(Channel_TB.Text);
            int _msg = Local_MSG_Format();
            MainForm.comm.DisplayWindow = this.Message_RTB;
            MainForm.comm.WriteData(_msg.ToString("X8"));
            this.Message_RTB.Text += Environment.NewLine;
            this.Message_RTB.SelectionStart = this.Message_RTB.Text.Length;
            ((MainForm)this.Owner).workMode_text.Text = "Sending Packet: " + _msg.ToString("X8");
        }

        private void Decline_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int Local_MSG_Format()
        {
            int _pkg = 9 + (channel << 14) + (band << 9) + (attenuation << 4);
            return _pkg;
        }

        private void FilterBand_Scroll_Scroll(object sender, ScrollEventArgs e)
        {
            band = (ushort)this.FilterBand_Scroll.Value;
            MainForm.Filters_band = band;
            this.FilterBand_text.Text = "Ширина полосы фильтра: " + band.ToString("D");
        }
    }
}
