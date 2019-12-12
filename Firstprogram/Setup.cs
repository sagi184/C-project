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
   public class Setup
    {
      public static IWebDriver driver = null;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\SagarAutomation");
        }

        

    }
}
