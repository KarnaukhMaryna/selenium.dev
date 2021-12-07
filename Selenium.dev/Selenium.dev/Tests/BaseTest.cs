using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.dev.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.dev.Tests
{
    public class BaseTest
    {
        private WebDriver driver;
        private static string _seleniumDev = "https://www.selenium.dev/";

        [SetUp]
        public void TestsSetUp()
        {
            driver = new ChromeDriver("D:\\Project\\Automation\\selenium.dev\\Selenium.dev\\Selenium.dev\\Resources\\Driver");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(_seleniumDev);
        }

        [TearDown]
        public void TearDown() => driver.Close();

        public WebDriver GetDriver() => driver;

        public MainPage GetMainPage() => new (driver);

        public DocumentationPage GetDocumentationPage() => new (driver);
    }
}
