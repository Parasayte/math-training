using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

 
        private void plus_Click(object sender, EventArgs e)
        {
            Hide();
            Addition addition = new Addition();
            addition.Show();
        }

        private void plus_MouseEnter(object sender, EventArgs e)
        {
            plus.ForeColor = Color.Crimson;
        }

        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plus.ForeColor = Color.Maroon;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            Subtract subtract = new Subtract();
            subtract.Show();
        }

     
        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            Multiplication multiplication = new Multiplication();
            multiplication.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            Division division = new Division();
            division.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {    Hide();
            Squaring squaring = new Squaring();
            squaring.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Hide();
Cuping cuping = new Cuping();
cuping.Show();
        }

      
    }
}
