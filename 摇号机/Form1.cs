using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 摇号机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var start = Convert.ToInt32(textBox1.Text);
            var end = Convert.ToInt32(textBox2.Text) + 1;
            var random = new Random();
            var value = random.Next(start, end);
            label3.Text = value.ToString();
        }

        bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            flag = !flag ;
            timer1.Enabled = flag;
            if (flag) button1.Text = "结束";
            else button1.Text = "开始";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var start = Convert.ToInt32(textBox1.Text);
            var end = Convert.ToInt32(textBox2.Text) + 1;
            var random = new Random();
            var value = random.Next(start, end);
            label3.Text = value.ToString();
        }
    }
}
