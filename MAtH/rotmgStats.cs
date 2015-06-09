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
            switch (boxStats.SelectedIndex)
            {
                case 0:
                    labelSelectedStat.Text = "Selected stat: Health";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                case 1:
                    labelSelectedStat.Text = "Selected stat: Mana";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                case 2:
                    labelSelectedStat.Text = "Selected stat: Attack";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                case 3:
                    labelSelectedStat.Text = "Selected stat: Defense";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                case 4:
                    labelSelectedStat.Text = "Selected stat: Speed";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                case 5:
                    labelSelectedStat.Text = "Selected stat: Dexterity";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                case 6:
                    labelSelectedStat.Text = "Selected stat: Vitality";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                case 7:
                    labelSelectedStat.Text = "Selected stat: Wisdom";
                    labelMaxStat.Visible = true;
                    labelMinStat.Visible = true;
                    numMaxStat.Visible = true;
                    numMinStat.Visible = true;
                    break;
                default: labelSelectedStat.Text = String.Format("Not supported: {0}", boxStats.SelectedIndex);
                    labelMaxStat.Visible = false;
                    labelMinStat.Visible = false;
                    numMaxStat.Visible = false;
                    numMinStat.Visible = false;
                    break;
            }
        }
    }
}