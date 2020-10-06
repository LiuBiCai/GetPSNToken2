using AppNerve.Expands.StringExpand;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Postkit;
using Postkit.DAO;
using Selenium_Chrome_HTTP_Private_Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace GetPSNToken
{
    class SeleniumHelper
    {
        IWebDriver driver;
        public Tuple<bool,string> GetPSNToken(string email, string pass, string token, string proxyUser, string proxyPass, string ip,string emailPass="")
        {

           try
            {
                Tuple<bool, string> result = ExtensionHelper.CreateExtension(proxyUser, proxyPass, ip);
                if (result.Item1)
                {
                    string match = "https://remoteplay.dl.playstation.net/remoteplay/redirect?code=";
                    var options = new ChromeOptions();
                    options.AddExtension(result.Item2);
                    //options.BinaryLocation=@"C:\Program Files\Google\Chrome\Application\chrome.exe";
                    driver = (IWebDriver)new ChromeDriver(options);
                    driver.Navigate().GoToUrl("https://auth.api.sonyentertainmentnetwork.com/2.0/oauth/authorize?ui=pr&client_id=ba495a24-818c-472b-b12d-ff231c1b5745&layout_type=popup&PlatformPrivacyWs1=exempt&redirect_uri=https://remoteplay.dl.playstation.net/remoteplay/redirect&request_locale=zh_CN&response_type=code&scope=psn:clientapp&service_entity=urn:service-entity:psn&service_logo=ps&smcid=remoteplay");
                    Thread.Sleep(30000);
                    string idToFind1 = "ember22";
                    string idToFind2 = "ember18";
                    string idToFind3 = "ember17";
                    string verifyCodeInput = "ember37";
                    if (IsElementPresentWhinTime(By.Id(idToFind2), 5))
                    {
                        Thread.Sleep(5000);

                        Actions actions1 = new Actions(driver);

                        actions1.SendKeys(driver.FindElement(By.Id(idToFind3)), email).Build().Perform();

                        Actions actions2 = new Actions(driver);

                        actions2.SendKeys(driver.FindElement(By.Id(idToFind2)), pass).Build().Perform();

                        driver.FindElement(By.Id(idToFind1)).Click();

                        Thread.Sleep(30000);
                        //((IJavaScriptExecutor)driver).ExecuteScript("widgetVerified(\"" + token + "\");");
                        //Thread.Sleep(20000);
                    }
                    if(IsElementPresentWhinTime(By.Id(verifyCodeInput),3))
                    {
                        PostClient client = new PostClient();
                        var login = client.Login(email, emailPass, LoginMode.POP3);
                        string loginResult = login.ToString();

                        if (loginResult == "LoginSuccess")
                        {
                            var mail = client.GetPopTopMail();
                            string code = mail.Subject.Match("(?<value>[0-9]{6})");
                            Actions actions3 = new Actions(driver);

                            actions3.SendKeys(driver.FindElement(By.Id(verifyCodeInput)), code).Build().Perform();
                            Thread.Sleep(30000);
                        }
                        
                    }
                    if (IsUrlPresentWhinTime(match,10))
                    {
                        string str = new Regex("=(?<value>.*?)&").Match(driver.Url).ToString().Substring(1, 6);
                        Console.WriteLine(str);
                        driver.Close();
                        driver.Dispose();
                        //MessageCommunicate.SendMessageToTargetWindow("Login", email + ":" + str);
                        return new Tuple<bool, string>(true, str);
                    }


                    if (IsElementPresentWhinTime(By.Id("ember29"), 5))
                    {
                        driver.Close();
                        driver.Dispose();
                        return new Tuple<bool, string>(false, "reset");
                        //MessageCommunicate.SendMessageToTargetWindow("Login", email + ":reset");

                    }


                    //(driver as ITakesScreenshot).GetScreenshot().SaveAsFile(email + ".png");
                    driver.Close();
                    driver.Dispose();
                    return new Tuple<bool, string>(false, "known");
                }
                else
                {
                    Console.WriteLine(result.Item2);
                    return new Tuple<bool, string>(false, result.Item2);
                }
            }
            catch(Exception ex)
            {
                if(driver!=null)
                {
                    driver.Close();
                    driver.Dispose();
                }
                return new Tuple<bool, string>(false, ex.ToString());
            }




        }
        private bool IsElementPresentWhinTime(By by, int timeLimit)
        {
            DateTime start = DateTime.Now;
            TimeSpan span = DateTime.Now - start;
            while (span.TotalSeconds < timeLimit)
            {
                try
                {

                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    span = DateTime.Now - start;
                    Thread.Sleep(100);
                    //return false;
                }

            }
            return false;
        }
        private bool IsUrlPresentWhinTime(string match, int timeLimit)
        {
            DateTime start = DateTime.Now;
            TimeSpan span = DateTime.Now - start;
            while (span.TotalSeconds < timeLimit)
            {
                try
                {

                    if (!driver.Url.Contains(match))
                    {
                        span = DateTime.Now - start;
                        Thread.Sleep(100);
                    }
                    else
                        return true;

                }
                catch (NoSuchElementException)
                {
                    span = DateTime.Now - start;
                    Thread.Sleep(100);
                    //return false;
                }

            }
            return false;
        }
    }
}
