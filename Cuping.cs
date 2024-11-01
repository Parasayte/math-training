using System;
using System.Windows.Forms;

namespace math
{
    public partial class Cuping : Form
    {
        public Cuping()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        
    }
}