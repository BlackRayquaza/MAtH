using MetroFramework.Forms;
using System;

namespace MAtH
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void rotmgTile1_Click(object sender, EventArgs e)
        {
            rotmgStats form = new rotmgStats();
            form.ShowDialog();
        }
    }
}