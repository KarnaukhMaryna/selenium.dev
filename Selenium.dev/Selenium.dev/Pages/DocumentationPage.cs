using OpenQA.Selenium;
using Selenium.dev.Pages.ComponentsOfThePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.dev.Pages
{
    public class DocumentationPage : BasePage
    {
        public DocumentationPage(WebDriver driver) : base(driver) => this.driver = driver;

        public PageComponent Body => new(driver, "//div[@class='td-content']");
    }
}
