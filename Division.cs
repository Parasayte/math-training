using System;
using System.Drawing;
using System.Windows.Forms;

namespace math
{
    public partial class Division : Form
    {
        Random random = new Random();
        private int n1;
        private int n2;
        public Division()
        {
            InitializeComponent();
            NewQuestion();
        }
        private void NewQuestion()
        {
            n1 = random.Next(1, 12);
            n2 = random.Next(1, 12);
            label1.Text = (n2 * n1).ToString();
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
            string userAnswer = textbox.Text;
            string answer = (n1 * n2/n2).ToString();
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
                else if (userAnswer != answer)
                {
                    correctlabel.Visible = false;
                    cevapyeri1.Visible = true;
                    cevapyeri1.ForeColor = Color.Firebrick;
                    cevapyeri1.Text = "Answer was : " + answer;
                    NewQuestion();
                }

                textbox.Text = "";
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            NewQuestion();
            correctlabel.Visible = false;
            cevapyeri1.Visible = false;
        }

        private void Division_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
