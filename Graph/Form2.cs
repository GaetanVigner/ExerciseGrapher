using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form2 : Form
    {
        BinThrow bt = new BinThrow();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var series = bt.Execute();
            chart1.Series.Add(series);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bt.Throw = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bt.Bin = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Tag = this;
            index.Show(this);
            Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
