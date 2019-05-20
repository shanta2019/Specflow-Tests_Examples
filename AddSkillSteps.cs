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
    public class AddSkillSteps
    {
        [Given(@"I am on the profiel page and I have clicked on the skill tab")]
        public void GivenIAmOnTheProfielPageAndIHaveClickedOnTheSkillTab()
        {
            //Wait
            Thread.Sleep(1500);

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//div[@class='ui eight item menu']//a[@class='item' and @href='/Account/Profile']")).Click();
            //Click on skills button
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
            Thread.Sleep(1000);

        }

        [When(@"I click on Add New button")]
        public void WhenIClickOnAddNewButton()
        {

            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//div[(text()='Add New' and @class='ui teal button')]")).Click();

            
        }
        
        [Then(@"I entered the skill")]
        public void ThenIEnteredTheSkill()
        {
            //Add Skill
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @placeholder='Add Skill']")).SendKeys("Selenium");
            //Click on Skill Level
            Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']")).Click();

            //Choose the Skill level
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//option[@value='Beginner']")).Click();
        }
        
        [Then(@"I click on add button")]
        public void ThenIClickOnAddButton()
        {
            //Click on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button' and @value='Add']")).Click();
        }
        
        [Then(@"the skill should be added on my profiel")]
        public void ThenTheSkillShouldBeAddedOnMyProfiel()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("Add a Skill");

                Thread.Sleep(1000);
                string ExpectedValue = "Selenium";
                string ActualValue = Driver.driver.FindElement(By.XPath("//table[@class='ui fixed table']//td[text()='Selenium']")).Text;
                Thread.Sleep(500);
                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "SkillAdded");
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
