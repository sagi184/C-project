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
  public class Prompt
    {

        [Test]
        public void Promttest()
        {
            IWebDriver driver = new ChromeDriver("D:\\SagarAutomation");
            //driver.Manage().Window.Maximize();
            // Launch the URL
            driver.Url = "http://toolsqa.com/handling-alerts-using-selenium-webdriver/";

            driver.FindElement(By.Id("cookie_action_close_header")).Click();
            driver.Manage().Window.Maximize();
           

            //This step produce an alert on screen
            IWebElement element = driver.FindElement(By.XPath("//*[@id='content']/p[10]/button"));

            // 'IJavaScriptExecutor' is an 'interface' which is used to run the 'JavaScript code' into the webdriver (Browser)        
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);

            // Switch the control of 'driver' to the Alert from main window
            IAlert promptAlert = driver.SwitchTo().Alert();

            // Get the Text of Alert
            String alertText = promptAlert.Text;
            Console.WriteLine("Alert text is " + alertText);

            //'.SendKeys()' to enter the text in to the textbox of alert 
            promptAlert.SendKeys("Accepting the alert");

            Thread.Sleep(4000); //This sleep is not necessary, just for demonstration

            // '.Accept()' is used to accept the alert '(click on the Ok button)'
            promptAlert.Accept();
        }
    }
}
