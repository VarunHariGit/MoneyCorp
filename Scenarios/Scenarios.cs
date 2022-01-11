using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using MoneyCorp.Base;
using MoneyCorp.Steps;
using MoneyCorp.TestData;
using Assert = NUnit.Framework.Assert;w

namespace MoneyCorp.Scenarios
{
    /// <summary>
    /// Summary description for MoneyCorp Scenarios
    /// </summary>
    [TestClass]
    public class Scenarios

    {
        MoneyCorpTestData obj1 = new MoneyCorpTestData();
	MoneyCorpPages obj2 = new MoneyCorpPages();

        [Test]
        public void ValidateMoneyCorpSite()
        {
            
	
            //Method Calling
            obj2.LaunchChrome(System.Configuration.ConfigurationManager.AppSettings["URL"], System.Configuration.ConfigurationManager.AppSettings["ChromePath"]);
	    obj2.AcceptCookies();   //accept_cookies:to accept the cookies modal dialog
	    obj2.ClickAction(obj2.languageIconElement);  //calling element within generic method
	    obj2.ScrollToUSAEnglishOptionAndClick();
	    obj2.ScrollTofindOutMoreButtonAndClick();
	    Assert.IsTrue(obj2.ValidatePageURL(obj1.foreignExchangeSolutionPageURL, User has arrived on Foreign exchange solutions Page)); //Assertions added
	    obj2.ClickAction(obj2.searchIconElement);
            obj2.EnterText(obj2.searchTextFieldElement, obj1.searchText)
	    obj2.ClickEnter(obj2.searchTextFieldElement)
	    Assert.IsTrue(obj2.ValidatePageURL(obj1.internationapPaymentsPageURL, User has arrived on International Payment Page)); //Assertions added
	    Assert.IsTrue(obj2.ValidateLinks(), User has validated the links);
	    obj2.QuitBrowser();
	     	
	    		
         }


        

    }
}
