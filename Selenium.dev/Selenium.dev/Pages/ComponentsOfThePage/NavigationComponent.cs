using OpenQA.Selenium;

namespace Selenium.dev.Pages
{
    public class NavigationComponent : BasePage
    {
        public NavigationComponent NavigatComponent { get; set; }

        public NavigationComponent(WebDriver driver, string locator):base(driver) => driver.FindElement(By.XPath(locator));

        public IWebElement DocumentationButton => driver.FindElement(By.XPath("//a[@href = '/documentation']"));

        public void DocumentationButtonClick() => DocumentationButton.Click();
    }
}