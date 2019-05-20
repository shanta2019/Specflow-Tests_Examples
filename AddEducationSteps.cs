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
    public class AddEducationSteps
    {
        [Given(@"I am on the profiel page")]
        public void GivenIAmOnTheProfielPage()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item' and @href='/Account/Profile']")).Click();
        }
        
        [When(@"I click on the Education Tab")]
        public void WhenIClickOnTheEducationTab()
        {
            Driver.driver.FindElement(By.XPath("//a[text()='Education']")).Click();
        }
        
        [Then(@"I click on add new tab")]
        public void ThenIClickOnAddNewTab()
        {
            Thread.Sleep(1500);
            Driver.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")).Click();
            Thread.Sleep(1000);
        }
        
        [Then(@"I add all the details")]
        public void ThenIAddAllTheDetails()
        {
            //Add Institute name
            Driver.driver.FindElement(By.XPath("//input[@name='instituteName']")).SendKeys("Univercity of Pune");

            //Click on choose country option
            Driver.driver.FindElement(By.XPath("//select[@name='country']")).Click();

            //Select the country
            Driver.driver.FindElement(By.XPath("//option[@value='India']")).Click();

            //Click on Title option
            Driver.driver.FindElement(By.XPath("//select[@name='title']")).Click();

            //Select the title
            Driver.driver.FindElement(By.XPath("//option[@value='B.Sc']")).Click();

            //Add the Degree
            Driver.driver.FindElement(By.XPath("//input[@name='degree']")).SendKeys("Instrumentation and Control Engineering");

            //Click on the year of the degree option
            Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")).Click();

            //Select the year of the degree
            Driver.driver.FindElement(By.XPath("//option[@value='2009']")).Click();

           
            
        }
        
        [Then(@"I click on button to add education")]
        public void ThenIClickOnButtonToAddEducation()
        {

            //Click on Add buton
            Driver.driver.FindElement(By.XPath("//input[@value='Add']")).Click();
        }
        
        [Then(@"Education should be added")]
        public void ThenEducationShouldBeAdded()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add the Education");

                Thread.Sleep(1000);
                string ExpectedValue = "Instrumentation and Control Engineering";
                string ActualValue = Driver.driver.FindElement(By.XPath("//td[text()='Instrumentation and Control Engineering']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added the Education Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "EducationAdded");
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
