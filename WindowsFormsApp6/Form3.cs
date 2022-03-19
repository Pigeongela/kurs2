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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0, a, b, sum, l, j = 0;
            string name, surname;
            name = textBox1.Text;
            surname = textBox2.Text;
            char[] name_arr = name.ToCharArray();
            char[] surname_arr = surname.ToCharArray();
            char[] sum_ch = new char[50];
            char[] tail = new char[25];
            a = name_arr.Length;
            b = surname_arr.Length;
            string prom = "";
            if (a > b)
            {
                l = b;
            }
            else l = a;
            while (i != l)
            {
                sum = name_arr[i] | surname_arr[i];
                sum_ch[i] = (char)sum;
                prom += name_arr[i] + "(" + Convert.ToString((int)name_arr[i], 16) + ")" +
                " + " + surname_arr[i] + "(" + Convert.ToString((int)surname_arr[i], 16) + ")" +
                " = " + sum_ch[i] + "(" + Convert.ToString((int)sum_ch[i], 16) + ")" + "\r\n";
                i++;
            }
            textBox5.Text = prom;
            string sum_st = new string(sum_ch);
            textBox3.Text = sum_st;
            if (l < a)
            {
                while (i != a)
                {
                    tail[j] = name_arr[i];
                    j++;
                    i++;
                }
            }
            else
            {
                while (i != b)
                {
                    tail[j] = surname_arr[i];
                    j++;
                    i++;
                }
            }
            string tail_st = new string(tail);
            textBox4.Text = tail_st;
        }
    }
}
