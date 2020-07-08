using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace SeleniumWalkthrough.lib.pages
{
    public class BbcLoginPage
    {
        private IWebDriver _seleniumDriver;

        public BbcLoginPage(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }

        internal void VisitLoginPage()
        {
            // navigate to the BBC login page
            _seleniumDriver.Navigate().GoToUrl(AppConfigReader.SignInPageUrl);
        }

        internal void InputUserName(string userName)
        {
            // enter a username
            IWebElement usernameField = _seleniumDriver.FindElement(By.Id("user-identifier-input"));
            usernameField.SendKeys(userName);
        }

        internal void InputPassword(string password)
        {
            // enter a password
            IWebElement passwordField = _seleniumDriver.FindElement(By.Id("password-input"));
            passwordField.SendKeys(password);
        }

        internal void ClickSubmit()
        {
            // click the signin button
            IWebElement signInButton = _seleniumDriver.FindElement(By.Id("submit-button"));
            signInButton.Click();
        }

        internal string GetPasswordErrorText()
        {
            // check the error is correct
            IWebElement passwordError = _seleniumDriver.FindElement(By.Id("form-message-password"));
            return passwordError.Text;
        }

        internal string GetEmailErrorText()
        {
            // check the error is correct
            IWebElement emailError = _seleniumDriver.FindElement(By.Id("form-message-username"));
            return emailError.Text;
        }

        internal void ClickNeedHelp()
        {
            IWebElement helpButton = _seleniumDriver.FindElement(By.ClassName("button__label"));
            helpButton.Click();
        }

        internal void VisitHelpSignInPage()
        {
            _seleniumDriver.Navigate().GoToUrl(AppConfigReader.HelpSignInPageUrl);
        }

        internal void ClickRegisterNow()
        {
            IWebElement registerButton = _seleniumDriver.FindElement(By.ClassName("link--primary"));
            registerButton.Click();
        }

        internal void VisitRegisterNowPage()
        {
            _seleniumDriver.Navigate().GoToUrl(AppConfigReader.RegisterUrl);
        }
    }
}