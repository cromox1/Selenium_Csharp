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
                ostrm = new FileStream(@"F:\tools\Csharp_projects_repos\CikguKuala\CikguKuala\Redirect1.txt", FileMode.Create, FileAccess.Write);
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

        [Test(Description = "Check guru99 Homepage for drop down button")]
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

            Console.WriteLine("Title 1 = " + m_driver.Title);
            Console.WriteLine("URL 1 = " + m_driver.Url);
            Console.WriteLine("URL 2 = " + m_driver.Url.Split(new string[] { "test" }, StringSplitOptions.None)[0] + "test");
            String testURL = "http://demo.guru99.com";
            Console.WriteLine("URL test1 = " + testURL + "/ui");
            String testURL2 = m_driver.Url.Split(new string[] { "ui" }, StringSplitOptions.None)[0];
            Console.WriteLine("URL test2 = " + testURL2);
            String testURL3 = m_driver.Url.Split(new string[] { "ui" }, StringSplitOptions.None)[0] + "ui";
            Console.WriteLine("URL test3 = " + testURL3);
            Console.WriteLine("URL test4 = " + testURL3 + "/ui");

        }

        [TearDown]
        public void CloseBrowser()
        {
            m_driver.Close();
            Console.WriteLine("Done");
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();            
        }
    }
}