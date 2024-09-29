using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSEKtest.Pages
{
    internal class Loginpage
    {
        private IWebDriver driver;

        public Loginpage(IWebDriver driver)
        {
            this.driver = driver;
        }

   
        private IWebElement EmailField => driver.FindElement(By.Id("Email"));
        private IWebElement PasswordField => driver.FindElement(By.Id("Password"));
        private IWebElement LoginButton => driver.FindElement(By.XPath("//input[@value='Log in']"));


        public void EnterEmail(string email)
        {
            EmailField.SendKeys(email);   
        }

        public void EnterPassword(string password)
        {
            PasswordField.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }


    };


}
