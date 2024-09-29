using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSEKtest.Pages
{
    public class BuyEnergyPage
    {

        private IWebDriver driver;

        public BuyEnergyPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private IWebElement AddGasAmount => driver.FindElement(By.Id("energyType_AmountPurchased"));
        //Will need to be put into a table element later
        private IWebElement AddGasBuyButton => driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[5]/input"));
        private IWebElement ResetButton => driver.FindElement(By.Name("Reset"));

        public void AddAmountOfGas(string amount)
        {
            AddGasAmount.SendKeys(amount);
        }

        public void ClickPurhaseGas()
        {
            AddGasBuyButton.Click();
        }

        public void ClickResetValues()
        {
            ResetButton.Click();

        }
    } 
    
}
