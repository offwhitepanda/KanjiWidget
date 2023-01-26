namespace KanjiWidget
{
    partial class KanjiUI
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
            this.kanjiLabel = new System.Windows.Forms.Label();
            this.englishLabel = new System.Windows.Forms.Label();
            this.romanjiLabel = new System.Windows.Forms.Label();
            this.grade1CheckBox = new System.Windows.Forms.CheckBox();
            this.grade2CheckBox = new System.Windows.Forms.CheckBox();
            this.randomizeCheckBox = new System.Windows.Forms.CheckBox();
            this.grade3CheckBox = new System.Windows.Forms.CheckBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hiraganaCheckBox = new System.Windows.Forms.CheckBox();
            this.katakanaCheckBox = new System.Windows.Forms.CheckBox();
            this.grade4CheckBox = new System.Windows.Forms.CheckBox();
            this.grade5CheckBox = new System.Windows.Forms.CheckBox();
            this.grade6CheckBox = new System.Windows.Forms.CheckBox();
            this.gradeSecondaryCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // kanjiLabel
            // 
            this.kanjiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kanjiLabel.AutoSize = true;
            this.kanjiLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kanjiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kanjiLabel.Location = new System.Drawing.Point(-4, 70);
            this.kanjiLabel.Name = "kanjiLabel";
            this.kanjiLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kanjiLabel.Size = new System.Drawing.Size(391, 163);
            this.kanjiLabel.TabIndex = 0;
            this.kanjiLabel.Text = "Kanji";
            this.kanjiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishLabel.Location = new System.Drawing.Point(66, 276);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(122, 37);
            this.englishLabel.TabIndex = 1;
            this.englishLabel.Text = "English";
            // 
            // romanjiLabel
            // 
            this.romanjiLabel.AutoSize = true;
            this.romanjiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romanjiLabel.Location = new System.Drawing.Point(73, 236);
            this.romanjiLabel.Name = "romanjiLabel";
            this.romanjiLabel.Size = new System.Drawing.Size(119, 32);
            this.romanjiLabel.TabIndex = 2;
            this.romanjiLabel.Text = "Romanji";
            // 
            // grade1CheckBox
            // 
            this.grade1CheckBox.AutoSize = true;
            this.grade1CheckBox.Checked = true;
            this.grade1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grade1CheckBox.Location = new System.Drawing.Point(12, 13);
            this.grade1CheckBox.Name = "grade1CheckBox";
            this.grade1CheckBox.Size = new System.Drawing.Size(44, 24);
            this.grade1CheckBox.TabIndex = 3;
            this.grade1CheckBox.Text = "1";
            this.grade1CheckBox.UseVisualStyleBackColor = true;
            this.grade1CheckBox.CheckedChanged += new System.EventHandler(this.grade1CheckBox_CheckedChanged);
            // 
            // grade2CheckBox
            // 
            this.grade2CheckBox.AutoSize = true;
            this.grade2CheckBox.Location = new System.Drawing.Point(56, 13);
            this.grade2CheckBox.Name = "grade2CheckBox";
            this.grade2CheckBox.Size = new System.Drawing.Size(44, 24);
            this.grade2CheckBox.TabIndex = 4;
            this.grade2CheckBox.Text = "2";
            this.grade2CheckBox.UseVisualStyleBackColor = true;
            this.grade2CheckBox.CheckedChanged += new System.EventHandler(this.grade2CheckBox_CheckedChanged);
            // 
            // randomizeCheckBox
            // 
            this.randomizeCheckBox.AutoSize = true;
            this.randomizeCheckBox.Location = new System.Drawing.Point(156, 13);
            this.randomizeCheckBox.Name = "randomizeCheckBox";
            this.randomizeCheckBox.Size = new System.Drawing.Size(116, 24);
            this.randomizeCheckBox.TabIndex = 5;
            this.randomizeCheckBox.Text = "Randomize";
            this.randomizeCheckBox.UseVisualStyleBackColor = true;
            this.randomizeCheckBox.CheckedChanged += new System.EventHandler(this.randomizeCheckBox_CheckedChanged);
            // 
            // grade3CheckBox
            // 
            this.grade3CheckBox.AutoSize = true;
            this.grade3CheckBox.Location = new System.Drawing.Point(106, 13);
            this.grade3CheckBox.Name = "grade3CheckBox";
            this.grade3CheckBox.Size = new System.Drawing.Size(44, 24);
            this.grade3CheckBox.TabIndex = 6;
            this.grade3CheckBox.Text = "3";
            this.grade3CheckBox.UseVisualStyleBackColor = true;
            this.grade3CheckBox.CheckedChanged += new System.EventHandler(this.grade3CheckBox_CheckedChanged);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(165, 328);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(87, 32);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.Text = "pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(24, 331);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hiraganaCheckBox
            // 
            this.hiraganaCheckBox.AutoSize = true;
            this.hiraganaCheckBox.Location = new System.Drawing.Point(215, 236);
            this.hiraganaCheckBox.Name = "hiraganaCheckBox";
            this.hiraganaCheckBox.Size = new System.Drawing.Size(47, 24);
            this.hiraganaCheckBox.TabIndex = 9;
            this.hiraganaCheckBox.Text = "H";
            this.hiraganaCheckBox.UseVisualStyleBackColor = true;
            this.hiraganaCheckBox.CheckedChanged += new System.EventHandler(this.hiraganaCheckBox_CheckedChanged);
            // 
            // katakanaCheckBox
            // 
            this.katakanaCheckBox.AutoSize = true;
            this.katakanaCheckBox.Location = new System.Drawing.Point(215, 267);
            this.katakanaCheckBox.Name = "katakanaCheckBox";
            this.katakanaCheckBox.Size = new System.Drawing.Size(45, 24);
            this.katakanaCheckBox.TabIndex = 10;
            this.katakanaCheckBox.Text = "K";
            this.katakanaCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.katakanaCheckBox.UseVisualStyleBackColor = true;
            this.katakanaCheckBox.CheckedChanged += new System.EventHandler(this.katakanaCheckBox_CheckedChanged);
            // 
            // grade4CheckBox
            // 
            this.grade4CheckBox.AutoSize = true;
            this.grade4CheckBox.Location = new System.Drawing.Point(12, 43);
            this.grade4CheckBox.Name = "grade4CheckBox";
            this.grade4CheckBox.Size = new System.Drawing.Size(44, 24);
            this.grade4CheckBox.TabIndex = 11;
            this.grade4CheckBox.Text = "4";
            this.grade4CheckBox.UseVisualStyleBackColor = true;
            this.grade4CheckBox.CheckedChanged += new System.EventHandler(this.grade4CheckBox_CheckedChanged);
            // 
            // grade5CheckBox
            // 
            this.grade5CheckBox.AutoSize = true;
            this.grade5CheckBox.Location = new System.Drawing.Point(56, 43);
            this.grade5CheckBox.Name = "grade5CheckBox";
            this.grade5CheckBox.Size = new System.Drawing.Size(44, 24);
            this.grade5CheckBox.TabIndex = 12;
            this.grade5CheckBox.Text = "5";
            this.grade5CheckBox.UseVisualStyleBackColor = true;
            this.grade5CheckBox.CheckedChanged += new System.EventHandler(this.grade5CheckBox_CheckedChanged);
            // 
            // grade6CheckBox
            // 
            this.grade6CheckBox.AutoSize = true;
            this.grade6CheckBox.Location = new System.Drawing.Point(106, 43);
            this.grade6CheckBox.Name = "grade6CheckBox";
            this.grade6CheckBox.Size = new System.Drawing.Size(44, 24);
            this.grade6CheckBox.TabIndex = 13;
            this.grade6CheckBox.Text = "6";
            this.grade6CheckBox.UseVisualStyleBackColor = true;
            this.grade6CheckBox.CheckedChanged += new System.EventHandler(this.grade6CheckBox_CheckedChanged);
            // 
            // gradeSecondaryCheckBox
            // 
            this.gradeSecondaryCheckBox.AutoSize = true;
            this.gradeSecondaryCheckBox.Location = new System.Drawing.Point(156, 43);
            this.gradeSecondaryCheckBox.Name = "gradeSecondaryCheckBox";
            this.gradeSecondaryCheckBox.Size = new System.Drawing.Size(111, 24);
            this.gradeSecondaryCheckBox.TabIndex = 14;
            this.gradeSecondaryCheckBox.Text = "Secondary";
            this.gradeSecondaryCheckBox.UseVisualStyleBackColor = true;
            this.gradeSecondaryCheckBox.CheckedChanged += new System.EventHandler(this.gradeSecondaryCheckBox_CheckedChanged);
            // 
            // KanjiUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 372);
            this.Controls.Add(this.gradeSecondaryCheckBox);
            this.Controls.Add(this.grade6CheckBox);
            this.Controls.Add(this.grade5CheckBox);
            this.Controls.Add(this.grade4CheckBox);
            this.Controls.Add(this.katakanaCheckBox);
            this.Controls.Add(this.hiraganaCheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.grade3CheckBox);
            this.Controls.Add(this.randomizeCheckBox);
            this.Controls.Add(this.grade2CheckBox);
            this.Controls.Add(this.grade1CheckBox);
            this.Controls.Add(this.romanjiLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.kanjiLabel);
            this.Name = "KanjiUI";
            this.Text = "Kanji - English";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kanjiLabel;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label romanjiLabel;
        private System.Windows.Forms.CheckBox grade1CheckBox;
        private System.Windows.Forms.CheckBox grade2CheckBox;
        private System.Windows.Forms.CheckBox randomizeCheckBox;
        private System.Windows.Forms.CheckBox grade3CheckBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox hiraganaCheckBox;
        private System.Windows.Forms.CheckBox katakanaCheckBox;
        private System.Windows.Forms.CheckBox grade4CheckBox;
        private System.Windows.Forms.CheckBox grade5CheckBox;
        private System.Windows.Forms.CheckBox grade6CheckBox;
        private System.Windows.Forms.CheckBox gradeSecondaryCheckBox;
    }
}

