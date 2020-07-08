using System;
using TechTalk.SpecFlow;
using SeleniumWalkthrough.lib;
using NUnit.Framework;

namespace SeleniumWalkthrough.lib.features
{
    [Binding]
    public class BbcLoginSteps
    {
        private BbcWebsite _bbcWebsite = new BbcWebsite("chrome");

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            _bbcWebsite.bbcLoginPage.VisitLoginPage();
            //_bbcWebsite.bbcHomePage.VisitHomePage(); //Depends if you want to go homepage first then click link
        }
        
        [Given(@"I have entered a username of ""(.*)""")]
        public void GivenIHaveEnteredAUsernameOf(string username)
        {
            _bbcWebsite.bbcLoginPage.InputUserName(username);
        }
        
        [Given(@"I have entered a password of ""(.*)""")]
        public void GivenIHaveEnteredAPasswordOf(string password)
        {
            _bbcWebsite.bbcLoginPage.InputPassword(password);
        }
        
        [When(@"I press login")]
        public void WhenIPressLogin()
        {
            _bbcWebsite.bbcLoginPage.ClickSubmit();
        }
        
        [Then(@"I should see the password error message ""(.*)""")]
        public void ThenIShouldSeeThePasswordErrorMessage(string passwordErrorMessage)
        {
            var result = _bbcWebsite.bbcLoginPage.GetPasswordErrorText();
            Assert.That(result, Is.EqualTo(passwordErrorMessage));
        }

        [Then(@"I should see the email error message ""(.*)""")]
        public void ThenIShouldSeeTheEmailErrorMessage(string emailErrorMessage)
        {
            var result = _bbcWebsite.bbcLoginPage.GetEmailErrorText();
            Assert.That(result, Is.EqualTo(emailErrorMessage));
        }


        [When(@"I press Need help signing in")]
        public void WhenIPressNeedHelpSigningIn()
        {
            _bbcWebsite.bbcLoginPage.ClickNeedHelp();
        }

        [Then(@"I should be redirected to the Need Help Signing In Page")]
        public void ThenIShouldBeRedirectedToTheNeedHelpSigningInPage()
        {
            _bbcWebsite.bbcLoginPage.VisitHelpSignInPage();
            //Have assert in thens
        }

        [When(@"I press Register now")]
        public void WhenIPressRegisterNow()
        {
            _bbcWebsite.bbcLoginPage.ClickRegisterNow();
        }

        [Then(@"I should be redirected to the Register Page")]
        public void ThenIShouldBeRedirectedToTheRegisterPage()
        {
            _bbcWebsite.bbcLoginPage.VisitRegisterNowPage();
        }

        [AfterScenario]
        public void DisposeWebDriver() {
            _bbcWebsite.seleniumDriver.Dispose();
        }
    }
}
