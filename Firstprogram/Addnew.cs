using Firstprogram.Properties;
using Firstprogram.Wrapper;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Firstprogram
{
   public class Addnew 
    {
        //IWebDriver driver;
      //  Setup s = new Setup();

        public string geturl()
        {
            return Properties.Settings1.Default["Url"].ToString();

        }
        public string geturl2()
        {
            return Properties.Settings1.Default["Url2"].ToString();
        }


        [Test]
        public void Browser()
        {
            //s.startBrowser();
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(geturl2());
           // driver.Url = geturl2();
          //  IWebElement element = driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']"));
           // element.SendKeys("guru99");
          //  IWebElement element1 = driver.FindElement(By.XPath("(//*[@class='gNO89b'])[2]"));
            //element1.Click();

        }

        [Test, Order(1)]
        public void test2()
        {
           // s.startBrowser();
          //  driver.Url = geturl2();
            //IWebElement element = driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']"));
            //element.SendKeys("guru99");
            //IWebElement element1 = driver.FindElement(By.XPath("(//*[@class='gNO89b'])[2]"));
            //element1.Click();

        }


        [TearDown]
        public void closeBrowser()
        {
           // driver.Close();
        }

    }
}

