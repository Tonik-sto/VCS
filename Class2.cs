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
    class Class2
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";
            chrome.Quit();
        }
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver firefox = new FirefoxDriver();
            firefox.Url = "https://login.yahoo.com/";
            firefox.Quit();
        }

        [Test]
        public static void TestYahooPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://login.yahoo.com/";
            IWebElement loginImputField = chrome.FindElement(By.Id("login-username"));
            loginImputField.SendKeys("Labas");
            //chrome.Quit();
        }

        [Test]
        public static void TestSeleniumPage()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "http://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement imputField = chrome.FindElement(By.Id("user-message"));
            string myText = "Labas";
            imputField.SendKeys(myText);
            IWebElement button = chrome.FindElement(By.CssSelector("#get-input > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("display"));
            Assert.AreEqual(myText, result.Text, "Tekstas neatsirado");
            //chrome.Quit();
        }

    }
}
