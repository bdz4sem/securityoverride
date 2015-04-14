using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace securityoverride
{
    public partial class prog1 : Form
    {
        public prog1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] text1 = richTextBox1.Text.ToCharArray();
            int t=text1.Length;
            for (int i=1; i<(t/2+1); i++)
            {
                char temp = text1[i];
                text1[i] = text1[t - i];
                text1[t - i] = temp;
            }
            string s = new string(text1);
            richTextBox2.Text = s;
        }
    }
}
