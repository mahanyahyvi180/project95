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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int sum;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            sum += x;
            lable3.Text = sum.ToString();
            lable3.Text = "";
            lable3.Focus();
        }
    }
}
