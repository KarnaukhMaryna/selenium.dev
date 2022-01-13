using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.dev.Pages;
using Selenium.dev.Tests;
using System.Collections.Generic;
using System.Linq;

namespace Selenium.dev
{
    [TestFixture]
    public class Test : BaseTest
    {
        readonly List<string> supportedLanguages = new() { "Java", "Python", "CSharp", "Ruby", "JavaScript", "Kotlin" };

        [Test]
        public void CheckThatSupportedLanguagesIsPresent()
        {
            GetMainPage().Header.DocumentationButtonClick();
            var languages = GetDocumentationPage().Body.ProgrammingLanguages.Select(language=>language.Text);
            CollectionAssert.IsNotEmpty(supportedLanguages.Intersect(languages));
        }

        [Test]
        public void CheckExampleForEachLanguage()
        {
            GetMainPage().Header.DocumentationButtonClick();
            var languages = GetDocumentationPage().Body.ProgrammingLanguages;
            foreach (var language in languages)
            {
                language.Click();
                Assert.IsTrue(GetDocumentationPage().Body.AreaWithCodeIsDisplayed());
            }
        }
    }
}