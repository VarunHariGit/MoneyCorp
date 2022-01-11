using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyCorp.Base
{
    class BaseClass
    {
        public static IWebDriver driver = null;
        /// <summary>
        /// Used initialize the IWebDriver and Navigate site URL
        /// </summary>
        /// <param name="URL">Please pass the URL to navigate</param>
        /// <param name="path">Please pass the chromeDriver path</param>
        public void LaunchChrome(string URL, string path)
        {
            try
            {
                driver = new ChromeDriver(path); //created instance of ChromeDriver
                driver.Navigate().GoToUrl(URL);
                driver.Manage().Window.Maximize();
            }
            catch(Exception Es)
            {
                Assert.Fail("Unable to Launch the chrome" + Es.Message);

            }
	public void QuitBrowser()
            {
            	driver.Quit();
		//close() closes only the current window on which Selenium is running automated tests. 
		The WebDriver session, however, remains active. On the other hand, the driver. quit() method 
		closes all browser windows and ends the WebDriver session
            }
    }
}
