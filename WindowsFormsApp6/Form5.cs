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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b;
            a = textBox1.Text;
            b = textBox2.Text;
            var aa = int.Parse(a);
            var bb = int.Parse(b);
            var sum = 0;
            var nok = 0;
            for (int i = aa; i <= bb; i++)
            {
                sum += i % 13 == 0 && i % 5 == 0 ? i : 0;
            }
            string sum_st = sum.ToString();
            textBox3.Text = sum_st;
            for (int k = 1; k < (aa*bb+1);  k++)
            {
                if (aa % k == 0 && bb % k == 0)
                {
                    nok = k;
                }
            }
            string nok_st = nok.ToString();
            textBox4.Text = nok_st;
        }
    }
}