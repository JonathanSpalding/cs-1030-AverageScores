using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AverageScores
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = ofd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = ofd.FileName;
                StreamReader f = new StreamReader(fileName);
                float total = 0, count = 0;

            while (!f.EndOfStream)
            {

                string textScore = f.ReadLine();
                FirstScores.Items.Add(textScore);
                int score = int.Parse(textScore);
                total = total + score;
                count = count + 1;
            }

                f.Close();
                float average = total / count;
                lblAverage.Text = average.ToString("#0.0");
            }
        }

    }
}
