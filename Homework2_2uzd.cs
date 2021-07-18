using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_testing_1
{
    class Homework2_2uzd
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.active.com/fitness/calculators/pace";

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.CssSelector("#page-wrapper > aside > div > header > span")).Click();
            _driver.FindElement(By.CssSelector("body > div.optanon-alert-box-wrapper > div.optanon-alert-box-bg > div.optanon-alert-box-button-container > div.optanon-alert-box-button.optanon-button-allow > div > button")).Click();

        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]
        public static void TestVartuAutomatikaPage()
        {
            IWebElement timeH = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(1) > input[type=number]"));
            timeH.Clear();
            timeH.SendKeys("1");
            IWebElement timeM = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(2) > input[type=number]"));
            timeM.Clear();
            timeM.SendKeys("5");
            IWebElement timeS = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(2) > div > label:nth-child(3) > input[type=number]"));
            timeS.Clear();
            timeS.SendKeys("0");
            IWebElement distance = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > label > input[type=number]"));
            distance.Clear();
            distance.SendKeys("13");
   
            _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(3) > div > span > span > span.selectboxit-arrow-container")).Click();
            _driver.FindElement(By.XPath("//*[@id='calculator - pace']/form/div[3]/div/span/span/span[2]")).Click();

            IWebElement openDropDown = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > span > span > span.selectboxit-arrow-container"));
            openDropDown.Click();
            IWebElement choosePerKm = _driver.FindElement(By.XPath("//*[@id='calculator - pace']/form/div[4]/div/span/span/span[2]"));
            choosePerKm.Click();

            IWebElement hours = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > label:nth-child(1) > input[type=number]"));
            IWebElement minutes = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > label:nth-child(2) > input[type=number]"));
            IWebElement seconds = _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(4) > div > label:nth-child(3) > input[type=number]"));
            _driver.FindElement(By.CssSelector("#calculator-pace > form > div:nth-child(6) > div > a")).Click();
            Assert.IsTrue(hours.GetAttribute("value").Equals("00"), "Hours are wrong");
            Assert.IsTrue(minutes.GetAttribute("value").Equals("05"), "Minutes are wrong");
            Assert.IsTrue(seconds.GetAttribute("value").Equals("00"), "Seconds are wrong");
        }
    }
}
