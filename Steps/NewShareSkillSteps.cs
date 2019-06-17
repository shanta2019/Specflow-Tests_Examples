using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests
{
    [Binding]
    public class NewShareSkillSteps
    {
        [Given(@"I am on profiel page and I click on Share Skill tab")]
        public void GivenIAmOnProfielPageAndIClickOnShareSkillTab()
        {
            // Wait
            Thread.Sleep(1500);

            // Click on Share Skill tab
            Driver.driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]")).Click();
        }
        
        [When(@"I enetered all the required details")]
        public void WhenIEneteredAllTheRequiredDetails()
        {
            //Add Title
            Driver.driver.FindElement(By.XPath("//input[@name='title']")).SendKeys("MathematicsFun");
            Thread.Sleep(5000);

            //Add New Description
            Driver.driver.FindElement(By.Name("description")).SendKeys("This is a fun and lerning serious stuff ");
            Thread.Sleep(1000);

            //Click on Category dropdown menue
            Driver.driver.FindElement(By.XPath("//select[@name='categoryId']")).Click();
            Thread.Sleep(500);

            //Select category
            Driver.driver.FindElement(By.XPath("//option[@value='4']")).Click();
            Thread.Sleep(500);

            //Click on the SubCategory dropdown
            Driver.driver.FindElement(By.XPath("//select[@name='subcategoryId'  and @class='ui fluid dropdown']")).Click();
            Thread.Sleep(500);

            //Select the SubCategory
            Driver.driver.FindElement(By.XPath("//option[@value='4']")).Click();
            Thread.Sleep(500);

            //Add tags
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input")).SendKeys("123#Fun");
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input")).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            //Select Service Type Hourly Basis
            Driver.driver.FindElement(By.XPath("//input[@name='serviceType' and @value='0']")).Click();
            Thread.Sleep(500);

            //Click on online location type
            Driver.driver.FindElement(By.XPath("//input[@name='locationType' and @value='1']")).Click();
            Thread.Sleep(500);

            //Enter the Start Date
            Thread.Sleep(3000);
            Driver.driver.FindElement(By.XPath("//input[@name='startDate']")).SendKeys("30062019");
            Thread.Sleep(500);

            //Select the days available
            IList<IWebElement> checkbox = Driver.driver.FindElements(By.XPath("//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input"));
            int checkboxCount = checkbox.Count;
            for (int i = 0; i < checkboxCount; i++ )
            {
                //int j = i + 2;
                var day = Driver.driver.FindElement(By.XPath("//div[" + i + "]/div[1]/div[1]/label")).Text;
                if (day.Equals("Sun"))
                {
                    checkbox.ElementAt(i).Click();
                    Console.WriteLine("day has been selected successfully");
                    break;
                }

                
            }

            
            //Enter start time and End time
            Thread.Sleep(3000);
            Driver.driver.FindElement(By.XPath("//input[@name='StartTime']")).SendKeys("10.00.AM");
            Thread.Sleep(500);
            Driver.driver.FindElement(By.XPath("//input[@name='EndTime']")).SendKeys("02.00.PM");
            Thread.Sleep(500);

            //Select the skilltrade as credit
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div.twelve.wide.column > div > div:nth-child(2) > div > input[type=radio]")).Click();
            Thread.Sleep(500);

            //eneter the Credit amount 
            Driver.driver.FindElement(By.XPath("//input[@name='charge']")).SendKeys("1");
            Thread.Sleep(500);

            //Select the Status
            Driver.driver.FindElement(By.CssSelector("#service-listing-section > div.ui.container > div > form > div:nth-child(10) > div.twelve.wide.column > div > div:nth-child(1) > div > input[type=radio]")).Click();
            Thread.Sleep(500);

            
        }
        
        [Then(@"I Clik on save")]
        public void ThenIClikOnSave()
        {
            //Click Save Button
            Driver.driver.FindElement(By.XPath("//input[@value='Save']")).Click();
        }
        
        [Then(@"Skill should be saved under manage listing tab")]
        public void ThenSkillShouldBeSavedUnderManageListingTab()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Thread.Sleep(1000);
                CommonMethods.test = CommonMethods.extent.StartTest("New Share skill");

                Thread.Sleep(1000);
                string ExpectedValue = "MathematicsFun";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='listing - management - section']/div[2]/div[1]/table/tbody/tr[1]/td[3]")).Text;
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
