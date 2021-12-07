﻿using OpenQA.Selenium;
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

        private static string _programmingLanguage = "//li[@class='nav-item']";

        private static string _areaWithCode = "//div[@class='tab-content']"; 

        public List<IWebElement> GetLanguages() => driver.FindElements(By.XPath(_programmingLanguage)).ToList();

        public bool AreaWithCodeIsDisplayed() => driver.FindElement(By.XPath(_areaWithCode)).Displayed;
        
        
    }
}
