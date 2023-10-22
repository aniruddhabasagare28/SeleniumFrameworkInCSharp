using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumFramework.util;
namespace SeleniumFramework.pages
{
    class Home
    {
        //########## Setup ############
        private IWebDriver driver = null;
        private Util util = null;
        public Home(IWebDriver d)
        {
            this.driver = d;
            util = new Util(d);
        }
        //########### Element Definition #############
        private By getgoogleHomeimg = By.CssSelector(".lnXdpd");
        private By resourceMenuXpath = By.Id("Calque_1");
        private By featureMenuXpath = By.XPath("//*[@id='header-menu']//a[contains(text(),'Features')]");
        //######### Function Definition #################
        public bool isHomePageLoaded()
        {
            return util.IsElementVisible(getgoogleHomeimg);
        }
        public bool clickResourceMenu()
        {
            return util.ClickElement(resourceMenuXpath);
        }
        public bool clickFeatureMenu()
        {
            return util.ClickElement(featureMenuXpath);
        }
        public void openHome(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.FullScreen();
            util.captureScreenshot("openHome");
        }
    }
}
