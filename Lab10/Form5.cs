using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLib;
namespace Lab10
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(textBox1.Text);
                int[] mas = new int[size];
                int rowCount = 1;
                int columnCount = size;
                int min = 1;
                int max = 10;
                dataGridView1.RowCount = rowCount;
                dataGridView1.ColumnCount = columnCount;
                mas = Creator.Generate(size, min, max);
                for (int i = 0; i < columnCount; i++)
                    dataGridView1.Rows[0].Cells[i].Value = mas[i];
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Окно ошибки");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int minVal = 10;
            int minPos = 0;
            
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                if((int)dataGridView1.Rows[0].Cells[i].Value % 2 == 1 && minVal > (int)dataGridView1.Rows[0].Cells[i].Value)
                {
                    minVal = (int)dataGridView1.Rows[0].Cells[i].Value;
                    minPos = i;
                }    
            }
            label2.Text = $"Ответ: значение:{minVal}, позиция:{minPos}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(textBox2.Text);
                int[] mas = new int[size];
                int rowCount = 1;
                int columnCount = size;
                int min = 1;
                int max = 10;
                dataGridView2.RowCount = rowCount;
                dataGridView2.ColumnCount = columnCount;
                mas = Creator.Generate(size, min, max);
                for (int i = 0; i < columnCount; i++)
                    dataGridView2.Rows[0].Cells[i].Value = mas[i];
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Окно ошибки");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox2.Text); i++)
                if (i % 2 == 0)
                    dataGridView2.Rows[0].Cells[i].Value = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int sizeX = int.Parse(textBox3.Text);
                int sizeY = int.Parse(textBox4.Text);
                int[,] mas = new int[sizeX,sizeY];
                int columnCount = sizeX;
                int rowCount = sizeY;
                int min = -1;
                int max = 10;
                dataGridView3.ColumnCount = columnCount;
                dataGridView3.RowCount = rowCount;
                mas = Creator.Generate(sizeX, sizeY, min, max);
                for (int i = 0; i < columnCount; i++)
                    for(int j = 0; j < rowCount; j++)
                        dataGridView3.Rows[j].Cells[i].Value = mas[i,j];
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Окно ошибки");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = "";
                int sizeX = int.Parse(textBox3.Text);
                int sizeY = int.Parse(textBox4.Text);
                int columnCount = sizeX;
                int rowCount = sizeY;
                int[,] mas = new int[sizeX, sizeY];
                for (int i = 0; i < columnCount; i++)
                    for (int j = 0; j < rowCount; j++)
                        mas[i, j] = (int)dataGridView3.Rows[j].Cells[i].Value;
                int count = 0;
                for (int i = 0; i < columnCount; i++)
                {
                    for (int j = 0; j < rowCount; j++)
                    {
                        if (mas[i, j] % 2 == 0)
                            count++;
                        else if (mas[i, j] < 0)
                            break;
                    }
                    textBox5.Text += $"{i + 1}:{count}  ";
                    count = 0;
                }
            }
            catch 
            {
                MessageBox.Show("Неверный формат", "Окно ошибки");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(textBox8.Text);
                int[,] mas = new int[size, size];
                dataGridView4.ColumnCount = size;
                dataGridView4.RowCount = size;
                for (int i = 0; i < size; i++)
                    for (int j = 0; j < size; j++)
                    {
                        if (j <= i)
                            dataGridView4.Rows[j].Cells[i].Value = (size - i).ToString();
                        else
                            dataGridView4.Rows[j].Cells[i].Value = "0";
                    }
            }
            catch
            {
                MessageBox.Show("Неверный формат", "Окно ошибки");
            }
        }
    }
}
