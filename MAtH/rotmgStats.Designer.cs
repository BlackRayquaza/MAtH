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
            this.labelSelectedStat = new MetroFramework.Controls.MetroLabel();
            this.labelMinStat = new MetroFramework.Controls.MetroLabel();
            this.numMinStat = new System.Windows.Forms.NumericUpDown();
            this.labelMaxStat = new MetroFramework.Controls.MetroLabel();
            this.numMaxStat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStat)).BeginInit();
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
            this.boxStats.Size = new System.Drawing.Size(121, 21);
            this.boxStats.TabIndex = 1;
            this.boxStats.SelectedIndexChanged += new System.EventHandler(this.boxStats_SelectedIndexChanged);
            // 
            // labelSelectedStat
            // 
            this.labelSelectedStat.AutoSize = true;
            this.labelSelectedStat.Location = new System.Drawing.Point(23, 246);
            this.labelSelectedStat.Name = "labelSelectedStat";
            this.labelSelectedStat.Size = new System.Drawing.Size(121, 19);
            this.labelSelectedStat.TabIndex = 2;
            this.labelSelectedStat.Text = "Selected stat: None";
            // 
            // labelMinStat
            // 
            this.labelMinStat.AutoSize = true;
            this.labelMinStat.Location = new System.Drawing.Point(150, 66);
            this.labelMinStat.Name = "labelMinStat";
            this.labelMinStat.Size = new System.Drawing.Size(34, 19);
            this.labelMinStat.TabIndex = 3;
            this.labelMinStat.Text = "Min:";
            this.labelMinStat.Visible = false;
            // 
            // numMinStat
            // 
            this.numMinStat.Location = new System.Drawing.Point(190, 64);
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
            this.labelMaxStat.Location = new System.Drawing.Point(259, 66);
            this.labelMaxStat.Name = "labelMaxStat";
            this.labelMaxStat.Size = new System.Drawing.Size(37, 19);
            this.labelMaxStat.TabIndex = 5;
            this.labelMaxStat.Text = "Max:";
            this.labelMaxStat.Visible = false;
            // 
            // numMaxStat
            // 
            this.numMaxStat.Location = new System.Drawing.Point(303, 64);
            this.numMaxStat.Name = "numMaxStat";
            this.numMaxStat.Size = new System.Drawing.Size(100, 20);
            this.numMaxStat.TabIndex = 6;
            this.numMaxStat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxStat.Visible = false;
            // 
            // rotmgStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 285);
            this.Controls.Add(this.numMaxStat);
            this.Controls.Add(this.labelMaxStat);
            this.Controls.Add(this.numMinStat);
            this.Controls.Add(this.labelMinStat);
            this.Controls.Add(this.labelSelectedStat);
            this.Controls.Add(this.boxStats);
            this.Name = "rotmgStats";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Realm of the Mad God: Stats";
            ((System.ComponentModel.ISupportInitialize)(this.numMinStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxStats;
        private MetroFramework.Controls.MetroLabel labelSelectedStat;
        private MetroFramework.Controls.MetroLabel labelMinStat;
        private System.Windows.Forms.NumericUpDown numMinStat;
        private MetroFramework.Controls.MetroLabel labelMaxStat;
        private System.Windows.Forms.NumericUpDown numMaxStat;
    }
}