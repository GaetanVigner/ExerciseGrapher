using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show(this);
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Tag = this;
            form1.Show(this);
            Hide();
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
