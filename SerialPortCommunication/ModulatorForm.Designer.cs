namespace RF_Control
{
    partial class ModulatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulatorForm));
            this.Apply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Frequency_GB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_LoHi = new System.Windows.Forms.TableLayoutPanel();
            this.HWInputs_GB = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_RxTx = new System.Windows.Forms.TableLayoutPanel();
            this.CB_ModEn = new System.Windows.Forms.CheckBox();
            this.CB_En = new System.Windows.Forms.CheckBox();
            this.Label_En = new System.Windows.Forms.Label();
            this.Label_ModEn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.Frequency_GB.SuspendLayout();
            this.HWInputs_GB.SuspendLayout();
            this.tableLayoutPanel_RxTx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Apply
            // 
            this.Apply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Apply.Location = new System.Drawing.Point(0, 339);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(344, 23);
            this.Apply.TabIndex = 0;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Frequency_GB);
            this.groupBox1.Controls.Add(this.HWInputs_GB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 339);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // Frequency_GB
            // 
            this.Frequency_GB.Controls.Add(this.tableLayoutPanel_LoHi);
            this.Frequency_GB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Frequency_GB.Location = new System.Drawing.Point(3, 124);
            this.Frequency_GB.Name = "Frequency_GB";
            this.Frequency_GB.Size = new System.Drawing.Size(338, 60);
            this.Frequency_GB.TabIndex = 4;
            this.Frequency_GB.TabStop = false;
            this.Frequency_GB.Text = "Frequency Settings";
            // 
            // tableLayoutPanel_LoHi
            // 
            this.tableLayoutPanel_LoHi.ColumnCount = 2;
            this.tableLayoutPanel_LoHi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel_LoHi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_LoHi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_LoHi.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_LoHi.Name = "tableLayoutPanel_LoHi";
            this.tableLayoutPanel_LoHi.RowCount = 1;
            this.tableLayoutPanel_LoHi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel_LoHi.Size = new System.Drawing.Size(332, 41);
            this.tableLayoutPanel_LoHi.TabIndex = 0;
            // 
            // HWInputs_GB
            // 
            this.HWInputs_GB.AutoSize = true;
            this.HWInputs_GB.Controls.Add(this.tableLayoutPanel_RxTx);
            this.HWInputs_GB.Dock = System.Windows.Forms.DockStyle.Top;
            this.HWInputs_GB.Location = new System.Drawing.Point(3, 16);
            this.HWInputs_GB.Name = "HWInputs_GB";
            this.HWInputs_GB.Size = new System.Drawing.Size(338, 108);
            this.HWInputs_GB.TabIndex = 3;
            this.HWInputs_GB.TabStop = false;
            this.HWInputs_GB.Text = "Hardware Inputs";
            // 
            // tableLayoutPanel_RxTx
            // 
            this.tableLayoutPanel_RxTx.ColumnCount = 2;
            this.tableLayoutPanel_RxTx.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel_RxTx.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_RxTx.Controls.Add(this.CB_ModEn, 0, 1);
            this.tableLayoutPanel_RxTx.Controls.Add(this.CB_En, 0, 0);
            this.tableLayoutPanel_RxTx.Controls.Add(this.Label_En, 1, 0);
            this.tableLayoutPanel_RxTx.Controls.Add(this.Label_ModEn, 1, 1);
            this.tableLayoutPanel_RxTx.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel_RxTx.Name = "tableLayoutPanel_RxTx";
            this.tableLayoutPanel_RxTx.RowCount = 3;
            this.tableLayoutPanel_RxTx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel_RxTx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel_RxTx.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel_RxTx.Size = new System.Drawing.Size(332, 73);
            this.tableLayoutPanel_RxTx.TabIndex = 0;
            // 
            // CB_ModEn
            // 
            this.CB_ModEn.AutoSize = true;
            this.CB_ModEn.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CB_ModEn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ModEn.Location = new System.Drawing.Point(3, 28);
            this.CB_ModEn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.CB_ModEn.Name = "CB_ModEn";
            this.CB_ModEn.Size = new System.Drawing.Size(60, 15);
            this.CB_ModEn.TabIndex = 0;
            this.CB_ModEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_ModEn.UseVisualStyleBackColor = true;
            // 
            // CB_En
            // 
            this.CB_En.AutoSize = true;
            this.CB_En.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CB_En.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_En.Location = new System.Drawing.Point(3, 3);
            this.CB_En.Name = "CB_En";
            this.CB_En.Size = new System.Drawing.Size(60, 17);
            this.CB_En.TabIndex = 4;
            this.CB_En.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CB_En.UseVisualStyleBackColor = true;
            // 
            // Label_En
            // 
            this.Label_En.AutoSize = true;
            this.Label_En.Location = new System.Drawing.Point(69, 5);
            this.Label_En.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_En.Name = "Label_En";
            this.Label_En.Size = new System.Drawing.Size(64, 13);
            this.Label_En.TabIndex = 5;
            this.Label_En.Text = "Chip Enable";
            this.Label_En.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_ModEn
            // 
            this.Label_ModEn.AutoSize = true;
            this.Label_ModEn.Location = new System.Drawing.Point(69, 28);
            this.Label_ModEn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_ModEn.Name = "Label_ModEn";
            this.Label_ModEn.Size = new System.Drawing.Size(119, 13);
            this.Label_ModEn.TabIndex = 6;
            this.Label_ModEn.Text = "Modulator chain Enable";
            this.Label_ModEn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 362);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModulatorForm";
            this.Text = "Modulator Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Frequency_GB.ResumeLayout(false);
            this.HWInputs_GB.ResumeLayout(false);
            this.tableLayoutPanel_RxTx.ResumeLayout(false);
            this.tableLayoutPanel_RxTx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Apply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox HWInputs_GB;
        private System.Windows.Forms.CheckBox CB_En;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RxTx;
        private System.Windows.Forms.CheckBox CB_ModEn;
        private System.Windows.Forms.Label Label_En;
        private System.Windows.Forms.Label Label_ModEn;
        private System.Windows.Forms.GroupBox Frequency_GB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_LoHi;

    }
}