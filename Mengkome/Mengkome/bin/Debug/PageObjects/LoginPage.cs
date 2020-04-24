using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Mengkome.TestDataAccess;
using Mengkome.Extensions;

namespace Mengkome.PageObjects
{
    public class LoginPage
    {
        // private IWebDriver driver;

        /*
        driver.FindElement(By.Id("id_username")).Clear();
        driver.FindElement(By.Name("username")).SendKeys("mainakar");
        */
        [FindsBy(How = How.Id, Using = "id_username")][CacheLookup]
        private IWebElement UserName { get; set; }

        /*
        driver.FindElement(By.Id("id_password")).Clear();
        driver.FindElement(By.Name("password")).SendKeys("H0meBase");
        */
        [FindsBy(How = How.Name, Using = "password")][CacheLookup]
        private IWebElement Password { get; set; }

        /*
        driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        */
        [FindsBy(How = How.XPath, Using = "//*[@type='submit']")][CacheLookup]
        private IWebElement Login { get; set; }

        /*
        driver.FindElement(By.LinkText("LOG OUT")).Click();
        */
        [FindsBy(How = How.LinkText, Using = "LOG OUT")]
        private IWebElement Logout { get; set; }

        /*
        driver.FindElement(By.LinkText("Log in again")).Click();
        */
        [FindsBy(How = How.LinkText, Using = "Log in again")]
        private IWebElement LoginAgain { get; set; }

        /*
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        */

        public void LoginToApplication(string testName)
        {
            var userData = ExcelDataAccess.GetTestData(testName);
            // UserName.Clear();
            // UserName.SendKeys(userData.Username);
            UserName.EnterText(userData.Username, "id_username");
            // Password.Clear();
            // Password.SendKeys(userData.Password);
            Password.EnterText(userData.Password, "password");
            // Login.Submit();
            // Logout.Click();
            // LoginAgain.Click();
            Login.ClickOnIt("submit");
            Logout.ClickOnIt("LOG OUT");
            LoginAgain.ClickOnIt("Log in again");
        }
    }
}
