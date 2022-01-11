using MoneyCorp.Base;
using MoneyCorp.ObjectRepositery;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyCorp.Pages
{
    class MoneyCorpPages : BaseClass  //Page class inheriting base class
    {
	//This Page class contains all locators and their operations on elements.
        
	//Created object of Object Repository Class
	MoneyCorpObjectRepository obj = new MoneyCorpObjectRepository();
	

	//Defining the element variables
	public IWebElement countryUSAOptionElement => driver.FindElement(obj.countryUSAOption);
	public IWebElement findOutMoreButtonElement => driver.FindElement(obj.findOutMoreButton);
	public IWebElement searchIconElement => driver.FindElement(obj.searchIcon);
	public IWebElement searchTextFieldElement => driver.FindElement(obj.searchTextField);
	public IWebElement searchedLinksElement => driver.FindElement(obj.searchedLinks);
	public IWebElement acceptCookiesButtonElement => driver.FindElement(obj.acceptCookiesButton);
	public IWebElement languageIconElement => driver.FindElement(obj.languageIcon);
	
        public void AcceptCookies()
        {
            acceptCookiesButtonElement.Click();
        }

        public void ClickAction(IWebElement element)
        {
            element.Click();
        }
	public void EnterText (IWebElement element, String text)
	{
	    element.sendkeys(text);	
	}
	public void ClickEnter(IWebElement)
	{
	    element.sendkeys(Keys.ENTER);	   
	}
	public void ScrollToUSAEnglishOptionAndClick()
	{
		JavascriptExecutor jse = (JavascriptExecutor)driver;
		jse.executeScript("arguments[0].scrollIntoView(true);", countryUSAOptionElement);
		countryUSAOptionElement.Click();
		
	}
	public void ScrollTofindOutMoreButtonAndClick()
	{
		JavascriptExecutor jse = (JavascriptExecutor)driver;
		jse.executeScript("arguments[0].scrollIntoView(true);", findOutMoreButtonElement);
		findOutMoreButtonElement.Click();
	}
	public bool ValidatePageURL(string url)
        {
		If (driver.Url() == url)
		{
			return true;
		}
		else
		{
			return false;
		}	
        }
	

        public bool ValidateLinks()
        {
            IList <IWebElement> searchedLinksList = driver.FindElements(By.XPath("//a[@class='title']")
            for(int i = 0; i < searchedLinksList.Count; i++)
                
            {
                if (searchedLinksList[i].GetAttribute("href").StartsWith("https://www.moneycorp.com/en-us/"))
                {
                    return true;
                }
		else
		{
		    return false;	
		}
            }

        }


    }
}
