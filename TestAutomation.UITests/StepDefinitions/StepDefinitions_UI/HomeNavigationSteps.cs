using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomation.Framework.Helpers.UI_Helpers;
using TestAutomation.Selenium.Tests.Pages.Pages_UI;

namespace TestAutomation.Selenium.Tests.StepDefinitions.StepDefinitions_UI
{
    [Binding]
    public class HomeNavigationSteps : UIFramework
    {
        readonly HomePage homePage;
        public HomeNavigationSteps(IWebDriver driver)
        {
            UIController.Instance.Driver = driver;
            homePage = Page<HomePage>();
        }

        [Given(@"I access Demo QA application")]
        public void GivenIAccessDemoQAApplication()
        {
            UIActions.NavigateToUrl();
        }
                
        [Given(@"I navigate to store Application")]
        public void GivenINavigateToStoreApplication()
        {
            homePage.BookstoreapplicationLabelByXPath.Click();
        }


        [Then(@"I am navigated to Book store '(.*)'")]
        public void ThenIAmNavigatedToBookStore(string url="")
        {
            if (string.IsNullOrEmpty(url))
                url = "https://demoqa.com/books";

            UIActions.VerifyURL(url);
        }

        // This is combined step and can be used as background in other scenarios
        [Given(@"I access Book store Application")]
        [When(@"I access Book store Application")]
        public void GivenIAccessBookStoreApplication()
        {
            GivenIAccessDemoQAApplication();
            GivenINavigateToStoreApplication();
            ThenIAmNavigatedToBookStore();
        }


    }
}
