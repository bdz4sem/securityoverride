using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming2
{
    public partial class prog2 : Form
    {
        public prog2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] text1 = richTextBox1.Text.ToCharArray();
            int sum = 0;
            for (int i=0; i<text1.Length; i++)
            {
                sum += (int)text1[i];
            }
            richTextBox2.Text = sum.ToString();
        }
    }
}
