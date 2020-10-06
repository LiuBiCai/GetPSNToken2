using AppNerve.Expands.StringExpand;
using AppNerve.Http;
using CaptchaAndProxy;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPSNToken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetPsnToken_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string pass = textBoxPSNPass.Text;
            string emailPass = textBoxPSNPass.Text;           
            string token = "";
            Tuple<bool, string> ip = ProxyHelper.GetProxy();
            if (!ip.Item1)
            {
                return;
            }
            SeleniumHelper seleniumHelper = new SeleniumHelper();
            Tuple<bool, string> tuple = seleniumHelper.GetPSNToken(email, pass, token, "bicai", "13026877621", ip.Item2, emailPass);
            if (tuple.Item1)
            {
                textBoxPSNToken.Text = GenerateToken(tuple.Item2);
            }
        }
        public static string GenerateToken(string authCode)
        {
            HttpClient _client = new HttpClient() { UseGzip = true, TimeOut = 300000 };

            var auth = _client.AjaxPostData("https://auth.api.sonyentertainmentnetwork.com/2.0/oauth/token",
                "grant_type=authorization_code&code=" + authCode +
                "&redirect_uri=https://remoteplay.dl.playstation.net/remoteplay/redirect&",
                new Request()
                {
                    ContentType = "application/x-www-form-urlencoded",
                    Authorization =
                        "Basic YmE0OTVhMjQtODE4Yy00NzJiLWIxMmQtZmYyMzFjMWI1NzQ1Om12YWlaa1JzQXNJMUlCa1k="

                });
            if (auth.IsError)
            {
                return "auth error: " + auth.ErrorInfo;
                //textBoxLog.AppendText("auth error: " + auth.ErrorInfo);
            }

            string refrshToken = auth.Html.Match("refresh_token\":\"(?<value>.*?)\",\"expires_in");
            Console.WriteLine(refrshToken);
            return refrshToken;
        }
    }
}
