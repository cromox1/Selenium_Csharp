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

            IWebElement el_emailBox = m_driver.FindElement(By.Id("philadelphia-field-email"));
            // IWebElement el_emailBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            // other XPath = //*[@placeholder='Enter Email']
            
            IWebElement el_signUpBtn = m_driver.FindElement(By.Id("philadelphia-field-submit"));
            // IWebElement el_signUpBtn = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));
            // other XPath = //*[@value='Submit'] , //*[@type='submit'] , //*[@class='btn']

            el_emailBox.SendKeys("test123@gmail.com");
            el_signUpBtn.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            m_driver.Close();
        }

    }
}
