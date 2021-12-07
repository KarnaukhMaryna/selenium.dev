using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.dev.Pages
{
    public class BasePage
    {
        public WebDriver driver;

        public BasePage(WebDriver driver) => this.driver = driver;
        

    }
}
