using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordpressAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            throw new NotImplementedException();
        }

        public static object Login(string v)
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.sogeti.com/");
    }
}
