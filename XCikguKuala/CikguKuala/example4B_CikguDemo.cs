using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
// using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace CikguKuala
{
    class CikguDemo
    {
        IWebDriver m_driver;        
        FileStream ostrm;
        StreamWriter writer;
        readonly TextWriter oldOut = Console.Out;

        [SetUp]
        public void StartBrowser()
        {
            m_driver = new ChromeDriver(@"C:\tools\chromewebdriver");

            try
            {
                ostrm = new FileStream(@"F:\tools\Csharp_projects_repos\CikguKuala\CikguKuala\Redirect1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect1.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            // Console.WriteLine("This is a line of text");
        }

        [Test]
        public void TestOne()
        {
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();
            
            IWebElement el_course = m_driver.FindElement(By.Id("awf_field-91977689"));
            // IWebElement el_course = m_driver.FindElement(By.XPath("//*[@id='awf_field-91977689']"));
            // IWebElement el_course = m_driver.FindElement(By.XPath("//*[@name='listname']"));  // tak-jalan          
            Console.WriteLine("Successfull - go to SAP dropdown list");

            var selectTest = new SelectElement(el_course);
            
            // Select a value from the dropdown
            // selectTest.SelectByValue("sap-abap");
            selectTest.SelectByText("SAP ABAP");
            Console.WriteLine("Successfull - picked SAP ABAP");
        }

        [TearDown]
        public void CloseBrowser()
        {
            m_driver.Close();
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            // Console.WriteLine("Done");
        }
    }
}