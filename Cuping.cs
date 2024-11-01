using System;
using System.Drawing;
using System.Windows.Forms;

namespace math
{
    public partial class Cuping : Form
    {
        Random rnd = new Random();
        int number;

        public Cuping()
        {
            InitializeComponent();
            number = rnd.Next(1, 15);
            label1.Text = number.ToString();
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Hide();
            Menu form1 = new Menu();
            form1.Show();
        }

        private void NewQuestion()
        {
            number = rnd.Next(1, 15);
            label1.Text = number.ToString();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            NewQuestion();
            correctlabel.Visible = false;
            cevapyeri1.Visible = false;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
          
            string userAnswer = textbox.Text;
            string answer = (number * number*number).ToString();
            if (textbox.Text == "" || textbox.Text.Length == 0)
            {
                emptytext.Visible = true;
                correctlabel.Visible = false;
                cevapyeri1.Visible = false;
            }
            else
            {
                emptytext.Visible = false;
                
                if (answer == userAnswer)
                {
                    correctlabel.Visible = true;
                    NewQuestion();
                    cevapyeri1.Visible = false;
                }
                else if (userAnswer !=answer)
                {
                    correctlabel.Visible = false;
                    cevapyeri1.Visible = true;
                    cevapyeri1.ForeColor = Color.Firebrick;
                    cevapyeri1.Text =  "Answer was : " + answer;
                    NewQuestion();
                }
                textbox.Text = "";
            }
        }

        private void Cuping_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Application.Exit();

        }
    }
}