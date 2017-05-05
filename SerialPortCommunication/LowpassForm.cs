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
    public partial class LowpassForm : Form
    {
        public static bool ApplyActive = false;

        public LowpassForm()
        {
            InitializeComponent();
            DisableRows();
            this.RB_1.Checked = true;
        }

        private void Apply_button_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Owner).Lowpass_label.Text = "Lowpass Band: " + (MainForm.Lowpass_band+1) + Environment.NewLine;
            ((MainForm)this.Owner).LogTextBox.Text = "Lowpass Band: " + (MainForm.Lowpass_band + 1) + Environment.NewLine +
                                                        ((MainForm)this.Owner).LogTextBox.Text;
            switch (MainForm.Lowpass_band)
            {
                case 0:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label1.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label3.Text + "MHz";
                        break;
                    }
                case 1:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label4.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label5.Text + "MHz";
                        break;
                    }
                case 2:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label6.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label7.Text + "MHz";
                        break;
                    }
                case 3:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label8.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label9.Text + "MHz";
                        break;
                    }
                case 4:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label10.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label11.Text + "MHz";
                        break;
                    }
                case 5:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label12.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label13.Text + "MHz";
                        break;
                    }
                case 6:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label14.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label15.Text + "MHz";
                        break;
                    }
                case 7:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label16.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label17.Text + "MHz";
                        break;
                    }
                case 8:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label18.Text + "MHz" + Environment.NewLine + "Differential Mode: " + this.label19.Text + "MHz";
                        break;
                    }
                case 9:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label20.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label21.Text + "MHz";
                        break;
                    }
                case 10:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label22.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label23.Text + "MHz";
                        break;
                    }
                case 11:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label24.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label25.Text + "MHz";
                        break;
                    }
                case 12:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label26.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label27.Text + "MHz";
                        break;
                    }
                case 13:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label28.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label29.Text + "MHz";
                        break;
                    }
                case 14:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label30.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label31.Text + "MHz";
                        break;
                    }
                case 15:
                    {
                        ((MainForm)this.Owner).Lowpass_label.Text += "Typical 3 dB Cutoff Frequency:" + Environment.NewLine +
                            "Single-Ended Mode: " + this.label32.Text + " MHz" + Environment.NewLine + "Differential Mode: " + this.label33.Text + "MHz";
                        break;
                    }
            }
            MainForm.MainSend_flag = 6;
            this.Close();
        }

        private void DisableRows()
        {
            this.label1.Enabled = false;
            this.label3.Enabled = false;
            this.label4.Enabled = false;
            this.label5.Enabled = false;
            this.label6.Enabled = false;
            this.label7.Enabled = false;
            this.label8.Enabled = false;
            this.label9.Enabled = false;
            this.label10.Enabled = false;
            this.label11.Enabled = false;
            this.label12.Enabled = false;
            this.label13.Enabled = false;
            this.label14.Enabled = false;
            this.label15.Enabled = false;
            this.label16.Enabled = false;
            this.label17.Enabled = false;
            this.label18.Enabled = false;
            this.label19.Enabled = false;
            this.label20.Enabled = false;
            this.label21.Enabled = false;
            this.label22.Enabled = false;
            this.label23.Enabled = false;
            this.label24.Enabled = false;
            this.label25.Enabled = false;
            this.label26.Enabled = false;
            this.label27.Enabled = false;
            this.label28.Enabled = false;
            this.label29.Enabled = false;
            this.label30.Enabled = false;
            this.label31.Enabled = false;
            this.label32.Enabled = false;
            this.label33.Enabled = false;
        }

        private void RB_1_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label1.Enabled = true;
            this.label3.Enabled = true;
            ApplyActive = true;
            this.Apply_button.Enabled = true;
            MainForm.Lowpass_band = 0;
        }

        private void RB_2_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label4.Enabled = true;
            this.label5.Enabled = true;
            MainForm.Lowpass_band = 1;
        }

        private void RB_3_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label6.Enabled = true;
            this.label7.Enabled = true;
            MainForm.Lowpass_band = 2;
        }

        private void RB_4_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label8.Enabled = true;
            this.label9.Enabled = true;
            MainForm.Lowpass_band = 3;
        }

        private void RB_5_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label10.Enabled = true;
            this.label11.Enabled = true;
            MainForm.Lowpass_band = 4;
        }

        private void RB_6_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label12.Enabled = true;
            this.label13.Enabled = true;
            MainForm.Lowpass_band = 5;
        }

        private void RB_7_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label14.Enabled = true;
            this.label15.Enabled = true;
            MainForm.Lowpass_band = 6;
        }

        private void RB_8_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label16.Enabled = true;
            this.label17.Enabled = true;
            MainForm.Lowpass_band = 7;
        }

        private void RB_9_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label18.Enabled = true;
            this.label19.Enabled = true;
            MainForm.Lowpass_band = 8;
        }

        private void RB_10_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label20.Enabled = true;
            this.label21.Enabled = true;
            MainForm.Lowpass_band = 9;
        }

        private void RB_11_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label22.Enabled = true;
            this.label23.Enabled = true;
            MainForm.Lowpass_band = 10;
        }

        private void RB_12_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label24.Enabled = true;
            this.label25.Enabled = true;
            MainForm.Lowpass_band = 11;
        }

        private void RB_13_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label26.Enabled = true;
            this.label27.Enabled = true;
            MainForm.Lowpass_band = 12;
        }

        private void RB_14_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label28.Enabled = true;
            this.label29.Enabled = true;
            MainForm.Lowpass_band = 13;
        }

        private void RB_15_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label30.Enabled = true;
            this.label31.Enabled = true;
            MainForm.Lowpass_band = 14;
        }

        private void RB_16_CheckedChanged(object sender, EventArgs e)
        {
            DisableRows();
            this.label32.Enabled = true;
            this.label33.Enabled = true;
            MainForm.Lowpass_band = 15;
        }
    }
}
