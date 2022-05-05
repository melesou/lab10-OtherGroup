using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            string check = label1.Text;
            if (check.Length != 0)
            {
                if (check[check.Length - 1] == '+' ||
                check[check.Length - 1] == '-' ||
                check[check.Length - 1] == '/' ||
                check[check.Length - 1] == '*')
                {
                    Button button = (Button)sender;
                    label1.Text += " ";
                    textBox1.Text = button.Text;
                }
                else
                {
                    Button button = (Button)sender;
                    textBox1.Text += button.Text;
                }
            }

            else
            {
                Button button = (Button)sender;
                textBox1.Text += button.Text;
            }

        }
        private void buttonClickAction(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = textBox1.Text + " " + button.Text;
        }
        private void checkPrevSymb(object sender, EventArgs e)
        {
            string check = textBox1.Text;
            if (textBox1.Text == "")
                textBox1.Text = "0";
            if (check.IndexOf(",") == -1)
                textBox1.Text += ",";
        }
        private void getAnswer(object sender, EventArgs e)
        {
            string buff = label1.Text;
            string[] stroka = buff.Split(' ');
            double a1 = double.Parse(stroka[0]);
            string operat = stroka[1];
            double a2 = double.Parse(textBox1.Text);
            double result = 0;
            if (operat == "-")
                result = a1 - a2;
            else if (operat == "+")
                result = a1 + a2;
            else if (operat == "/")
                result = a1 / a2;
            else if (operat == "*")
                result = a1 * a2;
            label1.Text = result.ToString();
            textBox1.Text = "";
        }
        private void clearAll(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBox2.Text);
                double p = double.Parse(textBox3.Text);
                double y = 0;
                if (x < -10)
                    y = x * x - p * p + 2;
                else if (x < 3)
                    y = 2 * (x * x * x) - p / 3;
                else if (x > 3)
                    y = 5 * (x * x * x) - 4 * (x * x) + 2;
                label4.Text = "Ответ: " + y.ToString();
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Окно ошибки");
            }



        }
    }
}
