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
   public class Confirm
    {
        [Test]
        public void Confirmtest()
        {
            IWebDriver driver = new ChromeDriver("D:\\SagarAutomation");
            //driver.Manage().Window.Maximize();
            // Launch the URL
            driver.Url = "http://toolsqa.com/handling-alerts-using-selenium-webdriver/";

            driver.FindElement(By.Id("cookie_action_close_header")).Click();
            driver.Manage().Window.Maximize();

            //This step produce an alert on screen
            IWebElement element = driver.FindElement(By.XPath("//*[@id='content']/p[7]/button"));

            // 'IJavaScriptExecutor' is an interface which is used to run the 'JavaScript code' into the webdriver (Browser)
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);

            // Switch the control of 'driver' to the Alert from main window
            IAlert confirmationAlert = driver.SwitchTo().Alert();

            // Get the Text of Alert
            String alertText = confirmationAlert.Text;

            Console.WriteLine("Alert text is " + alertText);

            //'.Dismiss()' is used to cancel the alert '(click on the Cancel button)'
            //  confirmationAlert.Dismiss();
            confirmationAlert.Accept();

        }
    }
}
