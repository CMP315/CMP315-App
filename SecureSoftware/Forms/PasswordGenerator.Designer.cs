﻿namespace SecureSoftware
{
    partial class PasswordGenerator
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            CopyButton = new Button();
            RefreshButton = new Button();
            PasswordVisibilityButton = new FontAwesome.Sharp.IconButton();
            PasswordLengthTrackBar = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            UppercaseCheckbox = new CheckBox();
            LowercaseCheckbox = new CheckBox();
            DigitsCheckbox = new CheckBox();
            SymbolsCheckbox = new CheckBox();
            EmojisCheckbox = new CheckBox();
            AvoidSimilarCheckbox = new CheckBox();
            AvoidAmbigiousCheckbox = new CheckBox();
            GeneratedPasswordTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthTrackBar).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(493, 47);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(100, 48, 122);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(493, 46);
            label1.TabIndex = 1;
            label1.Text = "PASSMAN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 63);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 2;
            label2.Text = "Your Generated Password";
            // 
            // CopyButton
            // 
            CopyButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyButton.Cursor = Cursors.Hand;
            CopyButton.FlatAppearance.BorderColor = Color.Black;
            CopyButton.FlatAppearance.BorderSize = 0;
            CopyButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyButton.FlatStyle = FlatStyle.Flat;
            CopyButton.ForeColor = Color.White;
            CopyButton.Location = new Point(16, 107);
            CopyButton.Margin = new Padding(0);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(78, 23);
            CopyButton.TabIndex = 3;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = false;
            CopyButton.Click += CopyButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(41, 128, 185);
            RefreshButton.Cursor = Cursors.Hand;
            RefreshButton.FlatAppearance.BorderColor = Color.Black;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            RefreshButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(96, 107);
            RefreshButton.Margin = new Padding(0);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(78, 23);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // PasswordVisibilityButton
            // 
            PasswordVisibilityButton.FlatAppearance.BorderSize = 0;
            PasswordVisibilityButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            PasswordVisibilityButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            PasswordVisibilityButton.FlatStyle = FlatStyle.Flat;
            PasswordVisibilityButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            PasswordVisibilityButton.IconColor = Color.Black;
            PasswordVisibilityButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PasswordVisibilityButton.IconSize = 25;
            PasswordVisibilityButton.Location = new Point(434, 83);
            PasswordVisibilityButton.Name = "PasswordVisibilityButton";
            PasswordVisibilityButton.Size = new Size(49, 19);
            PasswordVisibilityButton.TabIndex = 5;
            PasswordVisibilityButton.UseVisualStyleBackColor = true;
            PasswordVisibilityButton.Click += PasswordVisibilityButton_Click;
            // 
            // PasswordLengthTrackBar
            // 
            PasswordLengthTrackBar.LargeChange = 10;
            PasswordLengthTrackBar.Location = new Point(238, 157);
            PasswordLengthTrackBar.Maximum = 100;
            PasswordLengthTrackBar.Minimum = 1;
            PasswordLengthTrackBar.Name = "PasswordLengthTrackBar";
            PasswordLengthTrackBar.Size = new Size(245, 45);
            PasswordLengthTrackBar.TabIndex = 6;
            PasswordLengthTrackBar.Value = 1;
            PasswordLengthTrackBar.Scroll += PasswordLengthTrackBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 187);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 7;
            label3.Text = "1 character";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 139);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 8;
            label4.Text = "Maximum Password Length";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(UppercaseCheckbox);
            flowLayoutPanel1.Controls.Add(LowercaseCheckbox);
            flowLayoutPanel1.Controls.Add(DigitsCheckbox);
            flowLayoutPanel1.Controls.Add(SymbolsCheckbox);
            flowLayoutPanel1.Controls.Add(EmojisCheckbox);
            flowLayoutPanel1.Controls.Add(AvoidSimilarCheckbox);
            flowLayoutPanel1.Controls.Add(AvoidAmbigiousCheckbox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(16, 139);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(206, 183);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // UppercaseCheckbox
            // 
            UppercaseCheckbox.AutoSize = true;
            UppercaseCheckbox.Checked = true;
            UppercaseCheckbox.CheckState = CheckState.Checked;
            UppercaseCheckbox.Location = new Point(3, 3);
            UppercaseCheckbox.Name = "UppercaseCheckbox";
            UppercaseCheckbox.Size = new Size(103, 19);
            UppercaseCheckbox.TabIndex = 0;
            UppercaseCheckbox.Text = "Use Uppercase";
            UppercaseCheckbox.UseVisualStyleBackColor = true;
            UppercaseCheckbox.Click += UppercaseCheckbox_Click;
            // 
            // LowercaseCheckbox
            // 
            LowercaseCheckbox.AutoSize = true;
            LowercaseCheckbox.Checked = true;
            LowercaseCheckbox.CheckState = CheckState.Checked;
            LowercaseCheckbox.Location = new Point(3, 28);
            LowercaseCheckbox.Name = "LowercaseCheckbox";
            LowercaseCheckbox.Size = new Size(103, 19);
            LowercaseCheckbox.TabIndex = 1;
            LowercaseCheckbox.Text = "Use Lowercase";
            LowercaseCheckbox.UseVisualStyleBackColor = true;
            LowercaseCheckbox.CheckedChanged += LowercaseCheckbox_CheckedChanged;
            // 
            // DigitsCheckbox
            // 
            DigitsCheckbox.AutoSize = true;
            DigitsCheckbox.Checked = true;
            DigitsCheckbox.CheckState = CheckState.Checked;
            DigitsCheckbox.Location = new Point(3, 53);
            DigitsCheckbox.Name = "DigitsCheckbox";
            DigitsCheckbox.Size = new Size(78, 19);
            DigitsCheckbox.TabIndex = 2;
            DigitsCheckbox.Text = "Use Digits";
            DigitsCheckbox.UseVisualStyleBackColor = true;
            DigitsCheckbox.CheckedChanged += DigitsCheckbox_CheckedChanged;
            // 
            // SymbolsCheckbox
            // 
            SymbolsCheckbox.AutoSize = true;
            SymbolsCheckbox.Checked = true;
            SymbolsCheckbox.CheckState = CheckState.Checked;
            SymbolsCheckbox.Location = new Point(3, 78);
            SymbolsCheckbox.Name = "SymbolsCheckbox";
            SymbolsCheckbox.Size = new Size(93, 19);
            SymbolsCheckbox.TabIndex = 3;
            SymbolsCheckbox.Text = "Use Symbols";
            SymbolsCheckbox.UseVisualStyleBackColor = true;
            SymbolsCheckbox.CheckedChanged += SymbolsCheckbox_CheckedChanged;
            // 
            // EmojisCheckbox
            // 
            EmojisCheckbox.AutoSize = true;
            EmojisCheckbox.Enabled = false;
            EmojisCheckbox.Location = new Point(3, 103);
            EmojisCheckbox.Name = "EmojisCheckbox";
            EmojisCheckbox.Size = new Size(83, 19);
            EmojisCheckbox.TabIndex = 6;
            EmojisCheckbox.Text = "Use Emojis";
            EmojisCheckbox.UseVisualStyleBackColor = true;
            // 
            // AvoidSimilarCheckbox
            // 
            AvoidSimilarCheckbox.AutoSize = true;
            AvoidSimilarCheckbox.Enabled = false;
            AvoidSimilarCheckbox.Location = new Point(3, 128);
            AvoidSimilarCheckbox.Name = "AvoidSimilarCheckbox";
            AvoidSimilarCheckbox.Size = new Size(155, 19);
            AvoidSimilarCheckbox.TabIndex = 4;
            AvoidSimilarCheckbox.Text = "Avoid Similar Characters";
            AvoidSimilarCheckbox.UseVisualStyleBackColor = true;
            // 
            // AvoidAmbigiousCheckbox
            // 
            AvoidAmbigiousCheckbox.AutoSize = true;
            AvoidAmbigiousCheckbox.Enabled = false;
            AvoidAmbigiousCheckbox.Location = new Point(3, 153);
            AvoidAmbigiousCheckbox.Name = "AvoidAmbigiousCheckbox";
            AvoidAmbigiousCheckbox.Size = new Size(177, 19);
            AvoidAmbigiousCheckbox.TabIndex = 5;
            AvoidAmbigiousCheckbox.Tag = "";
            AvoidAmbigiousCheckbox.Text = "Avoid Ambigious Characters";
            AvoidAmbigiousCheckbox.UseVisualStyleBackColor = true;
            // 
            // GeneratedPasswordTextBox
            // 
            GeneratedPasswordTextBox.BackColor = SystemColors.Control;
            GeneratedPasswordTextBox.Location = new Point(16, 81);
            GeneratedPasswordTextBox.Name = "GeneratedPasswordTextBox";
            GeneratedPasswordTextBox.Size = new Size(468, 23);
            GeneratedPasswordTextBox.TabIndex = 11;
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 328);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PasswordLengthTrackBar);
            Controls.Add(PasswordVisibilityButton);
            Controls.Add(RefreshButton);
            Controls.Add(CopyButton);
            Controls.Add(label2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(GeneratedPasswordTextBox);
            Name = "PasswordGenerator";
            Text = "PasswordGenerator";
            Load += PasswordGenerator_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthTrackBar).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Button CopyButton;
        private Button RefreshButton;
        private FontAwesome.Sharp.IconButton PasswordVisibilityButton;
        private TrackBar PasswordLengthTrackBar;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox UppercaseCheckbox;
        private CheckBox LowercaseCheckbox;
        private CheckBox DigitsCheckbox;
        private CheckBox SymbolsCheckbox;
        private CheckBox AvoidSimilarCheckbox;
        private CheckBox AvoidAmbigiousCheckbox;
        private CheckBox EmojisCheckbox;
        private TextBox GeneratedPasswordTextBox;
    }
}