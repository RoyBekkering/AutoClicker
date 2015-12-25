namespace AutoClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Delay = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_Mode_Sequence = new System.Windows.Forms.RadioButton();
            this.radioButton_Mode_Continuous = new System.Windows.Forms.RadioButton();
            this.label_Keymode = new System.Windows.Forms.Label();
            this.tableLayoutPanel_Keymode = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_Keymode_HoldDown = new System.Windows.Forms.RadioButton();
            this.radioButton_Keymode_Toggle = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Keybind = new System.Windows.Forms.TextBox();
            this.button_Keybind_Set = new System.Windows.Forms.Button();
            this.label_Amount = new System.Windows.Forms.Label();
            this.numericUpDown_Amount = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel_Keymode.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_Delay, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_Keymode, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel_Keymode, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_Amount, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDown_Amount, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00135F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00136F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00135F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00085F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99508F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 243);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keybind";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delay (in miliseconds)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mode";
            // 
            // numericUpDown_Delay
            // 
            this.numericUpDown_Delay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_Delay.Location = new System.Drawing.Point(145, 52);
            this.numericUpDown_Delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Delay.Name = "numericUpDown_Delay";
            this.numericUpDown_Delay.Size = new System.Drawing.Size(135, 20);
            this.numericUpDown_Delay.TabIndex = 4;
            this.numericUpDown_Delay.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_Delay.ValueChanged += new System.EventHandler(this.numericUpDown_Delay_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton_Mode_Sequence, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton_Mode_Continuous, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(142, 97);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(141, 47);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // radioButton_Mode_Sequence
            // 
            this.radioButton_Mode_Sequence.AutoSize = true;
            this.radioButton_Mode_Sequence.Checked = true;
            this.radioButton_Mode_Sequence.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Mode_Sequence.Name = "radioButton_Mode_Sequence";
            this.radioButton_Mode_Sequence.Size = new System.Drawing.Size(74, 17);
            this.radioButton_Mode_Sequence.TabIndex = 0;
            this.radioButton_Mode_Sequence.TabStop = true;
            this.radioButton_Mode_Sequence.Text = "Sequence";
            this.radioButton_Mode_Sequence.UseVisualStyleBackColor = true;
            this.radioButton_Mode_Sequence.CheckedChanged += new System.EventHandler(this.radioButton_Mode_Sequence_CheckedChanged);
            // 
            // radioButton_Mode_Continuous
            // 
            this.radioButton_Mode_Continuous.AutoSize = true;
            this.radioButton_Mode_Continuous.Location = new System.Drawing.Point(3, 26);
            this.radioButton_Mode_Continuous.Name = "radioButton_Mode_Continuous";
            this.radioButton_Mode_Continuous.Size = new System.Drawing.Size(78, 17);
            this.radioButton_Mode_Continuous.TabIndex = 1;
            this.radioButton_Mode_Continuous.Text = "Continuous";
            this.radioButton_Mode_Continuous.UseVisualStyleBackColor = true;
            this.radioButton_Mode_Continuous.CheckedChanged += new System.EventHandler(this.radioButton_Mode_Continuous_CheckedChanged);
            // 
            // label_Keymode
            // 
            this.label_Keymode.AutoSize = true;
            this.label_Keymode.Enabled = false;
            this.label_Keymode.Location = new System.Drawing.Point(4, 148);
            this.label_Keymode.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label_Keymode.Name = "label_Keymode";
            this.label_Keymode.Size = new System.Drawing.Size(106, 26);
            this.label_Keymode.TabIndex = 8;
            this.label_Keymode.Text = "Keymode (in case of continous)";
            // 
            // tableLayoutPanel_Keymode
            // 
            this.tableLayoutPanel_Keymode.ColumnCount = 1;
            this.tableLayoutPanel_Keymode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Keymode.Controls.Add(this.radioButton_Keymode_HoldDown, 0, 0);
            this.tableLayoutPanel_Keymode.Controls.Add(this.radioButton_Keymode_Toggle, 0, 1);
            this.tableLayoutPanel_Keymode.Enabled = false;
            this.tableLayoutPanel_Keymode.Location = new System.Drawing.Point(142, 145);
            this.tableLayoutPanel_Keymode.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_Keymode.Name = "tableLayoutPanel_Keymode";
            this.tableLayoutPanel_Keymode.RowCount = 2;
            this.tableLayoutPanel_Keymode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Keymode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Keymode.Size = new System.Drawing.Size(141, 47);
            this.tableLayoutPanel_Keymode.TabIndex = 9;
            // 
            // radioButton_Keymode_HoldDown
            // 
            this.radioButton_Keymode_HoldDown.AutoSize = true;
            this.radioButton_Keymode_HoldDown.Checked = true;
            this.radioButton_Keymode_HoldDown.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Keymode_HoldDown.Name = "radioButton_Keymode_HoldDown";
            this.radioButton_Keymode_HoldDown.Size = new System.Drawing.Size(78, 17);
            this.radioButton_Keymode_HoldDown.TabIndex = 0;
            this.radioButton_Keymode_HoldDown.TabStop = true;
            this.radioButton_Keymode_HoldDown.Text = "Hold Down";
            this.radioButton_Keymode_HoldDown.UseVisualStyleBackColor = true;
            this.radioButton_Keymode_HoldDown.CheckedChanged += new System.EventHandler(this.radioButton_Keymode_HoldDown_CheckedChanged);
            // 
            // radioButton_Keymode_Toggle
            // 
            this.radioButton_Keymode_Toggle.AutoSize = true;
            this.radioButton_Keymode_Toggle.Location = new System.Drawing.Point(3, 26);
            this.radioButton_Keymode_Toggle.Name = "radioButton_Keymode_Toggle";
            this.radioButton_Keymode_Toggle.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Keymode_Toggle.TabIndex = 1;
            this.radioButton_Keymode_Toggle.Text = "Toggle";
            this.radioButton_Keymode_Toggle.UseVisualStyleBackColor = true;
            this.radioButton_Keymode_Toggle.CheckedChanged += new System.EventHandler(this.radioButton_Keymode_Toggle_CheckedChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.35461F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.64539F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_Keybind, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_Keybind_Set, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(142, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(141, 47);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // textBox_Keybind
            // 
            this.textBox_Keybind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Keybind.Enabled = false;
            this.textBox_Keybind.Location = new System.Drawing.Point(3, 4);
            this.textBox_Keybind.Margin = new System.Windows.Forms.Padding(3, 4, 1, 3);
            this.textBox_Keybind.Name = "textBox_Keybind";
            this.textBox_Keybind.Size = new System.Drawing.Size(67, 20);
            this.textBox_Keybind.TabIndex = 0;
            // 
            // button_Keybind_Set
            // 
            this.button_Keybind_Set.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Keybind_Set.Location = new System.Drawing.Point(72, 3);
            this.button_Keybind_Set.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.button_Keybind_Set.Name = "button_Keybind_Set";
            this.button_Keybind_Set.Size = new System.Drawing.Size(66, 23);
            this.button_Keybind_Set.TabIndex = 1;
            this.button_Keybind_Set.Text = "Set";
            this.button_Keybind_Set.UseVisualStyleBackColor = true;
            this.button_Keybind_Set.Click += new System.EventHandler(this.button_Keybind_Set_Click);
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(4, 196);
            this.label_Amount.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(98, 26);
            this.label_Amount.TabIndex = 7;
            this.label_Amount.Text = "Amount (in case of sequence)";
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_Amount.Location = new System.Drawing.Point(145, 196);
            this.numericUpDown_Amount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.Size = new System.Drawing.Size(135, 20);
            this.numericUpDown_Amount.TabIndex = 11;
            this.numericUpDown_Amount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Amount.ValueChanged += new System.EventHandler(this.numericUpDown_Amount_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "Auto Clicker";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel_Keymode.ResumeLayout(false);
            this.tableLayoutPanel_Keymode.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Delay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButton_Mode_Sequence;
        private System.Windows.Forms.RadioButton radioButton_Mode_Continuous;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label_Keymode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Keymode;
        private System.Windows.Forms.RadioButton radioButton_Keymode_HoldDown;
        private System.Windows.Forms.RadioButton radioButton_Keymode_Toggle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox_Keybind;
        private System.Windows.Forms.Button button_Keybind_Set;
        private System.Windows.Forms.NumericUpDown numericUpDown_Amount;
    }
}

