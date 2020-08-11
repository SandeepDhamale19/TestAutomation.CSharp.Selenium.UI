using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomation.Framework.Helpers.UI_Helpers;
using TestAutomation.UITests.Pages.Pages_UI;

namespace TestAutomation.UITests.StepDefinitions.StepDefinitions_UI
{
    [Binding]
    public class LoginSteps: UIFramework
    {
        readonly LoginPage loginPage;
        readonly BookStoreNavigationPage bookStoreNavigationPage;
        public LoginSteps(IWebDriver driver)
        {
            UIController.Instance.Driver = driver;
            loginPage = Page<LoginPage>();
            bookStoreNavigationPage = Page<BookStoreNavigationPage>();
        }

        [Given(@"I Navigate to login page")]
        public void GivenINavigateToLoginPage()
        {
            bookStoreNavigationPage.LoginLabelByXPath.Click();
        }

        [Then(@"I should be able to view desired fields for login page")]
        public void ThenIShouldBeAbleToViewDesiredFieldsForLoginPage()
        {
            loginPage.UsernameLabelByXPath.VerifyElementIsVisible();
            loginPage.UsernameLabelByXPath.VerifyElementText("UserName :");

            loginPage.UsernameTextByXPath.VerifyElementIsVisible();
            loginPage.UsernameTextByXPath.VerifyAttributeValue("placeholder", "UserName");

            loginPage.PasswordLabelByXPath.VerifyElementIsVisible();
            loginPage.PasswordLabelByXPath.VerifyElementText("Password :");

            loginPage.PasswordTextByXPath.VerifyElementIsVisible();
            loginPage.PasswordTextByXPath.VerifyAttributeValue("placeholder", "Password");

            loginPage.LoginButtonByXPath.VerifyElementIsVisible();
            loginPage.NewuserButtonByXPath.VerifyElementIsVisible();
        }

    }
}
