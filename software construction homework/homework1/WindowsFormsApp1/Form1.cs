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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox2.Text;
            string num2 = textBox3.Text;    
            int num3 = int.Parse(num1);
            int num4 = int.Parse(num2);
            string op = listBox1.SelectedItem.ToString();
            int ans = 0;
            switch (op) {
                case ("+"): ans = num3 + num4; break;
                case ("-"): ans = num3 - num4; break;
                case ("*"): ans = num3 * num4; break;
                case ("/"): ans = num3 / num4; break;
            }
            string str = ans.ToString();
            answerBox.Text = str;
        }
    }
}
