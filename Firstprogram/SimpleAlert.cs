using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstprogram
{
   public class SimpleAlert
    {

        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver("D:\\SagarAutomation");
            //driver.Manage().Window.Maximize();
            // Launch the URL
            driver.Url = "http://toolsqa.com/handling-alerts-using-selenium-webdriver/";

            driver.FindElement(By.Id("cookie_action_close_header")).Click();
            //driver.Url = "http://toolsqa.com/handling-alerts-using-selenium-webdriver/";
            driver.Manage().Window.Maximize();

            //This step produce an alert on screen
            driver.FindElement(By.XPath("//*[@id='content']/p[3]/button")).Click();

            // Switch the control of 'driver' to the Alert from main Window
            IAlert simpleAlert = driver.SwitchTo().Alert();

            // '.Text' is used to get the text from the Alert
            String alertText = simpleAlert.Text;
            Console.WriteLine("Alert text is " + alertText);

            // '.Accept()' is used to accept the alert '(click on the Ok button)'
            simpleAlert.Accept();
        }
    }
}
