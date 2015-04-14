using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming6
{
    public partial class prog6 : Form
    {
        public prog6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text.Replace("x^2 + ", "");
            temp = temp.Replace("x +", "");
            char[] sep = { ' ' };
            string[] ks = temp.Split(sep);
            int[] intks = new int[2];
            for (int i=0; i<2; i++)
            {
                intks[i] = int.Parse(ks[i]);
            }
            int root1 = 0;
            for (int i=0; i>intks[0]*(-1); i--)
            {
                if (Math.Pow(i, 2) + intks[0] * i + intks[1] == 0)
                {
                    root1 = i;
                    break;
                }
            }
            richTextBox2.Clear();
            richTextBox2.AppendText("(x+" + (root1 * (-1)) + ")(x+" + (intks[1] * (-1) / root1) + ")");
        }
    }
}
