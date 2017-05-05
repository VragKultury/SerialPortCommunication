namespace RF_Control
{
    partial class FiltersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltersForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Apply_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Filters_ScrollBar = new System.Windows.Forms.VScrollBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.FiltersAmp_CB = new System.Windows.Forms.CheckBox();
            this.MHz_label = new System.Windows.Forms.Label();
            this.Filters_TextBox = new System.Windows.Forms.TextBox();
            this.ChipEn_CB = new System.Windows.Forms.CheckBox();
            this.Filters_TextLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Apply_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Apply_button
            // 
            this.Apply_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Apply_button.Location = new System.Drawing.Point(3, 236);
            this.Apply_button.Name = "Apply_button";
            this.Apply_button.Size = new System.Drawing.Size(198, 23);
            this.Apply_button.TabIndex = 2;
            this.Apply_button.Text = "Apply";
            this.Apply_button.UseVisualStyleBackColor = true;
            this.Apply_button.Click += new System.EventHandler(this.Apply_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 227);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setings";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Filters_ScrollBar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 208);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Filters_ScrollBar
            // 
            this.Filters_ScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filters_ScrollBar.LargeChange = 1;
            this.Filters_ScrollBar.Location = new System.Drawing.Point(5, 5);
            this.Filters_ScrollBar.Margin = new System.Windows.Forms.Padding(5);
            this.Filters_ScrollBar.Maximum = 32;
            this.Filters_ScrollBar.Minimum = 1;
            this.Filters_ScrollBar.Name = "Filters_ScrollBar";
            this.Filters_ScrollBar.Size = new System.Drawing.Size(17, 198);
            this.Filters_ScrollBar.TabIndex = 0;
            this.Filters_ScrollBar.Value = 1;
            this.Filters_ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Att_ScrollBar_Scroll);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Filters_TextLabel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(30, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(159, 202);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.FiltersAmp_CB, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.MHz_label, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Filters_TextBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ChipEn_CB, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(153, 70);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // FiltersAmp_CB
            // 
            this.FiltersAmp_CB.AutoSize = true;
            this.FiltersAmp_CB.Location = new System.Drawing.Point(3, 52);
            this.FiltersAmp_CB.Name = "FiltersAmp_CB";
            this.FiltersAmp_CB.Size = new System.Drawing.Size(90, 17);
            this.FiltersAmp_CB.TabIndex = 4;
            this.FiltersAmp_CB.Text = "12 dB Amplify";
            this.FiltersAmp_CB.UseVisualStyleBackColor = true;
            this.FiltersAmp_CB.CheckedChanged += new System.EventHandler(this.FiltersAmp_CB_CheckedChanged);
            // 
            // MHz_label
            // 
            this.MHz_label.AutoSize = true;
            this.MHz_label.Location = new System.Drawing.Point(121, 28);
            this.MHz_label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.MHz_label.Name = "MHz_label";
            this.MHz_label.Size = new System.Drawing.Size(29, 13);
            this.MHz_label.TabIndex = 3;
            this.MHz_label.Text = "MHz";
            // 
            // Filters_TextBox
            // 
            this.Filters_TextBox.Location = new System.Drawing.Point(3, 26);
            this.Filters_TextBox.MaxLength = 2;
            this.Filters_TextBox.Name = "Filters_TextBox";
            this.Filters_TextBox.Size = new System.Drawing.Size(112, 20);
            this.Filters_TextBox.TabIndex = 1;
            this.Filters_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Filters_TextBox_KeyPress);
            // 
            // ChipEn_CB
            // 
            this.ChipEn_CB.AutoSize = true;
            this.ChipEn_CB.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChipEn_CB.Location = new System.Drawing.Point(32, 3);
            this.ChipEn_CB.Name = "ChipEn_CB";
            this.ChipEn_CB.Size = new System.Drawing.Size(83, 17);
            this.ChipEn_CB.TabIndex = 5;
            this.ChipEn_CB.Text = "Chip Enable";
            this.ChipEn_CB.UseVisualStyleBackColor = true;
            this.ChipEn_CB.CheckedChanged += new System.EventHandler(this.ChipEn_CB_CheckedChanged);
            // 
            // Filters_TextLabel
            // 
            this.Filters_TextLabel.AutoSize = true;
            this.Filters_TextLabel.Location = new System.Drawing.Point(3, 81);
            this.Filters_TextLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Filters_TextLabel.Name = "Filters_TextLabel";
            this.Filters_TextLabel.Size = new System.Drawing.Size(35, 13);
            this.Filters_TextLabel.TabIndex = 2;
            this.Filters_TextLabel.Text = "label1";
            this.Filters_TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 262);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltersForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Filters Settings";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Apply_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.VScrollBar Filters_ScrollBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox Filters_TextBox;
        private System.Windows.Forms.CheckBox FiltersAmp_CB;
        private System.Windows.Forms.Label MHz_label;
        private System.Windows.Forms.Label Filters_TextLabel;
        private System.Windows.Forms.CheckBox ChipEn_CB;
    }
}