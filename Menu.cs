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
            label2.ForeColor= Color.Crimson;
        }

        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plus.ForeColor = Color.Maroon;
            label2.ForeColor=Color.FromArgb(54,0,0);
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


        private void label2_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

    
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           label5.ForeColor=Color.Aqua;
           label1.ForeColor=Color.Aqua;

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor=Color.DarkSlateGray;
            label1.ForeColor=Color.DarkTurquoise;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Violet;
            label6.ForeColor=Color.Violet;
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.DeepPink;
            label6.ForeColor = Color.Purple;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
           label4.ForeColor=Color.FromArgb(255, 255, 170);
           label7.ForeColor=Color.FromArgb(255, 255, 170);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor=Color.Orange;
            label7.ForeColor=Color.DarkGoldenrod;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
           label10.ForeColor=Color.Lime;
           label8.ForeColor=Color.Lime;

        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.ForestGreen;
            label8.ForeColor = Color.Green;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
           label11.ForeColor=Color.LightPink;
           label9.ForeColor = Color.LightPink;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {         
            label9.ForeColor = Color.Purple;
            label11.ForeColor=Color.Plum;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

      
    }
}
