using Automation_testing_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_testing_1.Tests
{
    public class CheckBoxesTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://www.seleniumeasy.com/test/basic-checkbox-demo.html";
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();


        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            //_driver.Quit();
        }

        [Test]
        // 1) Pažymime “Click on this check box” , patikriname kad atsirado “Success - Check box is checked” pranešimas.
        public void TestOneCheckBox()
        {
            CheckBoxesPage page = new CheckBoxesPage(_driver);

            page.CheckBoxButtonClick();
            page.CheckResult();
        }
        
        [Test]
        // 2) Pažymime visas “Multiple Checkbox Demo” sekcijos varneles, patikriname kad mygtukas persivadino į “Uncheck All”.
        public void TestMultipleCheckBoxes()
        {
            CheckBoxesPage page = new CheckBoxesPage(_driver);
            page.UncheckCheckedCheckBox();
            page.CheckMultipleCheckboxes();
            page.ResultButtonCheck();
        }
        [Test]
        // 3) Paspaudžiame mygtuką “Uncheck All” , patikriname kad visos “Multiple Checkbox Demo” sekcijos varneles atžymėtos.
        public void TestMultipleUnCheckBoxes()
        {
            CheckBoxesPage page = new CheckBoxesPage(_driver);

            page.UncheckAllButtonClick();

        }
    }
}
