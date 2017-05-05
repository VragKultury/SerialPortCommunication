namespace RF_Control
{
    partial class WorkMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Channel_TB = new System.Windows.Forms.TextBox();
            this.Channel_text = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Decline_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Message_RTB = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Attenuation_UD = new System.Windows.Forms.NumericUpDown();
            this.Attenuation_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attenuation_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 45);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Номер канала";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.Channel_TB, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Channel_text, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(172, 26);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Channel_TB
            // 
            this.Channel_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Channel_TB.Location = new System.Drawing.Point(3, 3);
            this.Channel_TB.MaxLength = 4;
            this.Channel_TB.Name = "Channel_TB";
            this.Channel_TB.Size = new System.Drawing.Size(45, 20);
            this.Channel_TB.TabIndex = 0;
            this.Channel_TB.TextChanged += new System.EventHandler(this.Channel_TextChanged);
            this.Channel_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Channel_KeyPress);
            // 
            // Channel_text
            // 
            this.Channel_text.AutoSize = true;
            this.Channel_text.Location = new System.Drawing.Point(54, 5);
            this.Channel_text.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Channel_text.Name = "Channel_text";
            this.Channel_text.Size = new System.Drawing.Size(79, 13);
            this.Channel_text.TabIndex = 1;
            this.Channel_text.Text = "(Частота МГц)";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Accept_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Decline_button, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 195);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(178, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // Accept_button
            // 
            this.Accept_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Accept_button.Location = new System.Drawing.Point(3, 3);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(83, 28);
            this.Accept_button.TabIndex = 0;
            this.Accept_button.Text = "Отправить";
            this.Accept_button.UseVisualStyleBackColor = true;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Decline_button
            // 
            this.Decline_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Decline_button.Location = new System.Drawing.Point(92, 3);
            this.Decline_button.Name = "Decline_button";
            this.Decline_button.Size = new System.Drawing.Size(83, 28);
            this.Decline_button.TabIndex = 1;
            this.Decline_button.Text = "Закрыть";
            this.Decline_button.UseVisualStyleBackColor = true;
            this.Decline_button.Click += new System.EventHandler(this.Decline_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Message_RTB, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 232);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Message_RTB
            // 
            this.Message_RTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message_RTB.Location = new System.Drawing.Point(3, 118);
            this.Message_RTB.Name = "Message_RTB";
            this.Message_RTB.ReadOnly = true;
            this.Message_RTB.Size = new System.Drawing.Size(178, 71);
            this.Message_RTB.TabIndex = 2;
            this.Message_RTB.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(3, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 45);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уровень ослабления";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.Attenuation_UD, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Attenuation_text, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(172, 26);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // Attenuation_UD
            // 
            this.Attenuation_UD.Location = new System.Drawing.Point(3, 3);
            this.Attenuation_UD.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Attenuation_UD.Name = "Attenuation_UD";
            this.Attenuation_UD.Size = new System.Drawing.Size(45, 20);
            this.Attenuation_UD.TabIndex = 4;
            this.Attenuation_UD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Attenuation_UD.ValueChanged += new System.EventHandler(this.Attenuation_UD_ValueChanged);
            // 
            // Attenuation_text
            // 
            this.Attenuation_text.AutoSize = true;
            this.Attenuation_text.Location = new System.Drawing.Point(54, 5);
            this.Attenuation_text.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Attenuation_text.Name = "Attenuation_text";
            this.Attenuation_text.Size = new System.Drawing.Size(83, 13);
            this.Attenuation_text.TabIndex = 3;
            this.Attenuation_text.Text = "дБ ослабления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Отсылаемый пакет:";
            // 
            // WorkMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(184, 232);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkMode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Управление ячейкой ПРМВ";
            this.Load += new System.EventHandler(this.MsgFormatForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Attenuation_UD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox Channel_TB;
        private System.Windows.Forms.Label Channel_text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Button Decline_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Attenuation_text;
        private System.Windows.Forms.NumericUpDown Attenuation_UD;
        private System.Windows.Forms.RichTextBox Message_RTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;

    }
}