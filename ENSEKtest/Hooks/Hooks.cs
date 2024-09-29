using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ENSEKtest.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        
        }

        //Tag incase anything needs to be done before scenario, not needed right now
        //[BeforeScenario("@tag1")]
        //public void BeforeScenarioWithTag()
        //{

       // }
       
        //Before every scenario this will run, Saves time only needs to be called once
        //Other orders can be added url could go here to only be called once if all stories start from same url
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        // Teardown
        [AfterScenario]
        public void AfterScenario()
        {
           var driver = _container.Resolve<IWebDriver>();
            //If the driver has nothing passed i.e doing nothing the driver will close
            if(driver != null)
            {
                driver.Quit();  
            }
        }
    }
}