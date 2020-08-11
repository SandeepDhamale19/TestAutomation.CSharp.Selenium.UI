using TestAutomation.Framework.Helpers.Json;
using TestAutomation.Framework.Helpers.Setup;
using TestAutomation.Framework.Helpers.UI_Helpers.HTMLControls;

namespace TestAutomation.UITests.Pages.Pages_UI
{
    public class LoginPage : BasePage<LoginPage>
    {
        JsonHelper jHelper = new JsonHelper();
        private const string ORName = "Login";

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


		//BTN_Newuser

		private const string newuserButtonbyxpath = "BTN_Newuser_ByXPath";
		public HtmlButton NewuserButtonByXPath => new HtmlButton(jHelper.GetOR(newuserButtonbyxpath, ORName));

		private const string newuserButtonbytext = "BTN_Newuser_ByText";
		public HtmlButton NewuserButtonByText => new HtmlButton(jHelper.GetOR(newuserButtonbytext, ORName));

		private const string newuserButtonbycss = "BTN_Newuser_ByCSS";
		public HtmlButton NewuserButtonByCSS => new HtmlButton(jHelper.GetOR(newuserButtonbycss, ORName));

		private const string newuserButtonbyxpathlist = "BTN_Newuser_ByXPathList";
		public HtmlButton NewuserButtonByXPathList => new HtmlButton(jHelper.GetOR(newuserButtonbyxpathlist, ORName));


		//BTN_Login

		private const string loginButtonbyxpath = "BTN_Login_ByXPath";
		public HtmlButton LoginButtonByXPath => new HtmlButton(jHelper.GetOR(loginButtonbyxpath, ORName));

		private const string loginButtonbytext = "BTN_Login_ByText";
		public HtmlButton LoginButtonByText => new HtmlButton(jHelper.GetOR(loginButtonbytext, ORName));

		private const string loginButtonbycss = "BTN_Login_ByCSS";
		public HtmlButton LoginButtonByCSS => new HtmlButton(jHelper.GetOR(loginButtonbycss, ORName));

		private const string loginButtonbyxpathlist = "BTN_Login_ByXPathList";
		public HtmlButton LoginButtonByXPathList => new HtmlButton(jHelper.GetOR(loginButtonbyxpathlist, ORName));



	}
}
