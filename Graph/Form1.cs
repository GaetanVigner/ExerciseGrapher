using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        private readonly BinPickup bp = new();

        public Form1()
        {
            InitializeComponent();
            bp.Interation = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            bp.BinAmount = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
            bp.Bin = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var series = bp.Execute();
            if (series != null)
            {
                chart1.Series.Add(series);
            }
            else
            {
                MessageBox.Show("Values need to be positive integers",
                                     "Incorrect inputs",
                                     MessageBoxButtons.OK);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bp.Interation = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bp.BinAmount = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            bp.Bin = Convert.ToInt32(Math.Round(numericUpDown3.Value, 0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Index index = new()
            {
                Tag = this
            };
            index.Show(this);
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
