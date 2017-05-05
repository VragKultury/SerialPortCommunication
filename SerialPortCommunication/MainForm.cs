using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RF_Control;

namespace RF_Control
{
    public partial class MainForm : Form
    {
        public static CommunicationManager comm = new CommunicationManager();
        string transType = string.Empty;
        public static int cnt1;

        public static int TimeDelay = 250;
        public static bool Timer_edit = false;
        public static bool MainSend_Tick = false;
        public static ushort MainSend_cnt;

        public static bool PortStatus;
        public static bool SerialTimer;
        public static bool SerialChanged;

        public static Int64 Frequency;
        public static Int64 FrqData;

        public static bool RxTx_Status;
        public static bool LoHi_Status;

        public static bool ModulatorChanged;
        public static bool Modulator_En;
        public static bool Modulator_ModEn;
        public static bool Modulator_ChipEn;

        public static bool Prescaler_manual;
        public static UInt16 Prescaler_number;

        public static UInt16 Attenuator_val;

        public static UInt16 Lowpass_band;

        public static UInt16 Filters_band;
        public static bool Filters_Amplify;
        public static bool Filters_ChipEn;

        public static bool Demodulator_En;

        public static string PortName;
        public static string PortBaudRate;
        public static string PortParity;
        public static string PortDataBits;
        public static string PortStopBits;

        public static ushort MainSend_flag;
        public static string TestMessage;
        public static string[] msgSelectedFields = new string[10];

        public static MessageManager msgManager = new MessageManager();
        
        public static DateTime Timer1_on_Time = new DateTime();
        public static DateTime Timer1_off_Time = new DateTime();

        public enum SEND_TYPE { FREQ_TYPE, CHAN_TYPE };

        public MainForm()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetControlState();
            SetDefaults();
            TimersInit();
            TextBox_initMain();
            ModulatorText_initMain();
            this.RB_Preselector1.Checked = true;
        }

        /// <summary>
        /// Method to initialize serial port
        /// values to standard defaults
        /// </summary>
        private void SetDefaults()
        {
            PortBaudRate = "115200";

            Frequency = Properties.Settings.Default.S_Frequency;
            TestMessage = "Text";
            RB_TX.Checked = true;
            RB_RX.Checked = false;

            Modulator_En = true;
            Modulator_ModEn = true;
            Modulator_ChipEn = true;
            Demodulator_En = false;
            Filters_ChipEn = true;
            Filters_Amplify = true;
            Frq_RB.Checked = !Properties.Settings.Default.S_Send_Mode;
            Ch_RB.Checked = Properties.Settings.Default.S_Send_Mode;
            FrqData = !(Properties.Settings.Default.S_Send_Mode) ? (Frequency) : (((Frequency - 520000) / 250) + 1);
            
            Filters_band = 10;

            this.Demodulator_CB.Checked = Demodulator_En;
            this.Frequency_textBox.Text = (Properties.Settings.Default.S_Send_Mode) ? (Frequency_convert(MainForm.SEND_TYPE.CHAN_TYPE).ToString("D")) :
                (Frequency / 1000).ToString("D");
            this.Frequency_Hz.SelectedIndex = 1;
            this.Att_label.Text = "Attenuation is " + Attenuator_val +" dB";
            this.Lowpass_label.Text = "Lowpass Filter Band: " + (Lowpass_band+1);
            this.Filters_Label.Text = "Corner Frequency: " + Filters_band.ToString("G") + " MHz" +
                                            Environment.NewLine + " Gain Level: " + ((Filters_Amplify == true) ? "12 dB" : "6 dB");
            this.LogTextBox.Text = "Process Log Window";
        }

        /// <summary>
        /// method to set the state of controls
        /// when the form first loads
        /// </summary>
        private void SetControlState()
        {
            //rdoText.Checked = true;
            cmdSend_button.Enabled = false;
            MainForm.comm.DisplayWindow = this.WriteSerialBox;
            //cmdClose.Enabled = false;
        }
        ///
        ///
        
