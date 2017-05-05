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
    public partial class ModulatorForm : Form
    {
        DateTime Timer1_on_Time = MainForm.Timer1_on_Time;
        DateTime Timer1_off_Time = MainForm.Timer1_off_Time;

        public ModulatorForm()
        {
            InitializeComponent();
            SetNumericValues();
        }

        private void SetNumericValues()
        {
            CheckBox_Init();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            MainForm.Modulator_En = (this.CB_En.Checked) ? true : false;
            MainForm.Modulator_ModEn = (this.CB_ModEn.Checked) ? true : false;
            MainForm.ModulatorChanged = true;
            MainForm.MainSend_flag = 3;
            this.Close();
        }

        private void CheckBox_Init()
        {
            this.CB_En.Checked = MainForm.Modulator_En;
            this.CB_ModEn.Checked = MainForm.Modulator_ModEn;
        }
    }
}
