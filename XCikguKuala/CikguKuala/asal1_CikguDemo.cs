using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace CikguKuala
{
    class CikguDemo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver(@"C:\tools\chromewebdriver");
        }

        [Test]
        public void TestOne()
        {
            driver.Url = "http://www.google.co.uk";
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
