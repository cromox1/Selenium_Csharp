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
        IWebDriver m_driver;

        [SetUp]
        public void StartBrowser()
        {
            m_driver = new ChromeDriver(@"C:\tools\chromewebdriver");
        }

        [Test]
        public void TestOne()
        {
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();
            // IWebElement m_element = m_driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            IWebElement m_element = m_driver.FindElement(By.LinkText("Testing"));
            m_element.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            m_driver.Close();
        }

    }
}
