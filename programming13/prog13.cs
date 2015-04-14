using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming13
{
    public partial class prog13 : Form
    {
        public prog13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap barcode = new Bitmap("C:\\Users\\User\\Desktop\\img.php");
            string[] bc = new string[11];
            Color temp;
            int offset = 3;
            int sum = 0;
            
            for (int t = 0; t < 11; t++)
            {
                for (int i = 0; i < 7; i++)
                {
                    temp = barcode.GetPixel(offset + i, 1);
                    if (temp.R == 0 && temp.G == 0 && temp.B == 0) bc[t] += "1";
                    else bc[t] += "0";
                }
                offset += 7;
                if (t == 5) offset += 5;
            }

            for (int i=0; i<11; i++)
            {
                switch(bc[i])
                {
                    case "0001101": textBox1.Text += "0"; break;
                    case "1110010": textBox1.Text += "0"; break;

                    case "1100110": textBox1.Text += "1"; if (i % 2 == 0) sum += 1 * 3; else sum += 1; break;
                    case "0011001": textBox1.Text += "1"; if (i % 2 == 0) sum += 1 * 3; else sum += 1; break;

                    case "1101100": textBox1.Text += "2"; if (i % 2 == 0) sum += 2 * 3; else sum += 2; break;
                    case "0010011": textBox1.Text += "2"; if (i % 2 == 0) sum += 2 * 3; else sum += 2; break;

                    case "1000010": textBox1.Text += "3"; if (i % 2 == 0) sum += 3 * 3; else sum += 3; break;
                    case "0111101": textBox1.Text += "3"; if (i % 2 == 0) sum += 3 * 3; else sum += 3; break;

                    case "1011100": textBox1.Text += "4"; if (i % 2 == 0) sum += 4 * 3; else sum += 4; break;
                    case "0100011": textBox1.Text += "4"; if (i % 2 == 0) sum += 4 * 3; else sum += 4; break;

                    case "1001110": textBox1.Text += "5"; if (i % 2 == 0) sum += 5 * 3; else sum += 5; break;
                    case "0110001": textBox1.Text += "5"; if (i % 2 == 0) sum += 5 * 3; else sum += 5; break;

                    case "1010000": textBox1.Text += "6"; if (i % 2 == 0) sum += 6 * 3; else sum += 6; break;
                    case "0101111": textBox1.Text += "6"; if (i % 2 == 0) sum += 6 * 3; else sum += 6; break;

                    case "1000100": textBox1.Text += "7"; if (i % 2 == 0) sum += 7 * 3; else sum += 7; break;
                    case "0111011": textBox1.Text += "7"; if (i % 2 == 0) sum += 7 * 3; else sum += 7; break;

                    case "1001000": textBox1.Text += "8"; if (i % 2 == 0) sum += 8 * 3; else sum += 8; break;
                    case "0110111": textBox1.Text += "8"; if (i % 2 == 0) sum += 8 * 3; else sum += 8; break;

                    case "1110100": textBox1.Text += "9"; if (i % 2 == 0) sum += 9 * 3; else sum += 9; break;
                    case "0001011": textBox1.Text += "9"; if (i % 2 == 0) sum += 9 * 3; else sum += 9; break;                    
                }
            }
            textBox2.Text = sum + ":" + ((sum / 10 + 1) * 10 - sum);
        }
    }
}
