using MetroFramework.Forms;
using System;

namespace MAtH
{
    public partial class rotmgStats : MetroForm
    {
        public rotmgStats()
        {
            InitializeComponent();
        }

        private void boxStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxStats.SelectedIndex >= 1 || boxStats.SelectedIndex < 8)
            {
                labelMaxStat.Visible = true;
                labelMinStat.Visible = true;
                numMaxStat.Visible = true;
                numMinStat.Visible = true;
            }
            else
            {
                labelMaxStat.Visible = false;
                labelMinStat.Visible = false;
                numMaxStat.Visible = false;
                numMinStat.Visible = false;
            }
        }
    }
}