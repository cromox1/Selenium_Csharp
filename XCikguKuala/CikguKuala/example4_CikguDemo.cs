using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
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
            
            IWebElement el_course = m_driver.FindElement(By.Id("awf_field-91977689"));
            // IWebElement el_course = m_driver.FindElement(By.XPath("//*[@id='awf_field-91977689']"));
            // IWebElement el_course = m_driver.FindElement(By.XPath("//*[@name='listname']"));  // tak-jalan          

            var selectTest = new SelectElement(el_course);
            
            // Select a value from the dropdown
            // selectTest.SelectByValue("sap-abap");
            selectTest.SelectByText("SAP ABAP");
        }

        [TearDown]
        public void CloseBrowser()
        {
            m_driver.Close();
        }
    }
}
