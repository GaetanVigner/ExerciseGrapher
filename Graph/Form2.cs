using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form2 : Form
    {
        private readonly BinThrow Bt = new();

        public Form2()
        {
            InitializeComponent();
            Bt.Throw = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
            Bt.Bin = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var series = Bt.Execute();
            if (series != null)
            {
                chart1.Series.Add(series);
            }
            else {
                MessageBox.Show("Values need to be positive integers",
                                     "Incorrect inputs",
                                     MessageBoxButtons.OK);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Bt.Throw = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Bt.Bin = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
