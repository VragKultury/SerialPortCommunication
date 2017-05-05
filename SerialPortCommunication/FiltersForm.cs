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
    public partial class FiltersForm : Form
    {
        public FiltersForm()
        {
            InitializeComponent();
            ScrollBarInit();
            CheckBoxInit();
            SetTextLebel();
            TextBoxInit();
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            MainForm.Filters_band = (UInt16)this.Filters_ScrollBar.Value;
            MainForm.Filters_Amplify = this.FiltersAmp_CB.Checked;
            MainForm.Filters_ChipEn = this.ChipEn_CB.Checked;
            ((MainForm)this.Owner).Filters_Label.Text = "Corner Frequency: " + (this.Filters_ScrollBar.Value).ToString("G") + " MHz" + 
                                                        Environment.NewLine + " Gain Level: " + ((this.FiltersAmp_CB.Checked == true) ? "12 dB" : "6 dB");
            ((MainForm)this.Owner).LogTextBox.Text = "Corner Frequency: " + (this.Filters_ScrollBar.Value).ToString("G") + " MHz" +
                                                        Environment.NewLine + " Gain Level: " + ((this.FiltersAmp_CB.Checked == true) ? "12 dB" : "6 dB") + 
                                                        Environment.NewLine + ((MainForm)this.Owner).LogTextBox.Text;
            MainForm.MainSend_flag = 5;
            this.Close();
        }

        private void SetTextLebel()
        {
            this.Filters_TextLabel.Text = "Corner Frequency: " + (this.Filters_ScrollBar.Value).ToString("G") + " MHz" + Environment.NewLine +
                                          " Gain Level: " + ((this.FiltersAmp_CB.Checked == true) ? "12 dB" : "6 dB");

        }

        private void TextBoxInit()
        {
            this.Filters_TextBox.Text = this.Filters_ScrollBar.Value.ToString("G");
        }

        private void CheckBoxInit()
        {
            this.FiltersAmp_CB.Checked = MainForm.Filters_Amplify;
            this.ChipEn_CB.Checked = MainForm.Filters_ChipEn;
            this.Filters_TextBox.Visible = this.ChipEn_CB.Checked;
            this.Filters_ScrollBar.Visible = this.ChipEn_CB.Checked;
            this.Filters_TextLabel.Visible = this.ChipEn_CB.Checked;
            this.FiltersAmp_CB.Visible = this.ChipEn_CB.Checked;
            this.MHz_label.Visible = this.ChipEn_CB.Checked;
        }

        private void ScrollBarInit()
        {
            this.Filters_ScrollBar.Value = MainForm.Filters_band;
        }

        private void Att_ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            MainForm.Filters_band = (ushort)this.Filters_ScrollBar.Value;
            SetTextLebel();
            TextBoxInit();
        }

        private void Filters_TextBox_TextChanged(object sender, EventArgs e)
        {
            UInt16 FiltersVal = UInt16.Parse(this.Filters_TextBox.Text);
            if (FiltersVal < 31)
            {
                MainForm.Filters_band = FiltersVal;
                this.Filters_ScrollBar.Value = MainForm.Attenuator_val;
                SetTextLebel();
                TextBoxInit();
            }
            else
            {
                this.Filters_TextBox.Text = this.Filters_ScrollBar.Value.ToString("G");
                FiltersVal = (UInt16)this.Filters_ScrollBar.Value;
            }
        }

        private void Filters_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
                e.Handled = true;
        }

        private void FiltersAmp_CB_CheckedChanged(object sender, EventArgs e)
        {
            SetTextLebel();
        }

        private void ChipEn_CB_CheckedChanged(object sender, EventArgs e)
        {
            this.Filters_TextBox.Visible = this.ChipEn_CB.Checked;
            this.Filters_ScrollBar.Visible = this.ChipEn_CB.Checked;
            this.Filters_TextLabel.Visible = this.ChipEn_CB.Checked;
            this.FiltersAmp_CB.Visible = this.ChipEn_CB.Checked;
            this.MHz_label.Visible = this.ChipEn_CB.Checked;
        }
    }
}
