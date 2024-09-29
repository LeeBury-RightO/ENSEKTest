using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace ENSEKtest.Pages
{
    public class Homepage
    {
        //Initalise driver
        private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        //Finders

        private IWebElement FindOutMore => driver.FindElement(By.ClassName("btn btn-primary btn-lg"));
        private IWebElement BuyEnergy => driver.FindElement(By.XPath("//a[text()='Buy energy »']"));
        private IWebElement SellEnergy => driver.FindElement(By.XPath("//a[text()='Sell energy »']"));
        private IWebElement LearnMore => driver.FindElement(By.XPath("//a[text()='Learn more »']"));

        public void ClickFindOutMore()
        {
            FindOutMore.Click();
        }

        public void ClickBuyEnergy()
        {
            BuyEnergy.Click();
        }

        public void ClickSellEnergy()
        {
            SellEnergy.Click();
        }

        public void ClickLearnMore()
        {
            LearnMore.Click();
        }

        public bool ButtonDisplayed()
        {
            return FindOutMore.Displayed;
        }

    } 
}
