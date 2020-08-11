using TestAutomation.Framework.Helpers.Json;
using TestAutomation.Framework.Helpers.Setup;
using TestAutomation.Framework.Helpers.UI_Helpers.HTMLControls;

namespace TestAutomation.UITests.Pages.Pages_UI
{
    public class BookStoreNavigationPage : BasePage<BookStoreNavigationPage>
    {
        JsonHelper jHelper = new JsonHelper();
        private const string ORName = "BookStoreNavigation";

		//LBL_Login

		private const string loginLabelbyxpath = "LBL_Login_ByXPath";
		public HtmlLabel LoginLabelByXPath => new HtmlLabel(jHelper.GetOR(loginLabelbyxpath, ORName));

		private const string loginLabelbytext = "LBL_Login_ByText";
		public HtmlLabel LoginLabelByText => new HtmlLabel(jHelper.GetOR(loginLabelbytext, ORName));

		private const string loginLabelbyxpathlist = "LBL_Login_ByXPathList";
		public HtmlLabel LoginLabelByXPathList => new HtmlLabel(jHelper.GetOR(loginLabelbyxpathlist, ORName));


		//LBL_Bookstore

		private const string bookstoreLabelbyxpath = "LBL_Bookstore_ByXPath";
		public HtmlLabel BookstoreLabelByXPath => new HtmlLabel(jHelper.GetOR(bookstoreLabelbyxpath, ORName));

		private const string bookstoreLabelbytext = "LBL_Bookstore_ByText";
		public HtmlLabel BookstoreLabelByText => new HtmlLabel(jHelper.GetOR(bookstoreLabelbytext, ORName));

		private const string bookstoreLabelbyxpathlist = "LBL_Bookstore_ByXPathList";
		public HtmlLabel BookstoreLabelByXPathList => new HtmlLabel(jHelper.GetOR(bookstoreLabelbyxpathlist, ORName));


		//LBL_Profile

		private const string profileLabelbyxpath = "LBL_Profile_ByXPath";
		public HtmlLabel ProfileLabelByXPath => new HtmlLabel(jHelper.GetOR(profileLabelbyxpath, ORName));

		private const string profileLabelbytext = "LBL_Profile_ByText";
		public HtmlLabel ProfileLabelByText => new HtmlLabel(jHelper.GetOR(profileLabelbytext, ORName));

		private const string profileLabelbyxpathlist = "LBL_Profile_ByXPathList";
		public HtmlLabel ProfileLabelByXPathList => new HtmlLabel(jHelper.GetOR(profileLabelbyxpathlist, ORName));


		//LBL_Bookstoreapi

		private const string bookstoreapiLabelbyxpath = "LBL_Bookstoreapi_ByXPath";
		public HtmlLabel BookstoreapiLabelByXPath => new HtmlLabel(jHelper.GetOR(bookstoreapiLabelbyxpath, ORName));

		private const string bookstoreapiLabelbytext = "LBL_Bookstoreapi_ByText";
		public HtmlLabel BookstoreapiLabelByText => new HtmlLabel(jHelper.GetOR(bookstoreapiLabelbytext, ORName));

		private const string bookstoreapiLabelbyxpathlist = "LBL_Bookstoreapi_ByXPathList";
		public HtmlLabel BookstoreapiLabelByXPathList => new HtmlLabel(jHelper.GetOR(bookstoreapiLabelbyxpathlist, ORName));


	}
}
