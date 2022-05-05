using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void setMax(TextBox textBox, VScrollBar vScrollBar)
        {
            try
            {
                int max = int.Parse(textBox.Text);
                vScrollBar.Maximum = max;
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Окно ошибки");
            }
        }
        private void redBar_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = redBar.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = 0;
                if (textBox1.Text == "")
                    value = 0;
                else
                    value = int.Parse(textBox1.Text);
                if (value > redBar.Maximum)
                    redBar.Value = redBar.Maximum;
                else
                    redBar.Value = value;
            }
            catch
            {

                MessageBox.Show("Неверно введенные данные", "Окно ошибки");
            }
            
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int value = vScrollBar1.Value;
            double dollars = value / 75;
            double euro = value / 85;
            label1.Text = "Рубли:" + value.ToString();
            label2.Text = "Доллары:" + dollars.ToString();
            label3.Text = "Евро:" + euro.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setMax(textBox2, vScrollBar1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setMax(textBox3, redBar);
        }


    }
}
