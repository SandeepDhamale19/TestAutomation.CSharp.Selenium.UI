using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestAutomation.Framework.Helpers.Assertions;
using TestAutomation.Framework.Helpers.Strings;
using TestAutomation.Framework.Helpers.UI_Helpers;
using TestAutomation.UITests.Pages.Pages_UI;

namespace TestAutomation.UITests.StepDefinitions.StepDefinitions_UI
{
    [Binding]
    public class RegistrationSteps : UIFramework
    {
        readonly RegistrationPage registrationPage;
        readonly BookStoreNavigationPage bookStoreNavigationPage;
        readonly LoginPage loginPage;

        public RegistrationSteps(IWebDriver driver)
        {
            UIController.Instance.Driver = driver;
            registrationPage = Page<RegistrationPage>();
            bookStoreNavigationPage = Page<BookStoreNavigationPage>();
            loginPage = Page<LoginPage>();
        }

        [Given(@"I Navigate to registration form")]
        public void GivenINavigateToRegistrationForm()
        {
            bookStoreNavigationPage.LoginLabelByXPath.Click();
            loginPage.NewuserButtonByXPath.Click();            
        }

        [Given(@"I provide required details (.*), (.*), (.*) and (.*)")]
        public void GivenIProvideRequiredDetailsFNameLNameMyPSsAndFName_LNameEmail_Com(string fName, string lName, string userName, string password)
        {
            registrationPage.FirstNameTextByXPath.SetText(fName);
            registrationPage.LastNameTextByXPath.SetText(lName);
            registrationPage.UsernameTextByXPath.SetText(userName);
            registrationPage.PasswordTextByXPath.SetText(password);
            UIActions.PressKey(Keys.Tab);
            registrationPage.CaptchaButton.ClickHiddenElements();
        }

        [Given(@"I register myself to book store")]
        public void GivenIRegisterMyselfToBookStore()
        {
            registrationPage.RegisterButton.Click();
        }

        [Then(@"I should be registers successfully to book store")]
        public void ThenIShouldBeRegistersSuccessfullyToBookStore()
        {
            string alertText = UIActions.GetAlertText();
            AssertHelpers.AssertTrue(alertText.Contains("User Resgister Successfully."));

        }

        [Then(@"I should be able to view desired fields")]
        public void ThenIShouldBeAbleToViewDesiredFields()
        {
            registrationPage.FirstnameLabelByXPath.VerifyElementIsVisible();
            registrationPage.FirstnameLabelByXPath.VerifyElementText("First Name :");

            registrationPage.FirstNameTextByXPath.VerifyElementIsVisible();
            registrationPage.FirstNameTextByXPath.VerifyAttributeValue("placeholder", "First Name");

            registrationPage.LastnameLabelByXPath.VerifyElementIsVisible();
            registrationPage.LastnameLabelByXPath.VerifyElementText("Last Name :");

            registrationPage.LastNameTextByXPath.VerifyElementIsVisible();
            registrationPage.LastNameTextByXPath.VerifyAttributeValue("placeholder", "Last Name");

            registrationPage.UsernameLabelByXPath.VerifyElementIsVisible();
            registrationPage.UsernameLabelByXPath.VerifyElementText("UserName :");

            registrationPage.UsernameTextByXPath.VerifyElementIsVisible();
            registrationPage.UsernameTextByXPath.VerifyAttributeValue("placeholder", "UserName");

            registrationPage.PasswordLabelByXPath.VerifyElementIsVisible();
            registrationPage.PasswordLabelByXPath.VerifyElementText("Password :");

            registrationPage.PasswordTextByXPath.VerifyElementIsVisible();
            registrationPage.PasswordTextByXPath.VerifyAttributeValue("placeholder", "Password");

            registrationPage.RegisterButton.VerifyElementIsVisible();
            registrationPage.BackToLoginButton.VerifyElementIsVisible();
        }


    }
}
