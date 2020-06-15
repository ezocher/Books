using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5_WinForms
{
    public partial class AsyncIntro : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private const string DefaultUrl = "http://csharpindepth.com";

        public AsyncIntro()
        {
            InitializeComponent();
            textBoxUrl.Text = DefaultUrl;
            textBoxUrl.KeyDown += TextBox1_KeyDown;

            SetUserAgent();
        }

        private void SetUserAgent()
        {
            //Add a user-agent header to the GET request. 
            var headers = client.DefaultRequestHeaders;

            //The safe way to add a header value is to use the TryParseAdd method and verify the return value is true,
            //especially if the header value is coming from user input.
            string header = "Mozilla/5.0 (Linux; Android 4.0.4; Galaxy Nexus Build/IMM76B) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.133 Mobile Safari/535.19";
            if (!headers.UserAgent.TryParseAdd(header))
            {
                throw new Exception("Invalid header value: " + header);
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;          // Prevents beep when Enter pressed
                DisplayWebPage(sender, e);
                e.Handled = true;
            }
        }

        private async void DisplayWebPage(object sender, EventArgs e)
        {
            Stopwatch elapsedTime = new Stopwatch();
            string text;

            string url = textBoxUrl.Text;
            if (url == "") url = DefaultUrl;

            labelStatus.Text = "Fetching...";
            elapsedTime.Start();

            try
            {
                string source;

                if (checkBoxHEADRequest.Checked)
                {
                    text = (await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url))).ToString();
                    source = "HEAD of " + url;
                }
                else
                {
                    text = await client.GetStringAsync(url);
                    source = url;
                }

                long timeHttp = elapsedTime.ElapsedMilliseconds;
                richTextBoxPageContents.Text = text;
                labelStatus.Text = String.Format("Length of {0}: {1:N0} chars in http: {2:N0} / total: {3:N0} ms", source, text.Length, timeHttp, elapsedTime.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                string details;
                labelStatus.Text = "Exception";
                if (ex.InnerException == null)
                    details = "";
                else
                    details = ex.InnerException.Message;
                richTextBoxPageContents.Text = String.Format("{0}\n{1}\nElapsed time: {2:N0} ms", ex.Message, details, elapsedTime.ElapsedMilliseconds);
            }
        }
    }
}
