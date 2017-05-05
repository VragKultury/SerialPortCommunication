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
    public partial class TestMsgForm : Form
    {
        public TestMsgForm()
        {
            InitializeComponent();
        }

        private void TestMsgForm_Load(object sender, EventArgs e)
        {
            this.textBox.Text = MainForm.TestMessage;
        }

        private void Decline_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accept_button_Click_1(object sender, EventArgs e)
        {
            MainForm.TestMessage = this.textBox.Text;
            MainForm.comm.WriteData(MainForm.TestMessage);
            MainForm.SerialChanged = true;
//            this.Close();
        }


    }
}
