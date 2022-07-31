using TechTalk.SpecFlow;
using selenium_csharp.utilities;
using selenium_csharp.pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace selenium_csharp;

[Binding]
public class TMFeatureStepDefinitions: Commondriver
{
    [Given(@"I logged into TrnUp portal successfully")]
    public void GivenILoggedIntoTrnUpPortalSuccessfully()
    {

    driver = new ChromeDriver();

    loginpage loginPageObj = new loginpage();
    loginPageObj.LoginActions(driver);
}

    [When(@"I navigate to Time and Meterial page")]
    public void WhenINavigateToTimeAndMeterialPage()
    {
        homepage homePageObj = new homepage();
        homePageObj.GoToTMPage(driver);
    }

    [When(@"I create new meterial record")]
    public void WhenICreateNewMeterialRecord()
    {
        TM_Page tmPageObj = new TM_Page();
        tmPageObj.EditTM(driver);
    }

    [Then(@"The record should be created sucessfully")]
    public void ThenTheRecordShouldBeCreatedSucessfully()
    {
        
    }
}
