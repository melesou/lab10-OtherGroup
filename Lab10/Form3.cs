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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (radioButton3.Checked)
                i++;
            if (radioButton6.Checked)
                i++;
            if (radioButton9.Checked)
                i++;
            if (radioButton10.Checked)
                i++;
            if (radioButton14.Checked)
                i++;
            if(i <= 2)
                label6.Text = "Оценка: Плохо";
            if (i == 3)
                label6.Text = "Оценка: Удовлетворительно";
            if (i == 4)
                label6.Text = "Оценка: Хорошо";
            if (i == 5)
                label6.Text = "Оценка: Отлично";
        }
    }
}
