/* 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  */

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Support.PageObjects;
using Mengkome.PageObjects;
using Mengkome.WrapperFactory;
using NUnit.Framework;
using System.Configuration;

namespace Mengkome.TestCases
{
    class LoginTest
    {
        // private IWebDriver driver;

        
        [SetUp]
        public void startTest()
        { 
            BrowserFactory.InitBrowser("Chrome");
        }        

        [Test]
        public void Test()
        {
            // BrowserFactory.InitBrowser("Firefox");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);            
            Page.Home.ClickOnMyAccount();
            Page.Login.LoginToApplication("LoginTest");  
        }

        [TearDown]
        public void EndTest()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}

/*
            IWebDriver driver = new ChromeDriver();
            driver.Url = ConfigurationManager.AppSettings["URL"];
            */

// IWebDriver driver = BrowserFactory.getDriver(apabrowser);
// private IWebElement LoginAgain { get; set; }                     
// IWebDriver driver = BrowserFactory.Driver;

/*
var homePage = new HomePage(driver);
homePage.ClickOnMyAccount();

var loginPage = new LoginPage(driver);
loginPage.LoginToApplication("LoginTest");
*/

// var apabrowser = "Firefox";
// BrowserFactory.InitBrowser(apabrowser);
// BrowserFactory.InitBrowser("Firefox");

// BrowserFactory.CloseAllDrivers();
// nampaknya BrowserFactory tak jalan

// BrowserFactory.ClickMyAccount();
// BrowserFactory.LoginApplication("LoginTest");

/*
            driver.Close();
            driver.Quit();
*/
