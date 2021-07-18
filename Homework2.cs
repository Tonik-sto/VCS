using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_testing_1
{
    class Homework2
    {



        // Užduotis 1:
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            IWebElement text = chrome.FindElement(By.Id("primary-detection"));
            Assert.AreEqual("Chrome 91 on Windows 10", text.Text, "Success");
            //chrome.Quit();
        }
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            IWebElement text = firefox.FindElement(By.Id("primary-detection"));
            Assert.AreEqual("Firefox 89 on Windows 10", text.Text, "Success");
            //firefox.Quit();
        }
    }
}
