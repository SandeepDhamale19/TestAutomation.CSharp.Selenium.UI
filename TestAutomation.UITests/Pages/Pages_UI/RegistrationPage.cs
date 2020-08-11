using TestAutomation.Framework.Helpers.Json;
using TestAutomation.Framework.Helpers.Setup;
using TestAutomation.Framework.Helpers.UI_Helpers.HTMLControls;

namespace TestAutomation.UITests.Pages.Pages_UI
{
    public class RegistrationPage : BasePage<RegistrationPage>
    {
        JsonHelper jHelper = new JsonHelper();
        private const string ORName = "Registration";

		//LBL_Firstname

		private const string firstnameLabelbyxpath = "LBL_Firstname_ByXPath";
		public HtmlLabel FirstnameLabelByXPath => new HtmlLabel(jHelper.GetOR(firstnameLabelbyxpath, ORName));

		private const string firstnameLabelbytext = "LBL_Firstname_ByText";
		public HtmlLabel FirstnameLabelByText => new HtmlLabel(jHelper.GetOR(firstnameLabelbytext, ORName));

		private const string firstnameLabelbycss = "LBL_Firstname_ByCSS";
		public HtmlLabel FirstnameLabelByCSS => new HtmlLabel(jHelper.GetOR(firstnameLabelbycss, ORName));

		private const string firstnameLabelbyxpathlist = "LBL_Firstname_ByXPathList";
		public HtmlLabel FirstnameLabelByXPathList => new HtmlLabel(jHelper.GetOR(firstnameLabelbyxpathlist, ORName));


		//TXT_FirstName

		private const string firstnameTextbyxpath = "TXT_FirstName_ByXPath";
		public HtmlText FirstNameTextByXPath => new HtmlText(jHelper.GetOR(firstnameTextbyxpath, ORName));

		private const string firstnameTextbycss = "TXT_FirstName_ByCSS";
		public HtmlText FirstNameTextByCSS => new HtmlText(jHelper.GetOR(firstnameTextbycss, ORName));


		//LBL_Lastname

		private const string lastnameLabelbyxpath = "LBL_Lastname_ByXPath";
		public HtmlLabel LastnameLabelByXPath => new HtmlLabel(jHelper.GetOR(lastnameLabelbyxpath, ORName));

		private const string lastnameLabelbytext = "LBL_Lastname_ByText";
		public HtmlLabel LastnameLabelByText => new HtmlLabel(jHelper.GetOR(lastnameLabelbytext, ORName));

		private const string lastnameLabelbycss = "LBL_Lastname_ByCSS";
		public HtmlLabel LastnameLabelByCSS => new HtmlLabel(jHelper.GetOR(lastnameLabelbycss, ORName));

		private const string lastnameLabelbyxpathlist = "LBL_Lastname_ByXPathList";
		public HtmlLabel LastnameLabelByXPathList => new HtmlLabel(jHelper.GetOR(lastnameLabelbyxpathlist, ORName));


		//TXT_LastName

		private const string lastnameTextbyxpath = "TXT_LastName_ByXPath";
		public HtmlText LastNameTextByXPath => new HtmlText(jHelper.GetOR(lastnameTextbyxpath, ORName));

		private const string lastnameTextbycss = "TXT_LastName_ByCSS";
		public HtmlText LastNameTextByCSS => new HtmlText(jHelper.GetOR(lastnameTextbycss, ORName));


		//LBL_Username

		private const string usernameLabelbyxpath = "LBL_Username_ByXPath";
		public HtmlLabel UsernameLabelByXPath => new HtmlLabel(jHelper.GetOR(usernameLabelbyxpath, ORName));

		private const string usernameLabelbytext = "LBL_Username_ByText";
		public HtmlLabel UsernameLabelByText => new HtmlLabel(jHelper.GetOR(usernameLabelbytext, ORName));

		private const string usernameLabelbycss = "LBL_Username_ByCSS";
		public HtmlLabel UsernameLabelByCSS => new HtmlLabel(jHelper.GetOR(usernameLabelbycss, ORName));

		private const string usernameLabelbyxpathlist = "LBL_Username_ByXPathList";
		public HtmlLabel UsernameLabelByXPathList => new HtmlLabel(jHelper.GetOR(usernameLabelbyxpathlist, ORName));


		//TXT_Username

		private const string usernameTextbyxpath = "TXT_Username_ByXPath";
		public HtmlText UsernameTextByXPath => new HtmlText(jHelper.GetOR(usernameTextbyxpath, ORName));

		private const string usernameTextbycss = "TXT_Username_ByCSS";
		public HtmlText UsernameTextByCSS => new HtmlText(jHelper.GetOR(usernameTextbycss, ORName));


		//LBL_Password

		private const string passwordLabelbyxpath = "LBL_Password_ByXPath";
		public HtmlLabel PasswordLabelByXPath => new HtmlLabel(jHelper.GetOR(passwordLabelbyxpath, ORName));

		private const string passwordLabelbytext = "LBL_Password_ByText";
		public HtmlLabel PasswordLabelByText => new HtmlLabel(jHelper.GetOR(passwordLabelbytext, ORName));

		private const string passwordLabelbycss = "LBL_Password_ByCSS";
		public HtmlLabel PasswordLabelByCSS => new HtmlLabel(jHelper.GetOR(passwordLabelbycss, ORName));

		private const string passwordLabelbyxpathlist = "LBL_Password_ByXPathList";
		public HtmlLabel PasswordLabelByXPathList => new HtmlLabel(jHelper.GetOR(passwordLabelbyxpathlist, ORName));


		//TXT_Password

		private const string passwordTextbyxpath = "TXT_Password_ByXPath";
		public HtmlText PasswordTextByXPath => new HtmlText(jHelper.GetOR(passwordTextbyxpath, ORName));

		private const string passwordTextbycss = "TXT_Password_ByCSS";
		public HtmlText PasswordTextByCSS => new HtmlText(jHelper.GetOR(passwordTextbycss, ORName));


		//BTN_BackLogin

		private const string backToLoginButton = "BTN_Backlogin_ByXPath";
		public HtmlButton BackToLoginButton => new HtmlButton(jHelper.GetOR(backToLoginButton, ORName));

		//BTN_Register

		private const string registerButton = "BTN_Register_ByXPath";
		public HtmlButton RegisterButton => new HtmlButton(jHelper.GetOR(registerButton, ORName));

		//BTN_Captcha

		private const string captchaButton = "BTN_Captcha_ByXPath";
		public HtmlButton CaptchaButton => new HtmlButton(jHelper.GetOR(captchaButton, ORName));

	}
}
