

using OpenQA.Selenium;
using SeleniumWalkthrough.lib.driver_config;
using SeleniumWalkthrough.lib.pages;

namespace SeleniumWalkthrough.lib
{
	public class BbcWebsite
	{
		public readonly BbcHomePage bbcHomePage;
		public readonly BbcLoginPage bbcLoginPage;
		public readonly IWebDriver seleniumDriver;

		public BbcWebsite(string driverName, int pageLoadWaitInSecs = 2, int implicitWaitInSecs = 2)
		{
			seleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;

			bbcHomePage = new BbcHomePage(seleniumDriver);
			bbcLoginPage = new BbcLoginPage(seleniumDriver);
		}
	}
}
