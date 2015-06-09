namespace MAtH
{
    partial class Main
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
            this.groupRotMG = new System.Windows.Forms.GroupBox();
            this.rotmgTile1 = new MetroFramework.Controls.MetroTile();
            this.labelMoreLater = new MetroFramework.Controls.MetroLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.groupRotMG.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRotMG
            // 
            this.groupRotMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupRotMG.Controls.Add(this.rotmgTile1);
            this.groupRotMG.Location = new System.Drawing.Point(23, 63);
            this.groupRotMG.Name = "groupRotMG";
            this.groupRotMG.Size = new System.Drawing.Size(303, 76);
            this.groupRotMG.TabIndex = 0;
            this.groupRotMG.TabStop = false;
            this.groupRotMG.Text = "Realm of the Mad God";
            // 
            // rotmgTile1
            // 
            this.rotmgTile1.ActiveControl = null;
            this.rotmgTile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rotmgTile1.Location = new System.Drawing.Point(6, 19);
            this.rotmgTile1.Name = "rotmgTile1";
            this.rotmgTile1.Size = new System.Drawing.Size(291, 50);
            this.rotmgTile1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.rotmgTile1.TabIndex = 0;
            this.rotmgTile1.Text = "Stats";
            this.rotmgTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rotmgTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rotmgTile1.UseSelectable = true;
            this.rotmgTile1.Click += new System.EventHandler(this.rotmgTile1_Click);
            // 
            // labelMoreLater
            // 
            this.labelMoreLater.AutoSize = true;
            this.labelMoreLater.Location = new System.Drawing.Point(23, 143);
            this.labelMoreLater.Name = "labelMoreLater";
            this.labelMoreLater.Size = new System.Drawing.Size(100, 19);
            this.labelMoreLater.TabIndex = 1;
            this.labelMoreLater.Text = "More to come..";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(72, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(251, 143);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel1.TabIndex = 2;
            this.htmlLabel1.Text = "<a href=\"https://github.com/BlackRayquaza/MAtH\">Source code</a>";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 170);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.labelMoreLater);
            this.Controls.Add(this.groupRotMG);
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "MAtH";
            this.groupRotMG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupRotMG;
        private MetroFramework.Controls.MetroTile rotmgTile1;
        private MetroFramework.Controls.MetroLabel labelMoreLater;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
    }
}

