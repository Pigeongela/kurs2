//Из элементов массива Р (предусмотреть возможность ввода массива случайно и
//случайно с заданной частотой) сформировать массив М той же размерности по правилу:
//если номер четный, то Mi=i*Pi, если нечетный, то Mi=-Pi. Заменить первый отрицательный
//элемент нулем. Умножить все элементы, кратные 3, на третий элемент массива.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }
        int i = 0;
        string logs;

    private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value); //Длина массива
            int i, P, k;
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = 2;
            dataGridView1.TopLeftHeaderCell.Value = "Массив";
            dataGridView1.Rows[0].HeaderCell.Value = "Р";
            dataGridView1.Rows[1].HeaderCell.Value = "М";
            Random rand = new Random();
        A:
            if (radioButton1.Checked == true && checkBox1.Checked == true)
            {
                timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = Convert.ToInt32(numericUpDown2.Value*1000);
                timer1.Enabled = true;
                timer1.Tick += timer1_Tick;
            }
            if (radioButton1.Checked == true && checkBox1.Checked == false)
            {
                //Формируем случайно Р
                for (i = 0; i < n; i++)
                {
                    dataGridView1[i, 0].Value = rand.Next(-10, 10);
                }
            }
            if (radioButton2.Checked == true)
            {
                //Формируем вручную Р
                for (i = 0; i < n; i++)
                {
                    dataGridView1.ReadOnly = false;
                    dataGridView1.Columns.AddRange();
                }
            }
            try
            {
                //Формируем М
                for (i = 0; i < n; i++)
                {
                    P = Convert.ToInt32(dataGridView1[i, 0].Value);
                    if (i % 2 == 0 && P % 3 != 0)
                    {
                        dataGridView1[i, 1].Value = i * P;
                    }
                    else
                    {
                        dataGridView1[i, 1].Value = -P;
                    }
                    if (P % 3 == 0 && i >= 2)
                    {
                        k = Convert.ToInt32(dataGridView1[2, 0].Value);
                        dataGridView1[i, 1].Value = P * k;
                    }
                }
                for (i = 0; i < n; i++)
                {
                    P = Convert.ToInt32(dataGridView1[i, 0].Value);
                    if (P < 0)
                    {
                        dataGridView1[i, 1].Value = 0;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                for (i = 0; i < n; i++)
                {
                    dataGridView1[i, 0].Value = null;
                }
                logs += Environment.NewLine + "*** Error! ***" + Environment.NewLine + "--------------" + Environment.NewLine + "ОШИБКА: " + ex.Message + Environment.NewLine + Environment.NewLine + "Метод: " + ex.TargetSite + Environment.NewLine + Environment.NewLine + "Вывод стека: " + ex.StackTrace + Environment.NewLine + Environment.NewLine + "Время возникновения: " + DateTime.Now + Environment.NewLine + Environment.NewLine;
                Form1 f1 = this.Owner as Form1;
                f1.setTextBox1(logs);
                goto A;
            }
            try
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    throw new Exception();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Выберите способ ввода массива");
                logs += Environment.NewLine + "*** Error! ***" + Environment.NewLine + "--------------" + Environment.NewLine + "ОШИБКА: " + exc.Message + Environment.NewLine + Environment.NewLine + "Метод: " + exc.TargetSite + Environment.NewLine + Environment.NewLine + "Вывод стека: " + exc.StackTrace + Environment.NewLine + Environment.NewLine + "Время возникновения: " + DateTime.Now + Environment.NewLine + Environment.NewLine;
                Form1 f1 = this.Owner as Form1;
                f1.setTextBox1(logs);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int m = Convert.ToInt32(numericUpDown1.Value);

            if (i < m)
            {
                dataGridView1[i, 0].Value = random.Next(-10, 10);
                i++;
            }
            else
            {
                timer1.Enabled = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                checkBox1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }
    }
}
