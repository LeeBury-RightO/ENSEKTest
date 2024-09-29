using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSEKtest.Pages
{
    public class Headderbar
    {
        //Initalise driver
        private IWebDriver driver;

        public Headderbar(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Finders
        private IWebElement RegisterLink => driver.FindElement(By.Id("registerlink"));
        private IWebElement LoginLink => driver.FindElement(By.Id("loginLink"));


        public void ClickRegisterLink()
        {
            RegisterLink.Click();

        }

        public void ClickLoginLink()
        {
            LoginLink.Click();
        }
    }
}
