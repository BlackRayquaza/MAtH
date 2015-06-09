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
                tileCalculate.Visible = true;
            }
            else
            {
                labelMaxStat.Visible = false;
                labelMinStat.Visible = false;
                numMaxStat.Visible = false;
                numMinStat.Visible = false;
                tileCalculate.Visible = false;
            }
        }

        private void tileCalculate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int stat = 0, min = (int)numMinStat.Value, max = (int)numMaxStat.Value;
            for (int i = 1; i <= 20; i++)
            {
                switch (i)
                {
                    case 1:
                        stat += random.Next(min, max);
                        labelLevel1.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 2:
                        stat += random.Next(min, max);
                        labelLevel2.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 3:
                        stat += random.Next(min, max);
                        labelLevel3.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 4:
                        stat += random.Next(min, max);
                        labelLevel4.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 5:
                        stat += random.Next(min, max);
                        labelLevel5.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 6:
                        stat += random.Next(min, max);
                        labelLevel6.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 7:
                        stat += random.Next(min, max);
                        labelLevel7.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 8:
                        stat += random.Next(min, max);
                        labelLevel8.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 9:
                        stat += random.Next(min, max);
                        labelLevel9.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 10:
                        stat += random.Next(min, max);
                        labelLevel10.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 11:
                        stat += random.Next(min, max);
                        labelLevel11.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 12:
                        stat += random.Next(min, max);
                        labelLevel12.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 13:
                        stat += random.Next(min, max);
                        labelLevel13.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 14:
                        stat += random.Next(min, max);
                        labelLevel14.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 15:
                        stat += random.Next(min, max);
                        labelLevel15.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 16:
                        stat += random.Next(min, max);
                        labelLevel16.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 17:
                        stat += random.Next(min, max);
                        labelLevel17.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 18:
                        stat += random.Next(min, max);
                        labelLevel18.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 19:
                        stat += random.Next(min, max);
                        labelLevel19.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 20:
                        stat += random.Next(min, max);
                        labelLevel20.Text = String.Format("Level {0}: ", i) + stat;
                        break;
                }
            }
            boxLevels.Visible = true;
        }
    }
}