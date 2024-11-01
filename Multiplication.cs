using System;
using System.Windows.Forms;

namespace math
{
    public partial class Multiplication : Form
    {
        public Multiplication()
        {
            InitializeComponent();
        }

     

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            Menu form1 = new Menu();
            form1.Show();

        }
    }
}