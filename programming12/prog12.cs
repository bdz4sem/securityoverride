using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming12
{
    public partial class prog12 : Form
    {
        public prog12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            int u = 0;
            int b = 0;
            int _e = 0;
            int d = 0;
            int count = 0;
            for (c=0;c<10;c++)
            {
                for(u=0;u<10;u++)
                {
                    for(b=0;b<10;b++)
                    {
                        for(_e=0;_e<10;_e++)
                        {
                            for(d=0;d<10;d++)
                            {
                                int temp = c*10000+u*1000+b*100+_e*10+d;
                                if (Math.Pow(c + u + b + _e + d, 3) == temp)
                                    richTextBox1.AppendText(temp.ToString()+" ");
                                count++;
                            }
                        }
                    }
                }
            }
            richTextBox1.AppendText("\nCounts: "+count.ToString());
        }
    }
}
