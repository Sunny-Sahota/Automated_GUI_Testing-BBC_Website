using OpenQA.Selenium;

namespace SeleniumWalkthrough.lib.pages
{
    public class BbcHomePage
    {
        private IWebDriver _seleniumDriver;

        public BbcHomePage(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }

        internal void VisitHomePage()
        {
            //_seleniumDriver.Manage().Window.Maximize();
            // navigate to the BBC homepage
            _seleniumDriver.Navigate().GoToUrl("https://www.bbc.co.uk");
        }

        internal void ClickSignInLink()
        {
            // click the login button
            IWebElement loginButton = _seleniumDriver.FindElement(By.Id("idcta-link"));
            loginButton.Click();
        }
    }
}
