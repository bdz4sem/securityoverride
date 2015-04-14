using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming5
{
    public partial class prog5 : Form
    {
        public prog5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            for (int i = 0; i < 250; i++)
            {
                if (richTextBox1.Text.Replace("\n","")[i] == '@') richTextBox2.AppendText((i / 50 + 1) + "-" + i % 50 + ", ");
            }
            richTextBox2.AppendText("EOF");
            richTextBox2.Text = richTextBox2.Text.Replace(", EOF","");
        }
    }
}
