using Firstprogram.Wrapper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstprogram
{
    public class Login
    {
        [Test]
        public void TestBrowser()
        {

            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication("https://opensource-demo.orangehrmlive.com/index.php/auth/login");

            //var homePage = new HomePage(driver);
            //homePage.ClickOnMyAccount();

            //var loginPage = new LoginPage(driver);
            //loginPage.LoginToApplication("LogInTest");

            //    BrowserFactory.CloseAllDrivers();
        }
    }
}
