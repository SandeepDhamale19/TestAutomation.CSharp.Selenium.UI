using TestAutomation.Framework.Helpers.Json;
using TestAutomation.Framework.Helpers.Setup;
using TestAutomation.Framework.Helpers.UI_Helpers.HTMLControls;

namespace TestAutomation.Selenium.Tests.Pages.Pages_UI
{
    public class HomePage : BasePage<HomePage>
    {
        JsonHelper jHelper = new JsonHelper();
        private const string ORName = "HomePage";

        private const string demoqacomLinkbyxpath = "LNK_DemoqaCom_ByXPath";
        public HtmlLink DemoqaComLinkByXPath => new HtmlLink(jHelper.GetOR(demoqacomLinkbyxpath, ORName));

        private const string demoqacomLinkbycss = "LNK_DemoqaCom_ByCSS";
        public HtmlLink DemoqaComLinkByCSS => new HtmlLink(jHelper.GetOR(demoqacomLinkbycss, ORName));


        //BTN_ImagesToolsqaJpg

        private const string imagestoolsqajpgButtonbyxpath = "BTN_ImagesToolsqaJpg_ByXPath";
        public HtmlButton ImagesToolsqaJpgButtonByXPath => new HtmlButton(jHelper.GetOR(imagestoolsqajpgButtonbyxpath, ORName));

        private const string imagestoolsqajpgButtonbycss = "BTN_ImagesToolsqaJpg_ByCSS";
        public HtmlButton ImagesToolsqaJpgButtonByCSS => new HtmlButton(jHelper.GetOR(imagestoolsqajpgButtonbycss, ORName));


        //LNK_WwwToolsqaComSelenium

        private const string wwwtoolsqacomseleniumLinkbyxpath = "LNK_WwwToolsqaComSelenium_ByXPath";
        public HtmlLink WwwToolsqaComSeleniumLinkByXPath => new HtmlLink(jHelper.GetOR(wwwtoolsqacomseleniumLinkbyxpath, ORName));

        private const string wwwtoolsqacomseleniumLinkbycss = "LNK_WwwToolsqaComSelenium_ByCSS";
        public HtmlLink WwwToolsqaComSeleniumLinkByCSS => new HtmlLink(jHelper.GetOR(wwwtoolsqacomseleniumLinkbycss, ORName));


        //BTN_ImagesWbSvg

        private const string imageswbsvgButtonbyxpath = "BTN_ImagesWbSvg_ByXPath";
        public HtmlButton ImagesWbSvgButtonByXPath => new HtmlButton(jHelper.GetOR(imageswbsvgButtonbyxpath, ORName));

        private const string imageswbsvgButtonbycss = "BTN_ImagesWbSvg_ByCSS";
        public HtmlButton ImagesWbSvgButtonByCSS => new HtmlButton(jHelper.GetOR(imageswbsvgButtonbycss, ORName));


        //LBL_Elements

        private const string elementsLabelbyxpath = "LBL_Elements_ByXPath";
        public HtmlLabel ElementsLabelByXPath => new HtmlLabel(jHelper.GetOR(elementsLabelbyxpath, ORName));

        private const string elementsLabelbytext = "LBL_Elements_ByText";
        public HtmlLabel ElementsLabelByText => new HtmlLabel(jHelper.GetOR(elementsLabelbytext, ORName));

        private const string elementsLabelbycss = "LBL_Elements_ByCSS";
        public HtmlLabel ElementsLabelByCSS => new HtmlLabel(jHelper.GetOR(elementsLabelbycss, ORName));

        private const string elementsLabelbyxpathlist = "LBL_Elements_ByXPathList";
        public HtmlLabel ElementsLabelByXPathList => new HtmlLabel(jHelper.GetOR(elementsLabelbyxpathlist, ORName));


        //LBL_Forms

        private const string formsLabelbyxpath = "LBL_Forms_ByXPath";
        public HtmlLabel FormsLabelByXPath => new HtmlLabel(jHelper.GetOR(formsLabelbyxpath, ORName));

        private const string formsLabelbytext = "LBL_Forms_ByText";
        public HtmlLabel FormsLabelByText => new HtmlLabel(jHelper.GetOR(formsLabelbytext, ORName));

        private const string formsLabelbycss = "LBL_Forms_ByCSS";
        public HtmlLabel FormsLabelByCSS => new HtmlLabel(jHelper.GetOR(formsLabelbycss, ORName));

        private const string formsLabelbyxpathlist = "LBL_Forms_ByXPathList";
        public HtmlLabel FormsLabelByXPathList => new HtmlLabel(jHelper.GetOR(formsLabelbyxpathlist, ORName));


        //LBL_Alertsframe&Windows

        private const string alertsframewindowsLabelbyxpath = "LBL_Alertsframe&Windows_ByXPath";
        public HtmlLabel AlertsframeWindowsLabelByXPath => new HtmlLabel(jHelper.GetOR(alertsframewindowsLabelbyxpath, ORName));

