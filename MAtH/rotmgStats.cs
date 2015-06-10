using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Linq;

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
            if (Enumerable.Range(0, 8).Contains(boxStats.SelectedIndex))
            {
                labelMaxStat.Visible = true;
                labelMinStat.Visible = true;
                labelStartValue.Visible = true;
                numMaxStat.Visible = true;
                numMinStat.Visible = true;
                numStartValue.Visible = true;
                tileCalculate.Visible = true;
            }
            else
            {
                labelMaxStat.Visible = false;
                labelMinStat.Visible = false;
                labelStartValue.Visible = false;
                numMaxStat.Visible = false;
                numMinStat.Visible = false;
                numStartValue.Visible = false;
                tileCalculate.Visible = false;
                tileExecution.Visible = false;
            }
        }

        private void tileCalculate_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();
            int stat = (int)numStartValue.Value, min = (int)numMinStat.Value, max = (int)numMaxStat.Value;
            stopwatch.Start();
            for (int i = 1; i <= 20; i++)
            {
                if (i != 1)
                    stat += random.Next(min, max);
                switch (i)
                {
                    case 1:
                        labelLevel1.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 2:
                        labelLevel2.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 3:
                        labelLevel3.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 4:
                        labelLevel4.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 5:
                        labelLevel5.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 6:
                        labelLevel6.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 7:
                        labelLevel7.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 8:
                        labelLevel8.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 9:
                        labelLevel9.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 10:
                        labelLevel10.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 11:
                        labelLevel11.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 12:
                        labelLevel12.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 13:
                        labelLevel13.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 14:
                        labelLevel14.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 15:
                        labelLevel15.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 16:
                        labelLevel16.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 17:
                        labelLevel17.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 18:
                        labelLevel18.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 19:
                        labelLevel19.Text = String.Format("Level {0}: ", i) + stat;
                        break;

                    case 20:
                        labelLevel20.Text = String.Format("Level {0}: ", i) + stat;
                        break;
                }
            }
            tileExecution.Text = String.Format("Execution time: {0} ms", stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();
            tileExecution.Visible = true;
            boxLevels.Visible = true;
        }
    }
}