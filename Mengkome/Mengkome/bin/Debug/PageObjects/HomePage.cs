using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Mengkome.Extensions;

namespace Mengkome.PageObjects
{
    public class HomePage
    {
        // private IWebDriver driver;

        // By.XPath("//*[@id='id_username']")
        [FindsBy(How = How.XPath, Using = "//*[@id='id_username']")][CacheLookup]
        private IWebElement MyAccount { get; set; }
        
        /*
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        */

        public void ClickOnMyAccount()
        {
            // MyAccount.Click();
            // Here we are just passing the WebElement Name, so that it can be used in the Logs
            MyAccount.ClickOnIt("MyAccount");            
        }
    }
}