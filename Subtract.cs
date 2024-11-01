using System;
using System.Drawing;
using System.Windows.Forms;

namespace math
{
    public partial class Subtract : Form
    {
        private int n1;
        private int n2;
        Random rnd = new Random();
        public Subtract()
        {
            InitializeComponent();
            NewQuestion();
        }

        private void NewQuestion()
        {
            n1 = rnd.Next(1, 150);
            n2 = rnd.Next(1, 150);
            label1.Text = n1.ToString();
            label3.Text = n2.ToString();
           
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            Menu form1 = new Menu();
            form1.Show();

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            string stringcevap=textbox.Text;
            if (textbox.Text == ""||textbox.Text.Length==0)
            {
                emptytext.Visible = true;
                correctlabel.Visible = false;
                cevapyeri1.Visible = false;
            }
            else
            {
                emptytext.Visible = false;
                if (stringcevap == (n1- n2).ToString())
                {
                    correctlabel.Visible = true;
                    NewQuestion();
                    cevapyeri1.Visible = false;
                }
                else if (stringcevap != (n1- n2).ToString())
                {
                    correctlabel.Visible = false;
                    cevapyeri1.Visible = true;
                    cevapyeri1.ForeColor = Color.Firebrick;
                    cevapyeri1.Text =  @"Answer was : " + (n1- n2);
                    NewQuestion();
                }
                else
                {
                    cevapyeri1.Visible = true;
                }
            }
            textbox.Text = "";
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            NewQuestion();
            correctlabel.Visible = false;
            cevapyeri1.Visible = false;        }

        private void Subtract_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}