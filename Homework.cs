using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation_testing_1
{
    class Homework
    {
        private static IWebDriver _driver;

        // Puslapyje https://www.seleniumeasy.com/test/basic-first-form-demo.html parašyti testus "Two Input Fields" formai.
        // Patikrinti, ar teisingai suskaičiuotos sumos, jei įvesti tokie duomenys:
        // 2+2


        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement popUp = _driver.FindElement(By.Id("at-cv-lightbox-close"));
            wait.Until(d => popUp.Displayed);
            popUp.Click();
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "NaN", TestName = "a + b = NaN")]
        public static void TestSum(string firstName, string secondName, string result)
        {

            IWebElement firstNumber = _driver.FindElement(By.Id("sum1"));
            firstNumber.SendKeys(firstName);          
            IWebElement secondNumber = _driver.FindElement(By.Id("sum2"));
            secondNumber.SendKeys(secondName);
            IWebElement getTotalButton = _driver.FindElement(By.CssSelector("#gettotal > button"));
            getTotalButton.Click();
            firstNumber.Clear();
            secondNumber.Clear();
            IWebElement actualResult = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(result, actualResult.Text, "Total a + b = 4");

        }
        /*
        [Test]
        public static void Test2Plus2()
        {
           
            IWebElement firstNumber = _driver.FindElement(By.Id("sum1"));
            firstNumber.SendKeys("2");
            IWebElement secondNumber = _driver.FindElement(By.Id("sum2"));
            secondNumber.SendKeys("2");
            IWebElement getTotalButton = _driver.FindElement(By.CssSelector("#gettotal > button"));
            getTotalButton.Click();
            IWebElement result = _driver.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("4", result.Text, "Total a + b = 4");
            

        }
        // -5+3
        [Test]
        public static void TestMinus5Plus3()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement firstNumber = chrome.FindElement(By.Id("sum1"));
            firstNumber.SendKeys("-5");
            IWebElement secondNumber = chrome.FindElement(By.Id("sum2"));
            secondNumber.SendKeys("3");
            IWebElement getTotalButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            getTotalButton.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("-2", result.Text, "Total a + b = -2");
            chrome.Quit();
        }
        // a + b
        [Test]
        public static void TestaPlusb()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement firstNumber = chrome.FindElement(By.Id("sum1"));
            firstNumber.SendKeys("a");
            IWebElement secondNumber = chrome.FindElement(By.Id("sum2"));
            secondNumber.SendKeys("b");
            IWebElement getTotalButton = chrome.FindElement(By.CssSelector("#gettotal > button"));
            getTotalButton.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual("NaN", result.Text, "Total a + b = NaN");
            chrome.Quit();
        }
        [Test]
        public static void TestTwoPlusTwo()
        {
            int i = 2 + 2;
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.seleniumeasy.com/test/basic-first-form-demo.html";
            IWebElement inputField1 = chrome.FindElement(By.Id("sum1"));
            inputField1.SendKeys("2");
            IWebElement inputField2 = chrome.FindElement(By.Id("sum2"));
            inputField2.SendKeys("2");
            IWebElement button = chrome.FindElement(By.CssSelector("#gettotal > button"));
            button.Click();
            IWebElement result = chrome.FindElement(By.Id("displayvalue"));
            Assert.AreEqual(i, int.Parse(result.Text), "Nelygu 2");
            chrome.Quit();
        }
        */
    }
}
