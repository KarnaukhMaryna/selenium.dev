using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.dev.Pages
{
    public class MainPage : BasePage
    {
        public MainPage(WebDriver driver) : base(driver) => this.driver = driver;

        private const string _documentationButton = "//a[@href = '/documentation']";

        public void ClickOnDocumentationButton()
        {
            driver.FindElement(By.XPath(_documentationButton)).Click();
        }
    }
}
