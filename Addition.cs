using System;
using System.Windows.Forms;

namespace math
{
    public partial class Addition : Form
    {
        public Addition()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   Hide();
            Menu form1 = new Menu();
            form1.Show();
        }
    }
}