        private const string alertsframewindowsLabelbytext = "LBL_Alertsframe&Windows_ByText";
        public HtmlLabel AlertsframeWindowsLabelByText => new HtmlLabel(jHelper.GetOR(alertsframewindowsLabelbytext, ORName));

        private const string alertsframewindowsLabelbycss = "LBL_Alertsframe&Windows_ByCSS";
        public HtmlLabel AlertsframeWindowsLabelByCSS => new HtmlLabel(jHelper.GetOR(alertsframewindowsLabelbycss, ORName));

        private const string alertsframewindowsLabelbyxpathlist = "LBL_Alertsframe&Windows_ByXPathList";
        public HtmlLabel AlertsframeWindowsLabelByXPathList => new HtmlLabel(jHelper.GetOR(alertsframewindowsLabelbyxpathlist, ORName));


        //LBL_Widgets

        private const string widgetsLabelbyxpath = "LBL_Widgets_ByXPath";
        public HtmlLabel WidgetsLabelByXPath => new HtmlLabel(jHelper.GetOR(widgetsLabelbyxpath, ORName));

        private const string widgetsLabelbytext = "LBL_Widgets_ByText";
        public HtmlLabel WidgetsLabelByText => new HtmlLabel(jHelper.GetOR(widgetsLabelbytext, ORName));

        private const string widgetsLabelbycss = "LBL_Widgets_ByCSS";
        public HtmlLabel WidgetsLabelByCSS => new HtmlLabel(jHelper.GetOR(widgetsLabelbycss, ORName));

        private const string widgetsLabelbyxpathlist = "LBL_Widgets_ByXPathList";
        public HtmlLabel WidgetsLabelByXPathList => new HtmlLabel(jHelper.GetOR(widgetsLabelbyxpathlist, ORName));


        //LBL_Interactions

        private const string interactionsLabelbyxpath = "LBL_Interactions_ByXPath";
        public HtmlLabel InteractionsLabelByXPath => new HtmlLabel(jHelper.GetOR(interactionsLabelbyxpath, ORName));

        private const string interactionsLabelbytext = "LBL_Interactions_ByText";
        public HtmlLabel InteractionsLabelByText => new HtmlLabel(jHelper.GetOR(interactionsLabelbytext, ORName));

        private const string interactionsLabelbycss = "LBL_Interactions_ByCSS";
        public HtmlLabel InteractionsLabelByCSS => new HtmlLabel(jHelper.GetOR(interactionsLabelbycss, ORName));

        private const string interactionsLabelbyxpathlist = "LBL_Interactions_ByXPathList";
        public HtmlLabel InteractionsLabelByXPathList => new HtmlLabel(jHelper.GetOR(interactionsLabelbyxpathlist, ORName));


        //LBL_Bookstoreapplication

        private const string bookstoreapplicationLabelbyxpath = "LBL_Bookstoreapplication_ByXPath";
        public HtmlLabel BookstoreapplicationLabelByXPath => new HtmlLabel(jHelper.GetOR(bookstoreapplicationLabelbyxpath, ORName));

        private const string bookstoreapplicationLabelbytext = "LBL_Bookstoreapplication_ByText";
        public HtmlLabel BookstoreapplicationLabelByText => new HtmlLabel(jHelper.GetOR(bookstoreapplicationLabelbytext, ORName));

        private const string bookstoreapplicationLabelbycss = "LBL_Bookstoreapplication_ByCSS";
        public HtmlLabel BookstoreapplicationLabelByCSS => new HtmlLabel(jHelper.GetOR(bookstoreapplicationLabelbycss, ORName));

        private const string bookstoreapplicationLabelbyxpathlist = "LBL_Bookstoreapplication_ByXPathList";
        public HtmlLabel BookstoreapplicationLabelByXPathList => new HtmlLabel(jHelper.GetOR(bookstoreapplicationLabelbyxpathlist, ORName));


        //LBL_20132020Toolsqacom

        private const string toolsqacomLabelbyxpath = "LBL_20132020Toolsqacom_ByXPath";
        public HtmlLabel ToolsqacomLabelByXPath => new HtmlLabel(jHelper.GetOR(toolsqacomLabelbyxpath, ORName));

        private const string toolsqacomLabelbytext = "LBL_20132020Toolsqacom_ByText";
        public HtmlLabel ToolsqacomLabelByText => new HtmlLabel(jHelper.GetOR(toolsqacomLabelbytext, ORName));

        private const string toolsqacomLabelbycss = "LBL_20132020Toolsqacom_ByCSS";
        public HtmlLabel ToolsqacomLabelByCSS => new HtmlLabel(jHelper.GetOR(toolsqacomLabelbycss, ORName));

        private const string toolsqacomLabelbyxpathlist = "LBL_20132020Toolsqacom_ByXPathList";
        public HtmlLabel ToolsqacomLabelByXPathList => new HtmlLabel(jHelper.GetOR(toolsqacomLabelbyxpathlist, ORName));
    }
}
