using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstprogram
{
    // Dropdown test
    class Secondclass
    {
        IWebDriver m_driver;

        [Test]
        public void selectDemo()
        {
            m_driver = new ChromeDriver("D:\\SagarAutomation");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();

            IWebElement course = m_driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

            var selectTest = new SelectElement(course);
            // Select a value from the dropdown				
            selectTest.SelectByValue("sap-abap");

        }
    }
}
