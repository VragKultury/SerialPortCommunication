using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RF_Control
{
    public partial class AttenuatorForm : Form
    {
        public AttenuatorForm()
        {
            InitializeComponent();
            ScrollBarInit();
            SetTextLebel();
            TextBoxInit();
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            MainForm.Attenuator_val = (UInt16)this.Att_ScrollBar.Value;
            ((MainForm)this.Owner).Att_label.Text = "Attenuation is " + this.Att_ScrollBar.Value.ToString("G") + " dB";
            ((MainForm)this.Owner).LogTextBox.Text = "Attenuator Level is " +
                this.Att_ScrollBar.Value + " dB" + Environment.NewLine + ((MainForm)this.Owner).LogTextBox.Text;
            MainForm.MainSend_flag = 4;
            this.Close();
        }

        private void SetTextLebel()
        {
            this.TextLabel.Text = "16 dB Attenuator: ";
            this.TextLabel.Text += ((this.Att_ScrollBar.Value >> 4) & 0x1);
            this.TextLabel.Text += Environment.NewLine;
            this.TextLabel.Text += "8 dB Attenuator: ";
            this.TextLabel.Text += ((this.Att_ScrollBar.Value >> 3) & 0x1);
            this.TextLabel.Text += Environment.NewLine;
            this.TextLabel.Text += "4 dB Attenuator: ";
            this.TextLabel.Text += ((this.Att_ScrollBar.Value >> 2) & 0x1);
            this.TextLabel.Text += Environment.NewLine;
            this.TextLabel.Text += "2 dB Attenuator: ";
            this.TextLabel.Text += ((this.Att_ScrollBar.Value >> 1) & 0x1);
            this.TextLabel.Text += Environment.NewLine;
            this.TextLabel.Text += "1 dB Attenuator: ";
            this.TextLabel.Text += ((this.Att_ScrollBar.Value) & 0x1);
        }

        private void TextBoxInit()
        {
            this.Att_TextBox.Text = this.Att_ScrollBar.Value.ToString("G");
        }

        private void ScrollBarInit()
        {
            this.Att_ScrollBar.Value = MainForm.Attenuator_val;
        }

        private void Att_ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            MainForm.Attenuator_val = (ushort)this.Att_ScrollBar.Value;
            SetTextLebel();
            TextBoxInit();
        }

        private void Att_TextBox_TextChanged(object sender, EventArgs e)
        {
            UInt16 AttVal = UInt16.Parse(this.Att_TextBox.Text);
            if (AttVal < 32)
            {
                MainForm.Attenuator_val = AttVal;
                this.Att_ScrollBar.Value = MainForm.Attenuator_val;
                SetTextLebel();
                TextBoxInit();
            }
            else
            {
                this.Att_TextBox.Text = this.Att_ScrollBar.Value.ToString("G");
                AttVal = (UInt16)this.Att_ScrollBar.Value;
            }
        }

        private void Att_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
                e.Handled = true;   
        }
    }
}
