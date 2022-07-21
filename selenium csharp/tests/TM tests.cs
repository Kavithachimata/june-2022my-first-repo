using NUnit.Framework;
using OpenQA.Selenium;
using selenium_csharp.pages;
using selenium_csharp.utilities;
using static selenium_csharp.pages.homepage;


namespace selenium_csharp.tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : Commondriver
    {
            // Page objects initialization
            homepage homePageObj = new homepage();
            TM_Page tmPageObj = new TM_Page();
            
        [Test, Order(1), Description("Check if user is able to create Material record with valid data")]
            public void CreateTmTest()
            {
                homePageObj.GoToTMPage(driver);
                tmPageObj.CreateTM(driver);
            }

            [Test, Order(2), Description("Check if user is able to edit Material record with valid data")]
            public void EditTmtest()
            {
            
                homePageObj.GoToTMPage(driver);
                tmPageObj.EditTM(driver);
            }

            [Test, Order(3), Description("Check if user is able to delete Material record")]
            public void DeleteTmTest()
            {
            
                homePageObj.GoToTMPage(driver);
                tmPageObj.DeleteTM(driver);
            }


        }
}










