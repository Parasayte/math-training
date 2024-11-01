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
        private Color a;
        public Menu()
        {
            InitializeComponent();
        }

        private void mouseENTER(Label l)
        {
             a=l.ForeColor;
            l.ForeColor=Color.White;
            
        }

        private void mouseLEAVE(Label l)
        {
            l.ForeColor=a;
        }

       

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           mouseENTER(label1);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            mouseLEAVE(label1);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            mouseENTER(label2);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            mouseLEAVE(label2);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            mouseENTER(label3);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            mouseLEAVE(label3);
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            mouseENTER(label4);

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            mouseLEAVE(label4);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            mouseENTER(label5);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            mouseLEAVE(label5);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            mouseENTER(label6);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            mouseLEAVE(label6);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            Addition addition = new Addition();
            addition.Show();
        }

        private void label2_Click(object sender, EventArgs e)
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
            Squaring squaring = new Squaring();
            squaring.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Hide();
            Cuping cuping = new Cuping();
            cuping.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Hide();
            Division division = new Division();
            division.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
