using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests
{
    [Binding]
    public class ManageListingSteps
    {
        [Given(@"I am on profiel page and click on manage listing tab")]
        public void GivenIAmOnProfielPageAndClickOnManageListingTab()
        {
            Thread.Sleep(500);
            //Click on the manage listing button
            Driver.driver.FindElement(By.XPath("//a[@href='/Home/ListingManagement']")).Click();
        }
        
        [When(@"I click on the View Icon")]
        public void WhenIClickOnTheViewIcon()
        {
            //Click on the view icon
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("//i[@class='eye icon']")).Click();

        }
        
        [Then(@"It will navigate me to the Viewing page")]
        public void ThenItWillNavigateMeToTheViewingPage()
        {
           
                try
                {
                    //Start the Reports
                    CommonMethods.ExtentReports();
                    Thread.Sleep(1000);
                    CommonMethods.test = CommonMethods.extent.StartTest("View listing");

                    Thread.Sleep(1000);
                    string ExpectedValue = "Average Ratings";
                    string ActualValue = Driver.driver.FindElement(By.XPath("//h3[contains(text(),'Average Ratings')]")).Text;
                    Thread.Sleep(500);
                    if (ExpectedValue == ActualValue)
                    {
                        CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Listing viewed Successfully");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "ListingViewed");
                    }

                    else
                        CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

                }
                catch (Exception e)
                {
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
                }
        }
    }
}
