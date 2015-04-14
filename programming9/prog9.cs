using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming9
{
    public partial class prog9 : Form
    {
        public prog9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = richTextBox1.Text;
            temp = temp.Replace(";", "");
            temp = temp.Replace(",", "");
            temp = temp.Replace("January","1");
            temp = temp.Replace("February","2");
            temp = temp.Replace("March","3");
            temp = temp.Replace("April","4");
            temp = temp.Replace("May","5");
            temp = temp.Replace("June","6");
            temp = temp.Replace("July","7");
            temp = temp.Replace("August","8");
            temp = temp.Replace("September","9");
            temp = temp.Replace("October","10");
            temp = temp.Replace("November","11");
            temp = temp.Replace("December","12");

            char[] sep = { ' ' };
            string[] inputs = temp.Split(sep);
            DateTime dt1 = new DateTime(int.Parse(inputs[2]), int.Parse(inputs[0]), int.Parse(inputs[1]));
            DateTime dt2 = new DateTime(int.Parse(inputs[5]), int.Parse(inputs[3]), int.Parse(inputs[4]));
            DateTime dt3 = new DateTime(int.Parse(inputs[8]), int.Parse(inputs[6]), int.Parse(inputs[7]));
            richTextBox2.AppendText(dt1.DayOfWeek.ToString() + "; " + dt2.DayOfWeek.ToString() + "; " + dt3.DayOfWeek.ToString());
        }
    }
}
