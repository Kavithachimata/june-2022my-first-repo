using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium_csharp.pages;
using selenium_csharp.tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium_csharp.utilities
{
    public class Commondriver
    {
        public IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            loginpage loginPageObj = new loginpage();
            loginPageObj.LoginActions(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            //driver.Quit();
        }

    }

}
    


