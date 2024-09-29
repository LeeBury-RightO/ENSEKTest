using ENSEKtest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace ENSEKtest.StepDefinitions
{
    //Binding for Specflow, matches GWT scenarios
    [Binding]
    public class PurchaseGasStepDefinitions
    {
        //Pages initalized 
        private IWebDriver driver;
        private Homepage homepage;
        private Headderbar headderbar;
        private GasPurchasePage gasPurchasePage;
        private BuyEnergyPage buyEnergyPage;

        public PurchaseGasStepDefinitions(IWebDriver driver)
        {

            this.driver = driver;
        }

        [Given(@"I am on the main page")]
        public void GivenIAmOnTheMainPage()
        {
            driver.Url = "https://ensekautomationcandidatetest.azurewebsites.net";
            // Sleep is typically not ideal, waiting for element loading would be better
            Thread.Sleep(1000);
        }

        [Given(@"I click on the buy energy button")]
        public void GivenIClickOnTheBuyEnergyButton()
        {
            //Homepage accessed for use of methods within homepage
            homepage = new Homepage(driver);
            homepage.ClickBuyEnergy();
        }

        [When(@"I enter an amount of gas and click buy")]
        public void WhenIEnterAnAmountOfGasAndClickBuy()
        {
            buyEnergyPage = new BuyEnergyPage(driver);
            //Resetting Data
            buyEnergyPage.ClickResetValues();
            buyEnergyPage.AddAmountOfGas("100");
            buyEnergyPage.ClickPurhaseGas();
        }

        [Then(@"I am taken to the confirmation page showing the amount of gas i purhcased and amount remaining")]
        public void ThenIAmTakenToTheConfirmationPageShowingTheAmountOfGasIPurhcasedAndAmountRemaining()
        {
            gasPurchasePage = new GasPurchasePage(driver);
            string getpurchasetext = gasPurchasePage.GetPurchaseDivText();
            //Returning amount purchased
            Assert.IsTrue(getpurchasetext.Contains("100"));
            //Returning amount remaining
            Assert.IsTrue(getpurchasetext.Contains("2900"));
        }

    }
}
