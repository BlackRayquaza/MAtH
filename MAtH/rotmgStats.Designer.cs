namespace MAtH
{
    partial class rotmgStats
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
            this.boxStats = new System.Windows.Forms.ComboBox();
            this.labelMinStat = new MetroFramework.Controls.MetroLabel();
            this.numMinStat = new System.Windows.Forms.NumericUpDown();
            this.labelMaxStat = new MetroFramework.Controls.MetroLabel();
            this.numMaxStat = new System.Windows.Forms.NumericUpDown();
            this.tileCalculate = new MetroFramework.Controls.MetroTile();
            this.boxLevels = new System.Windows.Forms.GroupBox();
            this.labelLevel1 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel2 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel3 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel4 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel5 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel6 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel7 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel8 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel9 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel10 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel11 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel12 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel13 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel14 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel15 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel16 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel17 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel18 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel19 = new MetroFramework.Controls.MetroLabel();
            this.labelLevel20 = new MetroFramework.Controls.MetroLabel();
            this.labelStartValue = new MetroFramework.Controls.MetroLabel();
            this.numStartValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStat)).BeginInit();
            this.boxLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue)).BeginInit();
            this.SuspendLayout();
            // 
            // boxStats
            // 
            this.boxStats.FormattingEnabled = true;
            this.boxStats.Items.AddRange(new object[] {
            "Health",
            "Mana",
            "Attack",
            "Defense",
            "Speed",
            "Dexterity",
            "Vitality",
            "Wisdom"});
            this.boxStats.Location = new System.Drawing.Point(23, 63);
            this.boxStats.Name = "boxStats";
            this.boxStats.Size = new System.Drawing.Size(83, 21);
            this.boxStats.TabIndex = 1;
            this.boxStats.Text = "Select one";
            this.boxStats.SelectedIndexChanged += new System.EventHandler(this.boxStats_SelectedIndexChanged);
            // 
            // labelMinStat
            // 
            this.labelMinStat.AutoSize = true;
            this.labelMinStat.Location = new System.Drawing.Point(211, 64);
            this.labelMinStat.Name = "labelMinStat";
            this.labelMinStat.Size = new System.Drawing.Size(34, 19);
            this.labelMinStat.TabIndex = 3;
            this.labelMinStat.Text = "Min:";
            this.labelMinStat.Visible = false;
            // 
            // numMinStat
            // 
            this.numMinStat.Location = new System.Drawing.Point(251, 64);
            this.numMinStat.Name = "numMinStat";
            this.numMinStat.Size = new System.Drawing.Size(62, 20);
            this.numMinStat.TabIndex = 4;
            this.numMinStat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinStat.Visible = false;
            // 
            // labelMaxStat
            // 
            this.labelMaxStat.AutoSize = true;
            this.labelMaxStat.Location = new System.Drawing.Point(319, 64);
            this.labelMaxStat.Name = "labelMaxStat";
            this.labelMaxStat.Size = new System.Drawing.Size(37, 19);
            this.labelMaxStat.TabIndex = 5;
            this.labelMaxStat.Text = "Max:";
            this.labelMaxStat.Visible = false;
            // 
            // numMaxStat
            // 
            this.numMaxStat.Location = new System.Drawing.Point(362, 64);
            this.numMaxStat.Name = "numMaxStat";
            this.numMaxStat.Size = new System.Drawing.Size(62, 20);
            this.numMaxStat.TabIndex = 6;
            this.numMaxStat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxStat.Visible = false;
            // 
            // tileCalculate
            // 
            this.tileCalculate.ActiveControl = null;
            this.tileCalculate.Location = new System.Drawing.Point(23, 90);
            this.tileCalculate.Name = "tileCalculate";
            this.tileCalculate.Size = new System.Drawing.Size(401, 23);
            this.tileCalculate.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tileCalculate.TabIndex = 7;
            this.tileCalculate.Text = "Calculate";
            this.tileCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileCalculate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileCalculate.UseSelectable = true;
            this.tileCalculate.Visible = false;
            this.tileCalculate.Click += new System.EventHandler(this.tileCalculate_Click);
            // 
            // boxLevels
            // 
            this.boxLevels.Controls.Add(this.labelLevel20);
            this.boxLevels.Controls.Add(this.labelLevel19);
            this.boxLevels.Controls.Add(this.labelLevel18);
            this.boxLevels.Controls.Add(this.labelLevel17);
            this.boxLevels.Controls.Add(this.labelLevel16);
            this.boxLevels.Controls.Add(this.labelLevel15);
            this.boxLevels.Controls.Add(this.labelLevel14);
            this.boxLevels.Controls.Add(this.labelLevel13);
            this.boxLevels.Controls.Add(this.labelLevel12);
            this.boxLevels.Controls.Add(this.labelLevel11);
            this.boxLevels.Controls.Add(this.labelLevel10);
            this.boxLevels.Controls.Add(this.labelLevel9);
            this.boxLevels.Controls.Add(this.labelLevel8);
            this.boxLevels.Controls.Add(this.labelLevel7);
            this.boxLevels.Controls.Add(this.labelLevel6);
            this.boxLevels.Controls.Add(this.labelLevel5);
            this.boxLevels.Controls.Add(this.labelLevel4);
            this.boxLevels.Controls.Add(this.labelLevel3);
            this.boxLevels.Controls.Add(this.labelLevel2);
            this.boxLevels.Controls.Add(this.labelLevel1);
            this.boxLevels.Location = new System.Drawing.Point(24, 120);
            this.boxLevels.Name = "boxLevels";
            this.boxLevels.Size = new System.Drawing.Size(400, 142);
            this.boxLevels.TabIndex = 8;
            this.boxLevels.TabStop = false;
            this.boxLevels.Visible = false;
            // 
            // labelLevel1
            // 
            this.labelLevel1.AutoSize = true;
            this.labelLevel1.Location = new System.Drawing.Point(6, 16);
            this.labelLevel1.Name = "labelLevel1";
            this.labelLevel1.Size = new System.Drawing.Size(56, 19);
            this.labelLevel1.TabIndex = 0;
            this.labelLevel1.Text = "Level 1: ";
            // 
            // labelLevel2
            // 
            this.labelLevel2.AutoSize = true;
            this.labelLevel2.Location = new System.Drawing.Point(6, 35);
            this.labelLevel2.Name = "labelLevel2";
            this.labelLevel2.Size = new System.Drawing.Size(56, 19);
            this.labelLevel2.TabIndex = 1;
            this.labelLevel2.Text = "Level 2: ";
            // 
            // labelLevel3
            // 
            this.labelLevel3.AutoSize = true;
            this.labelLevel3.Location = new System.Drawing.Point(6, 54);
            this.labelLevel3.Name = "labelLevel3";
            this.labelLevel3.Size = new System.Drawing.Size(56, 19);
            this.labelLevel3.TabIndex = 2;
            this.labelLevel3.Text = "Level 3: ";
            // 
            // labelLevel4
            // 
            this.labelLevel4.AutoSize = true;
            this.labelLevel4.Location = new System.Drawing.Point(6, 73);
            this.labelLevel4.Name = "labelLevel4";
            this.labelLevel4.Size = new System.Drawing.Size(56, 19);
            this.labelLevel4.TabIndex = 3;
            this.labelLevel4.Text = "Level 4: ";
            // 
            // labelLevel5
            // 
            this.labelLevel5.AutoSize = true;
            this.labelLevel5.Location = new System.Drawing.Point(6, 92);
            this.labelLevel5.Name = "labelLevel5";
            this.labelLevel5.Size = new System.Drawing.Size(56, 19);
            this.labelLevel5.TabIndex = 4;
            this.labelLevel5.Text = "Level 5: ";
            // 
            // labelLevel6
            // 
            this.labelLevel6.AutoSize = true;
            this.labelLevel6.Location = new System.Drawing.Point(95, 16);
            this.labelLevel6.Name = "labelLevel6";
            this.labelLevel6.Size = new System.Drawing.Size(56, 19);
            this.labelLevel6.TabIndex = 5;
            this.labelLevel6.Text = "Level 6: ";
            // 
            // labelLevel7
            // 
            this.labelLevel7.AutoSize = true;
            this.labelLevel7.Location = new System.Drawing.Point(95, 35);
            this.labelLevel7.Name = "labelLevel7";
            this.labelLevel7.Size = new System.Drawing.Size(56, 19);
            this.labelLevel7.TabIndex = 6;
            this.labelLevel7.Text = "Level 7: ";
            // 
            // labelLevel8
            // 
            this.labelLevel8.AutoSize = true;
            this.labelLevel8.Location = new System.Drawing.Point(95, 54);
            this.labelLevel8.Name = "labelLevel8";
            this.labelLevel8.Size = new System.Drawing.Size(56, 19);
            this.labelLevel8.TabIndex = 7;
            this.labelLevel8.Text = "Level 8: ";
            // 
            // labelLevel9
            // 
            this.labelLevel9.AutoSize = true;
            this.labelLevel9.Location = new System.Drawing.Point(95, 73);
            this.labelLevel9.Name = "labelLevel9";
            this.labelLevel9.Size = new System.Drawing.Size(56, 19);
            this.labelLevel9.TabIndex = 8;
            this.labelLevel9.Text = "Level 9: ";
            // 
            // labelLevel10
            // 
            this.labelLevel10.AutoSize = true;
            this.labelLevel10.Location = new System.Drawing.Point(95, 92);
            this.labelLevel10.Name = "labelLevel10";
            this.labelLevel10.Size = new System.Drawing.Size(63, 19);
            this.labelLevel10.TabIndex = 9;
            this.labelLevel10.Text = "Level 10: ";
            // 
            // labelLevel11
            // 
            this.labelLevel11.AutoSize = true;
            this.labelLevel11.Location = new System.Drawing.Point(195, 16);
            this.labelLevel11.Name = "labelLevel11";
            this.labelLevel11.Size = new System.Drawing.Size(63, 19);
            this.labelLevel11.TabIndex = 10;
            this.labelLevel11.Text = "Level 11: ";
            // 
            // labelLevel12
            // 
            this.labelLevel12.AutoSize = true;
            this.labelLevel12.Location = new System.Drawing.Point(195, 35);
            this.labelLevel12.Name = "labelLevel12";
            this.labelLevel12.Size = new System.Drawing.Size(63, 19);
            this.labelLevel12.TabIndex = 11;
            this.labelLevel12.Text = "Level 12: ";
            // 
            // labelLevel13
            // 
            this.labelLevel13.AutoSize = true;
            this.labelLevel13.Location = new System.Drawing.Point(195, 54);
            this.labelLevel13.Name = "labelLevel13";
            this.labelLevel13.Size = new System.Drawing.Size(63, 19);
            this.labelLevel13.TabIndex = 12;
            this.labelLevel13.Text = "Level 13: ";
            // 
            // labelLevel14
            // 
            this.labelLevel14.AutoSize = true;
            this.labelLevel14.Location = new System.Drawing.Point(195, 73);
            this.labelLevel14.Name = "labelLevel14";
            this.labelLevel14.Size = new System.Drawing.Size(63, 19);
            this.labelLevel14.TabIndex = 13;
            this.labelLevel14.Text = "Level 14: ";
            // 
            // labelLevel15
            // 
            this.labelLevel15.AutoSize = true;
            this.labelLevel15.Location = new System.Drawing.Point(195, 92);
            this.labelLevel15.Name = "labelLevel15";
            this.labelLevel15.Size = new System.Drawing.Size(63, 19);
            this.labelLevel15.TabIndex = 14;
            this.labelLevel15.Text = "Level 15: ";
            // 
            // labelLevel16
            // 
            this.labelLevel16.AutoSize = true;
            this.labelLevel16.Location = new System.Drawing.Point(298, 16);
            this.labelLevel16.Name = "labelLevel16";
            this.labelLevel16.Size = new System.Drawing.Size(63, 19);
            this.labelLevel16.TabIndex = 15;
            this.labelLevel16.Text = "Level 16: ";
            // 
            // labelLevel17
            // 
            this.labelLevel17.AutoSize = true;
            this.labelLevel17.Location = new System.Drawing.Point(298, 35);
            this.labelLevel17.Name = "labelLevel17";
            this.labelLevel17.Size = new System.Drawing.Size(63, 19);
            this.labelLevel17.TabIndex = 16;
            this.labelLevel17.Text = "Level 17: ";
            // 
            // labelLevel18
            // 
            this.labelLevel18.AutoSize = true;
            this.labelLevel18.Location = new System.Drawing.Point(298, 54);
            this.labelLevel18.Name = "labelLevel18";
            this.labelLevel18.Size = new System.Drawing.Size(63, 19);
            this.labelLevel18.TabIndex = 17;
            this.labelLevel18.Text = "Level 18: ";
            // 
            // labelLevel19
            // 
            this.labelLevel19.AutoSize = true;
            this.labelLevel19.Location = new System.Drawing.Point(298, 73);
            this.labelLevel19.Name = "labelLevel19";
            this.labelLevel19.Size = new System.Drawing.Size(63, 19);
            this.labelLevel19.TabIndex = 18;
            this.labelLevel19.Text = "Level 19: ";
            // 
            // labelLevel20
            // 
            this.labelLevel20.AutoSize = true;
            this.labelLevel20.Location = new System.Drawing.Point(298, 92);
            this.labelLevel20.Name = "labelLevel20";
            this.labelLevel20.Size = new System.Drawing.Size(63, 19);
            this.labelLevel20.TabIndex = 19;
            this.labelLevel20.Text = "Level 20: ";
            // 
            // labelStartValue
            // 
            this.labelStartValue.AutoSize = true;
            this.labelStartValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStartValue.Location = new System.Drawing.Point(113, 63);
            this.labelStartValue.Name = "labelStartValue";
            this.labelStartValue.Size = new System.Drawing.Size(36, 19);
            this.labelStartValue.TabIndex = 9;
            this.labelStartValue.Text = "Start";
            this.labelStartValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStartValue.Visible = false;
            // 
            // numStartValue
            // 
            this.numStartValue.Location = new System.Drawing.Point(155, 64);
            this.numStartValue.Maximum = new decimal(new int[] {
            770,
            0,
            0,
            0});
            this.numStartValue.Name = "numStartValue";
            this.numStartValue.Size = new System.Drawing.Size(50, 20);
            this.numStartValue.TabIndex = 10;
            this.numStartValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartValue.Visible = false;
            // 
            // rotmgStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 285);
            this.Controls.Add(this.numStartValue);
            this.Controls.Add(this.labelStartValue);
            this.Controls.Add(this.boxLevels);
            this.Controls.Add(this.tileCalculate);
            this.Controls.Add(this.numMaxStat);
            this.Controls.Add(this.labelMaxStat);
            this.Controls.Add(this.numMinStat);
            this.Controls.Add(this.labelMinStat);
            this.Controls.Add(this.boxStats);
            this.Name = "rotmgStats";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Realm of the Mad God: Stats";
            ((System.ComponentModel.ISupportInitialize)(this.numMinStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStat)).EndInit();
            this.boxLevels.ResumeLayout(false);
            this.boxLevels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxStats;
        private MetroFramework.Controls.MetroLabel labelMinStat;
        private System.Windows.Forms.NumericUpDown numMinStat;
        private MetroFramework.Controls.MetroLabel labelMaxStat;
        private System.Windows.Forms.NumericUpDown numMaxStat;
        private MetroFramework.Controls.MetroTile tileCalculate;
        private System.Windows.Forms.GroupBox boxLevels;
        private MetroFramework.Controls.MetroLabel labelLevel20;
        private MetroFramework.Controls.MetroLabel labelLevel19;
        private MetroFramework.Controls.MetroLabel labelLevel18;
        private MetroFramework.Controls.MetroLabel labelLevel17;
        private MetroFramework.Controls.MetroLabel labelLevel16;
        private MetroFramework.Controls.MetroLabel labelLevel15;
        private MetroFramework.Controls.MetroLabel labelLevel14;
        private MetroFramework.Controls.MetroLabel labelLevel13;
        private MetroFramework.Controls.MetroLabel labelLevel12;
        private MetroFramework.Controls.MetroLabel labelLevel11;
        private MetroFramework.Controls.MetroLabel labelLevel10;
        private MetroFramework.Controls.MetroLabel labelLevel9;
        private MetroFramework.Controls.MetroLabel labelLevel8;
        private MetroFramework.Controls.MetroLabel labelLevel7;
        private MetroFramework.Controls.MetroLabel labelLevel6;
        private MetroFramework.Controls.MetroLabel labelLevel5;
        private MetroFramework.Controls.MetroLabel labelLevel4;
        private MetroFramework.Controls.MetroLabel labelLevel3;
        private MetroFramework.Controls.MetroLabel labelLevel2;
        private MetroFramework.Controls.MetroLabel labelLevel1;
        private MetroFramework.Controls.MetroLabel labelStartValue;
        private System.Windows.Forms.NumericUpDown numStartValue;
    }
}