        /// <summary>
        /// Method to initialize timers
        /// </summary>
        public void TimersInit()
        {
            Timer mainFormTimer1 = new Timer();
            mainFormTimer1.Interval = 1000;
            mainFormTimer1.Start();
            mainFormTimer1.Tick += new EventHandler(timer1_Tick);

            Timer mainFormTimer2 = new Timer();
            mainFormTimer2.Interval = TimeDelay;
            mainFormTimer2.Start();
            mainFormTimer2.Tick += new EventHandler(timer2_Tick);

            Timer1_on_Time = DateTime.Now;
            Timer1_off_Time = Timer1_on_Time.AddHours(4);
        }

        public void TimersRecall()
        {
            Timer mainFormTimer2 = new Timer();
            mainFormTimer2.Interval = TimeDelay;
            mainFormTimer2.Start();
            mainFormTimer2.Tick -= new EventHandler(timer2_Tick);

            Timer1_on_Time = DateTime.Now;
            Timer1_off_Time = Timer1_on_Time.AddHours(4);
        }

        private void Frequency_initMain()
        {
            Frequency = this.Frequency_Hz.SelectedIndex;

        }

        private void TextBox_initMain()
        {
            this.SerialStatus_label.Text = "Статус: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? ("Открыт") : (("Закрыт"));
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Имя порта: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.PortName) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Скорость: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.BaudRate) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Parity: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.Parity) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Stop Bits: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.StopBits) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Data Bits: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.DataBits) : ("-");
            this.LogTextBox.Text = "COM Port Initialisation Complete" + Environment.NewLine + this.LogTextBox.Text;
        }

        public void ModulatorText_initMain()
        {
            this.Modulator_Label.Text = "Chip enable: ";
            this.Modulator_Label.Text += (Modulator_En) ? ("OK") : (("-"));
            this.Modulator_Label.Text += Environment.NewLine;
            this.Modulator_Label.Text += "Modulator enable: ";
            this.Modulator_Label.Text += (Modulator_ModEn) ? ("OK") : (("-"));
        }

        private UInt64 Packet_Format(UInt16 num)
        {
            UInt64 outData = 0;

            switch (num)
            {
                case 0:
                    {
                        outData = 8 + (0 << 4) + (ulong)(((RxTx_Status == true) ? 1 : 0) << 8) + (ulong)(((LoHi_Status == true) ? 1 : 0) << 9);
                        break;
                    }
                case 1:
                    {
                        outData = 8 + (1 << 4) + (ulong)(((Prescaler_manual == true) ? 1 : 0) << 8) + 
                                                 (ulong)(((Prescaler_manual == true) ? Prescaler_number : 0) << 9);
                        break;
                    }
                case 2:
                    {

                        outData = 8 + (2 << 4) + (ulong)(((Properties.Settings.Default.S_Send_Mode==true) ? 1 : 0) << 7) + (ulong)((FrqData) << 8);
                        break;
                    }
                case 3:
                    {
                        outData = 8 + (3 << 4) + (ulong)(((Modulator_En == true) ? 1 : 0) << 8) + (ulong)(((Modulator_ModEn == true) ? 1 : 0) << 9) +
                                                 (ulong)(((Modulator_ChipEn == true) ? 1 : 0) << 10);
                        break;
                    }
                case 4:
                    {
                        outData = 8 + (4 << 4) + (ulong)(Attenuator_val << 8);
                        break;
                    }
                case 5:
                    {
                        outData = 8 + (5 << 4) + (ulong)(((Filters_ChipEn == true) ? 1 : 0) << 8) + 
                            (ulong)(((Filters_Amplify == true) ? 1 : 0) << 9) + (ulong)(Filters_band << 10);
                        break;
                    }
                case 6:
                    {
                        outData = 8 + (6 << 4) + (ulong)(Lowpass_band << 8);
                        break;
                    }
                case 7:
                    {
                        outData = 8 + (7 << 4) + (ulong)(((Demodulator_En == true) ? 1 : 0) << 8);
                        break;
                    }
            }

            return outData;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer1_on_Time = Timer1_on_Time.AddSeconds(1);
            if (Timer_edit == true)
            {
                TimersRecall();
                Timer_edit = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (MainSend_Tick == true)
            {
                MainSend_TranslateFunc(MainSend_cnt);
                MainSend_cnt++;
            }
            if (SerialChanged) TextBox_initMain();
            SerialChanged = false;
            if (ModulatorChanged)
            {
                ModulatorText_initMain();
                ModulatorChanged = false;
            }
            if (MainSend_flag != 0)
            {
                ushort _c = (ushort)(MainSend_flag & 0x7);
                MainSend_Func(_c);
                MainSend_flag = 0;
            }
        }

/// <summary>
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>


        private void ModulatorForm_Click(object sender, EventArgs e)
        {
            ModulatorForm secondForm = new ModulatorForm();
            secondForm.ShowInTaskbar = false;
            secondForm.StartPosition = FormStartPosition.CenterScreen;
            secondForm.ShowDialog(this);
        }

        private void COM_button_click(object sender, EventArgs e)
        {
            ComPortForm comPortForm = new ComPortForm();
            comPortForm.ShowInTaskbar = false;
            comPortForm.StartPosition = FormStartPosition.CenterScreen;
            comPortForm.ShowDialog(this);
        }

        private void msgFormat_button_Click(object sender, EventArgs e)
        {
            WorkMode msgFormatForm = new WorkMode();
            msgFormatForm.ShowInTaskbar = false;
            msgFormatForm.StartPosition = FormStartPosition.CenterScreen;
            msgFormatForm.ShowDialog(this);
        }

        private void AttenuatorForm_Click(object sender, EventArgs e)
        {
            AttenuatorForm attenuatorForm = new AttenuatorForm();
            attenuatorForm.ShowInTaskbar = false;
            attenuatorForm.StartPosition = FormStartPosition.CenterScreen;
            attenuatorForm.ShowDialog(this);
        }

        private void LowpassForm_Click(object sender, EventArgs e)
        {
            LowpassForm lowPassForm = new LowpassForm();
            lowPassForm.ShowInTaskbar = false;
            lowPassForm.StartPosition = FormStartPosition.CenterScreen;
            lowPassForm.ShowDialog(this);
        }


        private void FiltersForm_Click(object sender, EventArgs e)
        {
            FiltersForm filtersForm = new FiltersForm();
            filtersForm.ShowInTaskbar = false;
            filtersForm.StartPosition = FormStartPosition.CenterScreen;
            filtersForm.ShowDialog(this);
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Prescaler_button_Click(object sender, EventArgs e)
        {
            switch (Prescaler_manual)
            {
                case true:
                    {
                        this.Prescaler_button.Text = "Manual Set";
                        this.RB_Preselector1.Enabled = false;
                        this.RB_Preselector2.Enabled = false;
                        this.RB_Preselector3.Enabled = false;
                        this.RB_Preselector4.Enabled = false;
                        this.RB_Preselector5.Enabled = false;
                        this.RB_Preselector6.Enabled = false;
                        this.RB_Preselector7.Enabled = false;
                        this.RB_Preselector8.Enabled = false;
                        Prescaler_manual = false;
                        this.LogTextBox.Text = "Prescaler Mode set to Auto " + Environment.NewLine + this.LogTextBox.Text;
                        break;
                    }
                case false:
                    {
                        this.Prescaler_button.Text = "Auto Set";
                        this.RB_Preselector1.Enabled = true;
                        this.RB_Preselector2.Enabled = true;
                        this.RB_Preselector3.Enabled = true;
                        this.RB_Preselector4.Enabled = true;
                        this.RB_Preselector5.Enabled = true;
                        this.RB_Preselector6.Enabled = true;
                        this.RB_Preselector7.Enabled = true;
                        this.RB_Preselector8.Enabled = true;
                        Prescaler_manual = true;
                        this.LogTextBox.Text = "Prescaler Mode set to Manual " + Environment.NewLine + this.LogTextBox.Text;
                        break;
                    }
            }
            MainSend_flag = 1;
        }

        private void freqApply_button_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.S_Send_Mode == false)
            {
                Int64 frq = Int64.Parse(this.Frequency_textBox.Text) * (long)Math.Pow(1000, (this.Frequency_Hz.SelectedIndex));
                if ((frq >= 400000) && (frq <= 2600000))
                {
                    Frequency = frq;
                    FrqData = frq;
                }

                this.Frequency_LB.Text = (((frq >= 400000) && (frq <= 2600000)) ? "Frequency is" : "Error! Frequency can't be") +
                        " changed to " + this.Frequency_textBox.Text + " " + this.Frequency_Hz.Text + " (" + frq + " kHz)" +
                        (((frq < 400000) || (frq > 2600000)) ? (Environment.NewLine + "Current Frequency is " + Frequency + " kHz") : " ");

                if (Prescaler_manual == false)
                {
                    if ((Frequency >= 400000) && (Frequency < 550000))
                        this.RB_Preselector1.Checked = true;
                    else if ((Frequency >= 550000) && (Frequency < 685000))
                        this.RB_Preselector2.Checked = true;
                    else if ((Frequency >= 685000) && (Frequency < 798000))
                        this.RB_Preselector3.Checked = true;
                    else if ((Frequency >= 798000) && (Frequency < 920000))
                        this.RB_Preselector4.Checked = true;
                    else if ((Frequency >= 920000) && (Frequency < 1420000))
                        this.RB_Preselector5.Checked = true;
                    else if ((Frequency >= 1420000) && (Frequency < 1755000))
                        this.RB_Preselector6.Checked = true;
                    else if ((Frequency >= 1755000) && (Frequency < 2185000))
                        this.RB_Preselector7.Checked = true;
                    else if ((Frequency >= 2185000) && (Frequency <= 2600000))
                        this.RB_Preselector8.Checked = true;
                    if ((frq >= 400000) && (frq <= 2600000))
                    {
                        this.LogTextBox.Text = "Frequency is changed to " + Frequency + " kHz (" + this.Frequency_textBox.Text +
                        " " + this.Frequency_Hz.Text + ")" + ". Preselector Band is " + ((this.RB_Preselector1.Checked) ? "1" : "") +
                            ((this.RB_Preselector2.Checked) ? "2" : "") + ((this.RB_Preselector3.Checked) ? "3" : "") + ((this.RB_Preselector4.Checked) ? "4" : "") +
                            ((this.RB_Preselector5.Checked) ? "5" : "") + ((this.RB_Preselector6.Checked) ? "6" : "") + ((this.RB_Preselector7.Checked) ? "7" : "") +
                            ((this.RB_Preselector8.Checked) ? "8" : "") + Environment.NewLine + this.LogTextBox.Text;
                    }
                }
            }

            else if (Properties.Settings.Default.S_Send_Mode == true)
            {
                Int64 _ch = Int64.Parse(this.Frequency_textBox.Text);
                if (_ch <= 7921)
                {
                    FrqData = _ch;
                    Frequency = 520000 + ((_ch-1) * 250);
                }

                this.Frequency_LB.Text = ((_ch <= 7921) ? "Channel is" : "Error! Channel can't be") +
                        " changed to " + this.Frequency_textBox.Text + " (" + Frequency + " kHz)" +
                        (((_ch < 0) || (_ch > 7921)) ? (Environment.NewLine + "Current Channel is " + FrqData + " kHz") : " ");

                if (Prescaler_manual == false)
                {
                    if ((Frequency >= 400000) && (Frequency < 550000))
                        this.RB_Preselector1.Checked = true;
                    else if ((Frequency >= 550000) && (Frequency < 685000))
                        this.RB_Preselector2.Checked = true;
                    else if ((Frequency >= 685000) && (Frequency < 798000))
                        this.RB_Preselector3.Checked = true;
                    else if ((Frequency >= 798000) && (Frequency < 920000))
                        this.RB_Preselector4.Checked = true;
                    else if ((Frequency >= 920000) && (Frequency < 1420000))
                        this.RB_Preselector5.Checked = true;
                    else if ((Frequency >= 1420000) && (Frequency < 1755000))
                        this.RB_Preselector6.Checked = true;
                    else if ((Frequency >= 1755000) && (Frequency < 2185000))
                        this.RB_Preselector7.Checked = true;
                    else if ((Frequency >= 2185000) && (Frequency <= 2600000))
                        this.RB_Preselector8.Checked = true;
                    if (_ch <= 7921)
                    {
                        this.LogTextBox.Text = "Channel is changed to " + _ch + ". Preselector Band is " + ((this.RB_Preselector1.Checked) ? "1" : "") +
                            ((this.RB_Preselector2.Checked) ? "2" : "") + ((this.RB_Preselector3.Checked) ? "3" : "") + ((this.RB_Preselector4.Checked) ? "4" : "") +
                            ((this.RB_Preselector5.Checked) ? "5" : "") + ((this.RB_Preselector6.Checked) ? "6" : "") + ((this.RB_Preselector7.Checked) ? "7" : "") +
                            ((this.RB_Preselector8.Checked) ? "8" : "") + Environment.NewLine + this.LogTextBox.Text;
                    }
                }
            }
            Properties.Settings.Default.S_Frequency = Frequency;
            Properties.Settings.Default.Save();
            MainForm.MainSend_flag = 2;
        }

        private void RB_RX_CheckedChanged(object sender, EventArgs e)
        {
            if (RxTx_Status == true)
            {
                RxTx_Status = false;
                this.CB_LoHi.Checked = false;
                this.Demodulator_CB.Checked = true;
                this.Modulator_GB.BackColor = System.Drawing.SystemColors.Control;
                this.Modulator_GB.Enabled = false;
                this.Demodulator_GB.BackColor = System.Drawing.SystemColors.ControlLight;
                this.LogTextBox.Text = "Receiver Mode is Enabled" + Environment.NewLine + this.LogTextBox.Text;
            }
            MainSend_flag = 8;
        }

        private void RB_TX_CheckedChanged(object sender, EventArgs e)
        {
            if (RxTx_Status == false)
            {
                RxTx_Status = true;
                this.CB_LoHi.Checked = true;
                this.Demodulator_CB.Checked = false;
                this.Modulator_GB.Enabled = true;
                this.Modulator_GB.BackColor = System.Drawing.SystemColors.ControlLight;
                this.Demodulator_GB.BackColor = System.Drawing.SystemColors.Control;
                this.LogTextBox.Text = "Transmitter Mode is Enabled" + Environment.NewLine + this.LogTextBox.Text;
            }
            MainSend_flag = 8;
        }

        private void RB_Preselector_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RB_Preselector1.Checked == true) Prescaler_number = 1;
            else if (this.RB_Preselector2.Checked == true) Prescaler_number = 2;
            else if (this.RB_Preselector3.Checked == true) Prescaler_number = 3;
            else if (this.RB_Preselector4.Checked == true) Prescaler_number = 4;
            else if (this.RB_Preselector5.Checked == true) Prescaler_number = 5;
            else if (this.RB_Preselector6.Checked == true) Prescaler_number = 6;
            else if (this.RB_Preselector7.Checked == true) Prescaler_number = 7;
            else if (this.RB_Preselector8.Checked == true) Prescaler_number = 8;
            Int16 qqq = 1;
            if (qqq == 1)
            {
                this.LogTextBox.Text = "Preselector Band is " + Prescaler_number + Environment.NewLine + this.LogTextBox.Text;
            }
            qqq = 0;
            MainSend_flag = 1;
        }

        private void Demodulator_CB_CheckedChanged(object sender, EventArgs e)
        {
            Demodulator_En = this.Demodulator_CB.Checked;
            this.LogTextBox.Text = "Demodulator is " + (Demodulator_En ? "Enabled" : "Disabled") + Environment.NewLine + this.LogTextBox.Text;
            MainSend_flag = 7;
        }

        private void CB_LoHi_CheckedChanged(object sender, EventArgs e)
        {
            LoHi_Status = this.CB_LoHi.Checked;
            this.LogTextBox.Text = "Low / High Level is Changed to " + (LoHi_Status ? "High" : "Low") + Environment.NewLine + this.LogTextBox.Text;
            MainSend_flag = 8;
        }

        private void Frequency_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;   
        }

        private void Frequency_Hz_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Frequency_textBox.MaxLength = 10 - (this.Frequency_Hz.SelectedIndex) * 3;
        }

        private void MainSend_Click(object sender, EventArgs e)
        {
            if (MainForm.PortStatus)
            {
                MainForm.comm.DisplayWindow = this.WriteSerialBox;
                MainSend_cnt = 0;
                MainSend_Tick = true;
            }
        }
        public void MainSend_TranslateFunc(ushort _cnt)
        {
            if (_cnt == 8)
            {
                this.WriteSerialBox.Text += "Transmittion Complete" + Environment.NewLine + Environment.NewLine;
                this.LogTextBox.Text = "Transmit Full Packet to Device Complete Successfully" + Environment.NewLine + this.LogTextBox.Text;
                MainSend_Tick = false;
            }
            else
            {
                ulong _pack = Packet_Format(_cnt) >> 4;
                this.WriteSerialBox.Text += "Packet Type " + _cnt + ": ";
                comm.WriteData(_pack.ToString("X8"));
                this.WriteSerialBox.Text += Environment.NewLine;
            }
        }

        public void MainSend_Func(ushort i)
        {
            if (MainForm.PortStatus)
            {
                MainForm.comm.DisplayWindow = this.WriteSerialBox;
                this.WriteSerialBox.Text += "Packet Type " + i + ": ";
                ulong _pack = Packet_Format(i) >> 4;
                comm.WriteData(_pack.ToString("X8"));
                this.WriteSerialBox.Text += Environment.NewLine;
                this.WriteSerialBox.Text += "Transmittion Complete" + Environment.NewLine + Environment.NewLine;
                this.LogTextBox.Text = "Transmit " + ((i == 0) ? "Mode" : ((i == 1) ? "Preselector" : ((i == 2) ? "Frequency" : ((i == 3) ? "Modulator" :
                    ((i == 4) ? "Attenuator" : ((i == 5) ? "Filters" : ((i == 6) ? "Lowpass" : ((i == 7) ? "Demodulator" : "No")))))))) +
                    " Settings to Device Complete Successfully" + Environment.NewLine + this.LogTextBox.Text;
            }
        }

        private void Frq_RB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.S_Send_Mode = !this.Frq_RB.Checked;
            Properties.Settings.Default.Save();
            this.Frequency_Hz.Visible = true;
            this.freqApply_button.Text = "Apply Frequency";
            this.Frequency_textBox.Text = Frequency_convert(MainForm.SEND_TYPE.FREQ_TYPE).ToString("G");
            this.Frequency_Hz.SelectedIndex = 0;
        }

        private void Ch_RB_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.S_Send_Mode = this.Ch_RB.Checked;
            Properties.Settings.Default.Save();
            this.Frequency_Hz.Visible = false;
            this.freqApply_button.Text = "Apply Channel";
            this.Frequency_textBox.Text = Frequency_convert(MainForm.SEND_TYPE.CHAN_TYPE).ToString("G");
        }

        public static long Frequency_convert(SEND_TYPE _type)
        {
            long _out;
            if (_type == MainForm.SEND_TYPE.FREQ_TYPE)
            {
                _out = Frequency;
            }
            else if (_type == MainForm.SEND_TYPE.CHAN_TYPE)
            {
                if ((Frequency >= 520000) && (Frequency <= 2500000))
                {
                    _out = (Frequency - 520000) / 250 + 1;
                }
                else _out = 0;
            }
            else _out = 0;

            return _out;
        }
    }
}