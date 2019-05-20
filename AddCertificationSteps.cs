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
    public class AddCertificationSteps
    {
        [Given(@"I am logged in and on the profiel pag")]
        public void GivenIAmLoggedInAndOnTheProfielPag()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item' and @href='/Account/Profile']")).Click();
        }
        
        [When(@"I click on the CertificationsTab")]
        public void WhenIClickOnTheCertificationsTab()
        {
            Driver.driver.FindElement(By.XPath("//a[text()='Certifications']")).Click();
        }
        
        [Then(@"I click on the add new tab")]
        public void ThenIClickOnTheAddNewTab()
        {
            //Click on add new tab
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")).Click();
        }
        
        [Then(@"I add all the details of certification")]
        public void ThenIAddAllTheDetailsOfCertification()
        {
            //Add Certificate name
            Driver.driver.FindElement(By.XPath("//input[@name='certificationName']")).SendKeys("Certified Chemical Handler");

            //Add the orgnisation
            Driver.driver.FindElement(By.XPath("//input[@name='certificationFrom']")).SendKeys("QEC");

            //Click on Year tab
            Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));

            //Choose the Year
            Driver.driver.FindElement(By.XPath("//option[@value='2018']"));
        }
        
        [Then(@"I click on add button to add the certification")]
        public void ThenIClickOnAddButtonToAddTheCertification()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }
        
        [Then(@"Certification should be added")]
        public void ThenCertificationShouldBeAdded()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add the Certification");

                Thread.Sleep(1000);
                string ExpectedValue = "Certified Chemical Handler";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='Certified Chemical Handler']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added the Certification Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationAdded");
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
