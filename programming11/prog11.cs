using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace programming11
{
    public partial class prog11 : Form
    {
        public prog11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap captcha = new Bitmap("C:\\Users\\User\\Desktop\\php_captcha.php");
            int SymbCount = 96;
            Color temp;
            int offset = 10;
            int PixelPerSymbolHeight = 6;
            int PixelPerSymbolWidth = 4;
            string[] Matrix = new string[96];
            for (int numOfSymb=0; numOfSymb<SymbCount; numOfSymb++)
            {
                for (int i=0; i<PixelPerSymbolHeight; i++) //
                {
                    Matrix[numOfSymb] += " ";
                    for (int j = 0; j < PixelPerSymbolWidth; j++)
                    {
                        temp = captcha.GetPixel(offset+j, 10+i);
                        if ((temp.R > 127) && (temp.G > 127) && (temp.B > 127)) Matrix[numOfSymb] += "1";
                        else Matrix[numOfSymb] += "0";
                    }
                }
                offset += 5;
            }

            for ( int i=0; i<96; i++)
            {
                switch (Matrix[i])
                {
                    case " 0010 0110 0010 0010 0010 0111": textBox1.Text += "1"; break;
                    case " 0110 1001 0001 0010 0100 1111": textBox1.Text += "2"; break;
                    case " 0110 1001 0010 0001 1001 0110": textBox1.Text += "3"; break;
                    case " 0010 0110 1010 1111 0010 0010": textBox1.Text += "4"; break;
                    case " 1111 1000 1110 0001 1001 0110": textBox1.Text += "5"; break;
                    case " 0110 1000 1010 1101 1001 0110": textBox1.Text += "6"; break;
                    case " 1111 0001 0010 0010 0100 0100": textBox1.Text += "7"; break;
                    case " 0110 1001 0110 1001 1001 0110": textBox1.Text += "8"; break;
                    case " 0110 1001 1011 0101 0001 0110": textBox1.Text += "9"; break;
                    case " 0010 0101 0101 0101 0101 0010": textBox1.Text += "0"; break;

                    case " 0000 0000 0111 1001 1011 0101": textBox1.Text += "a"; break;
                    case " 1000 1000 1110 1001 1001 1110": textBox1.Text += "b"; break;
                    case " 0000 0000 0111 1000 1000 0111": textBox1.Text += "c"; break;
                    case " 0001 0001 0111 1001 1011 0101": textBox1.Text += "d"; break;
                    case " 0000 0000 0110 1011 1100 0111": textBox1.Text += "e"; break;
                    case " 0010 0101 0100 1110 0100 0100": textBox1.Text += "f"; break;
                    default: textBox1.Text += "_"; textBox2.Text += i + " "; break;
                }
            }

            textBox1.SelectAll();
            textBox1.Copy();
        }
    }
}
