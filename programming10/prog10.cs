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
using System.Net;

namespace programming10
{
    public partial class prog10 : Form
    {
        string sCookies;
        public prog10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] sep = { ';' };
            string[] passwords = textBox1.Text.Replace(" ", "").Split(sep);
            for (int i = 1; i <= 100; i++)
            {
                Uri uri = new Uri("http://securityoverride.org/challenges/programming/10/moo/"+i+"/");
                HttpWebRequest wrq = (HttpWebRequest)HttpWebRequest.Create(uri);
                wrq.Method = "GET";
                wrq.Referer = "http://securityoverride.org/challenges/index.php";
                wrq.UserAgent = "Mozilla/5.0 (X11; Linux i686; rv:24.0) Gecko/20140723 Firefox/24.0 Iceweasel/24.7.0";
                wrq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                wrq.Headers.Add("Accept-Language", "en-US,en;q=0.5");
                sCookies = textBox3.Text;
                if (!String.IsNullOrEmpty(sCookies)) wrq.Headers.Add(HttpRequestHeader.Cookie, sCookies);

                HttpWebResponse wrs = (HttpWebResponse)wrq.GetResponse();
                StreamReader reader = new StreamReader(wrs.GetResponseStream());
                string streamText = reader.ReadToEnd();
                richTextBox1.AppendText(uri.ToString() + " password: " + streamText+"\n");
                for (int t=0; t<3; t++)
                {
                    if (streamText == passwords[0])
                    {
                        if (t<2) textBox2.AppendText(i + ":" + passwords[t]+"; ");
                        else textBox2.AppendText(i + ":" + passwords[t]);
                    }
                }
                reader.Close();
            }
            textBox2.AppendText("Закончено.");
        }

        private void button2_Click(object sender, EventArgs e)//get cookies
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://securityoverride.org");
            //myHttpWebRequest.Proxy = new WebProxy("127.0.0.1", 8888);
            myHttpWebRequest.UserAgent = "Mozila/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; MyIE2;";myHttpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash,application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
            myHttpWebRequest.Headers.Add("Accept-Language", "ru");
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            sCookies = (String.IsNullOrEmpty(myHttpWebResponse.Headers["Set-Cookie"])) ? "" : myHttpWebResponse.Headers["Set-Cookie"];
            richTextBox1.AppendText("Cookies : " + sCookies);
       }

        private void button3_Click(object sender, EventArgs e)//login
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create("http://securityoverride.org/login.php");
            //myHttpWebRequest.Proxy = new WebProxy("127.0.0.1", 8888);
            myHttpWebRequest.Method = "POST";
            myHttpWebRequest.Referer = "http://securityoverride.org/login.php";
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (X11; Linux i686; rv:24.0) Gecko/20140723 Firefox/24.0 Iceweasel/24.7.0";
            myHttpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            myHttpWebRequest.Headers.Add("Accept-Language", "ru");
            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";

            // передаем cookie, полученные в предыдущем запросе
            if (!String.IsNullOrEmpty(sCookies)) myHttpWebRequest.Headers.Add(HttpRequestHeader.Cookie, sCookies);

            // ставим False, чтобы при получении кода 302 не делать 
            // автоматического перенаправления
            myHttpWebRequest.AllowAutoRedirect = false;

            // передаем параметры
            string sQueryString = "user_name=dslom&user_pass=qazqaz&login=Login";
            byte[] ByteArr = System.Text.Encoding.GetEncoding(1251).GetBytes(sQueryString);
            myHttpWebRequest.ContentLength = ByteArr.Length;
            myHttpWebRequest.GetRequestStream().Write(ByteArr, 0, ByteArr.Length);

            // делаем запрос
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader _reader = new StreamReader(myHttpWebResponse.GetResponseStream());
            string _streamText = _reader.ReadToEnd();
            
            char[] sep = { ';' };
            string[] passwords = textBox1.Text.Replace(" ", "").Split(sep);
            for (int i = 1; i <= 100; i++)
            {
                Uri uri = new Uri("http://securityoverride.org/challenges/programming/10/moo/" + i + "/");
                HttpWebRequest wrq = (HttpWebRequest)HttpWebRequest.Create(uri);
                wrq.Method = "GET";
                wrq.Referer = "http://securityoverride.org/challenges/index.php";
                wrq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                wrq.UserAgent = "Mozilla/5.0 (X11; Linux i686; rv:24.0) Gecko/20140723 Firefox/24.0 Iceweasel/24.7.0";
                wrq.Headers.Add("Accept-Language", "en-US,en;q=0.5");
                wrq.ContentType = "application/x-www-form-urlencoded";
                if (!String.IsNullOrEmpty(sCookies)) wrq.Headers.Add(HttpRequestHeader.Cookie, sCookies);
                
                HttpWebResponse wrs = (HttpWebResponse)wrq.GetResponse();
                StreamReader reader = new StreamReader(wrs.GetResponseStream());
                string streamText = reader.ReadToEnd();
                richTextBox1.AppendText(uri.ToString() + " password: " + streamText + "\n");
                for (int t = 0; t < 3; t++)
                {
                    if (streamText == passwords[0]) textBox2.AppendText(i + ":" + passwords[t]);
                }
                reader.Close();
            }
            textBox2.AppendText("Закончено.");
        } 


    }
}
