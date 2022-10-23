using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a_one = textBox1.Text;
            string b_two = textBox2.Text;
            int a = Convert.ToInt32(a_one);
            int b = Convert.ToInt32(b_two);
            double y;
            if(a>=b ||a> 0|| b>0)
            {
                y = Math.Pow(a, 2) + Math.Pow(b, 2);
                textBox3.Text = y.ToString();
           }
            if (a <= b || a < 0 || b < 0)
            {
                y = Math.Pow(a, 2) - Math.Pow(b, 2);
                    textBox3.Text = y.ToString();
                
             }else
                y = Math.Pow(a, 2) * Math.Pow(b, 2);
            textBox3.Text = y.ToString();

        }
    }
}
