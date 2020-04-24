using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
// using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OnlineStore.PageObjects;

namespace OnlineStore.WrapperFactory
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;        

        public static IWebDriver Driver
        {
            get
            {   
                /*
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
                */
                return driver;
            }

            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    if (Driver == null)
                    {
                        Driver = new FirefoxDriver();
                        Drivers.Add("Firefox", Driver);
                    }
                    break;
                    
                case "Chrome":
                    if (Driver == null)
                    {
                        Driver = new ChromeDriver(@"C:\tools\chromewebdriver");
                        Drivers.Add("Chrome", Driver);
                    }
                    break;
            }            
        }

        public static void LoadApplication(string url)
        {
            Driver.Url = url;               
        }

        /*
        var homePage = new HomePage(driver);
        homePage.ClickOnMyAccount();

        var loginPage = new LoginPage(driver);
        loginPage.LoginToApplication("LoginTest");
        */

        /* 
        public static void ClickMyAccount()
        {
            var homePage = new HomePage(Driver.CurrentWindowHandle());
            homePage.ClickOnMyAccount(); 
        }

        public static void LoginApplication(string appname)
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginToApplication(appname);
        }
        */
                                   
        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }

        /*
        public static IWebDriver getDriver(string browserName)
        {
            return Drivers[browserName];
        }
        */
    }
}