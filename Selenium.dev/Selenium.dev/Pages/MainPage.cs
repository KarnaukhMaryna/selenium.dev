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

        public NavigationComponent Header => new(driver, "//nav[contains(@class, 'navbar')]");

    }
}
