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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            string num, a, b;
            num = textBox1.Text;
            a = textBox2.Text;
            b = textBox3.Text;
            var Num = int.Parse(num);
            var aa = int.Parse(a);
            var bb = int.Parse(b);
            var count = 0;
            var tmpNum = Num;
            do count += tmpNum % 10 > aa ? 1 : 0;
            while ((tmpNum /= 10) != 0);
            string count_st = count.ToString();
            textBox4.Text = count_st;
            if (Num < aa || Num > bb)
            {
                textBox5.Text = "Нет";
            }
            else textBox5.Text = "Да";
            if (Num % 3 == 0 && Num % 4 == 0 && Num % 5 == 0)
            {
                textBox6.Text = "Да";
            }
            else textBox6.Text = "Нет";
        }
    }
}