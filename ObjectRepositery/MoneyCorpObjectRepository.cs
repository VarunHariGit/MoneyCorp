using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyCorp.ObjectRepositery
{
    class MoneyCorpObjectRepository
    {
        
        public By countryUSAOption = By.XPath("//a[@aria-label = 'USA English']");
        public By findOutMoreButton = By.XPath("//h3[text()='Foreign exchange solutions']/following-sibling::a/span");
        public By searchIcon = By.XPath("//button[contains(@class,'navigation-search')]");
        public By searchTextField = By.Id("nav_search");
        public By searchedLinks = By.XPath("//a[@class='title']");
	public By acceptCookiesButton = By.Id("onetrust-accept-btn-handler");
	public By languageIcon = By.CSSSelector("#language-dropdown-flag img");

    }
}
