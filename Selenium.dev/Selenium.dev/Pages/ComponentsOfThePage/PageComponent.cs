using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.dev.Pages.ComponentsOfThePage
{
    public class PageComponent: BasePage
    {
        public PageComponent PageComponen { get; set; }

        public PageComponent(WebDriver driver, string locator) : base(driver) => driver.FindElement(By.XPath(locator));

        public List<IWebElement> ProgrammingLanguages => driver.FindElements(By.XPath("//li[@class='nav-item']")).ToList();

        public IWebElement AreaWithCode => driver.FindElement(By.XPath("//div[@class='tab-content']"));

        public bool AreaWithCodeIsDisplayed() => AreaWithCode.Displayed;

    }
}
