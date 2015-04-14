using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace programming3
{
    public partial class prog3 : Form
    {
        LinkedListNode<string>[] LastNodes;
        LinkedList<string>[] Ll;
        string[] final = new string[3];
        public prog3()
        {
            InitializeComponent();

        }

        public static bool isTheWord(string input, string stringFromList)
        {
            if (input.Length != stringFromList.Length) return false;
            for (int i = 0; i < input.Length; i++ )
            {
                if (!stringFromList.Contains(input[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            char[] sep = {','};
            string[] inputs = richTextBox2.Text.Split(sep);
            for (int i = 0; i < 2; i++)
            {
                inputs[i+1] = inputs[i+1].Replace(" ", "");
            }
            LinkedListNode<string> temp=null;
            
            for (int t=0; t<3; t++)
            {
                int sum = 0;
                char[] charLine = inputs[t].ToCharArray();
                for (int i = 0; i < inputs[t].Length; i++)
                {
                    sum += (int)charLine[i];
                }
                sum %= 256;
                temp = Ll[sum].First;
                while (!isTheWord(inputs[t], temp.Value)) temp = temp.Next;
                if (t != 2) richTextBox1.Text += temp.Value + ", ";
                else richTextBox1.Text += temp.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LastNodes = new LinkedListNode<string>[256];
            Ll = new LinkedList<string>[256];
            FileStream fs = new FileStream("words.txt", FileMode.Open);
            StreamReader WordsReader = new StreamReader(fs);
            while (!WordsReader.EndOfStream)
            {
                int sum = 0;
                string line = WordsReader.ReadLine().ToLower();
                char[] charLine = line.ToCharArray();
                for (int i=0; i<charLine.Length; i++)
                {
                    sum += (int)charLine[i];
                }
                sum %= 256;
                if (Ll[sum] == null)
                {
                    Ll[sum]=new LinkedList<string>();
                    Ll[sum].AddFirst(line);
                }
                else Ll[sum].AddAfter(Ll[sum].Last, line);
            }
            textBox1.Text = "Done.";
            fs.Close();
        }
    }
}
