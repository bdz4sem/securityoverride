using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming8
{
    public partial class prog8 : Form
    {
        public prog8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text.Replace("Radius of A = ", "");
            temp = temp.Replace("Length of AB = ", "");
            temp = temp.Replace("Length of CD = ", "");
            char[] sep = {'\n'};
            string[] inputs = temp.Split(sep);
            double AC = double.Parse(inputs[0]);
            double AB = double.Parse(inputs[1]);
            double CD = double.Parse(inputs[2]);
            double BC = Math.Pow(AB * AB + AC * AC - 2 * AB * AC * Math.Pow(1 - CD * CD / (4 * AC * AC), 0.5), 0.5);
            richTextBox2.Text = (Math.Round(BC * 1000) / 1000).ToString().Replace(",",".");
        }
    }
}
