using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_testing_1.Pages
{
    public class CheckBoxesPage
    {
        private static IWebDriver _driver;

        private IWebElement _checkBox =>_driver.FindElement(By.Id("isAgeSelected"));
        private IWebElement _text => _driver.FindElement(By.Id("txtAge"));

        private IWebElement _firstCheckbox => _driver.FindElement(By.Id("isAgeSelected"));
        private IReadOnlyCollection<IWebElement> _multipleCheckBoxList => _driver.FindElements(By.CssSelector(".cb1-element"));

        private IWebElement _ResultButton => _driver.FindElement(By.Id("check1"));

        public CheckBoxesPage (IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public void CheckBoxButtonClick()
        {
            if (!_checkBox.Selected)
                _checkBox.Click();
        }

        public void CheckResult()
        {
            Assert.IsTrue(_text.Text.Equals("Success - Check box is checked"));
        }

        public void UncheckCheckedCheckBox()
        {
            if (_firstCheckbox.Selected)
                _firstCheckbox.Click();
        }

        public void CheckMultipleCheckboxes()
        {
            foreach (IWebElement element in _multipleCheckBoxList)
            {
                element.Click();
            }
        }

        public void ResultButtonCheck()
        {
            Assert.IsTrue(_ResultButton.GetAttribute("value").Equals("Uncheck All"), "Button doesn't change name");
        }

        public void UncheckAllButtonClick()
        {
            _ResultButton.Click();
        }

        public void CheckAllAreUnchecked()
        {

            Assert.IsTrue();
        }
    }
}
