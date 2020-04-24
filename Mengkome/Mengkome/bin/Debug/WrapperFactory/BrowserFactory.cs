using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
// using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
/*
using OpenQA.Selenium.Support.PageObjects;
using Mengkome.PageObjects;
*/

namespace Mengkome.WrapperFactory
{
    class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;        

        public static IWebDriver getDriver
        {
            get
            {                   
                if (driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
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
                    if (driver == null)
                    {
                        driver = new FirefoxDriver();
                        Drivers.Add("Firefox", getDriver);
                    }
                    break;
                    
                case "Chrome":
                    if (driver == null)
                    {
                        driver = new ChromeDriver(@"C:\tools\chromewebdriver");
                        Drivers.Add("Chrome", getDriver);
                    }
                    break;
            }            
        }

        public static void LoadApplication(string url)
        {
            getDriver.Url = url;               
        }
                                   
        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }
    }
}