using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input = int.Parse(richTextBox1.Text);
            richTextBox2.Clear();
            //richTextBox2.AppendText(input + " -> ");
            int sum = 0;
            for (int i=2; i<=input; i++)
            {
                if (input%i==0)
                {
                    input /= i;
                    sum += i;
                    //if (input == 1) richTextBox2.AppendText(i + " -> ");
                    //else richTextBox2.AppendText(i + ", ");
                    i--;
                }
            }
            richTextBox2.AppendText(sum.ToString());
            input = 0;
            sum = 0;
            textBox1.Clear();
            if (richTextBox2.Text == richTextBox3.Text) textBox1.Text = "Верно";
        }
    }
}
