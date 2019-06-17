using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class ManageRequestSteps
    {
        [Given(@"I am on profiel page and clicked on the manage request tab")]
        public void GivenIAmOnProfielPageAndClickedOnTheManageRequestTab()
        {
            Thread.Sleep(500);
            //Click on the manage listing button
            Driver.driver.FindElement(By.XPath("//div[contains(text(),'Manage Requests')]")).Click();
        }
        
        [When(@"I click on the received request option")]
        public void WhenIClickOnTheReceivedRequestOption()
        {
            
            //Click on the Received Request Link
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("//a[@href='/Home/ReceivedRequest']")).Click();
            Thread.Sleep(100);
                        
        }

        [Then(@"I should be navigated to received request page")]
        public void ThenIShouldBeNavigatedToReceivedRequestPage()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Received Request");

                Thread.Sleep(1000);
                string ExpectedValue = "You do not have any received requests!";
                string ActualValue = Driver.driver.FindElement(By.XPath("//h3[contains(text(),'You do not have any received requests!')]")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Managed request Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "ManageRequest");
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
