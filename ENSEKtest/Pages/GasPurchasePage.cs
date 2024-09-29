using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSEKtest.Pages
{
    public class GasPurchasePage
    {
        private IWebDriver driver;

        public GasPurchasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement BuyMoreEnergy => driver.FindElement(By.XPath("//a[text()='Buy more »']"));


        private IWebElement ConfirmationText => driver.FindElement(By.XPath("//div[@class='container text-center']"));



        public void ClickBuyMoreEnergy()
        {
            BuyMoreEnergy.Click();
        }
        
        //Returns text of the element to be verified against
        public string GetPurchaseDivText()
        {
            return ConfirmationText.Text;
        }
    }


}
