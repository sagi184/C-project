using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Firstprogram
{
    public class MultiipleWindow
    {
        [Test]
        public void TMultipletestest()
        {
            IWebDriver driver = new ChromeDriver("D:\\SagarAutomation");
            //driver.Manage().Window.Maximize();
            // Launch the URL
            driver.Url = "http://toolsqa.com/automation-practice-switch-windows/";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("cookie_action_close_header")).Click();
            
            

            

            // Store the parent window of teh driver
            String parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent window's handle -> " + parentWindowHandle);

            IWebElement clickElement = driver.FindElement(By.Id("button1"));

            // Multiple click to open multiple window
            for (var i = 0; i < 3; i++)
            {
                clickElement.Click();
                Thread.Sleep(3000);
            }
        }
    }
}
