using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            if (checkBox1.Checked) // textBox1.Text ===> 소문자로...
                str = textBox1.Text.ToLower();
            else // textBox1.Text ===> 대문자로...
                str = textBox1.Text.ToUpper();
            //          textBox2.Text = str.IndexOf(  ;
            checkBox1.Checked = !checkBox1.Checked;
        }

        private void func1(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
