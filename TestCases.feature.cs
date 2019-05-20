﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecflowTests.AcceptanceTest
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AddProfileFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "TestCases.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add Profile", "       In order to get seen by employer\r\n       I want to set up profile", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Add Profile")))
            {
                global::SpecflowTests.AcceptanceTest.AddProfileFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Language")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void AddLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Language", new string[] {
                        "mytag"});
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
       testRunner.And("I click on language tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
       testRunner.When("I add new language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
       testRunner.Then("language should be listed under languages tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Skills")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddSkills()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Skills", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
       testRunner.And("I click on skills tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
       testRunner.When("I write new skill", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
    testRunner.And("I select skill level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
       testRunner.Then("skill should be listed under skills tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Education")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddEducation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Education", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
       testRunner.And("I click on Education tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
       testRunner.When("I write all the details of Education", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
    testRunner.And("I click on add button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
       testRunner.Then("Education should be listed under Education tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Certifications")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddCertifications()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Certifications", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
       testRunner.And("I click on Certifications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
       testRunner.When("I add all Certification details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
    testRunner.And("I click add button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
       testRunner.Then("Certification should be listed under Certifications tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddDescription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Description", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
       testRunner.And("I click on Description tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
       testRunner.When("I add Description", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
       testRunner.Then("Description should be listed under on Profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Availability")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddAvailability()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Availability", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
       testRunner.And("I click on Availability tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
       testRunner.When("I select Availability", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
       testRunner.Then("Availability should be listed in Availability section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Hours")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddHours()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Hours", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
       testRunner.And("I click on Hours tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
       testRunner.When("I select Hours", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 49
       testRunner.Then("Hours should be listed in Hours section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Earn Targets")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddEarnTargets()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Earn Targets", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 52
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
       testRunner.And("I click on Earn Targets tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
       testRunner.When("I add Earn Targets", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
       testRunner.Then("Earn Targets should be listed in Earn Targets section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Profile Photo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddProfilePhoto()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Profile Photo", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 58
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
       testRunner.And("I click on upload photo tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
       testRunner.When("I upload photo from computer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
       testRunner.Then("Uploaded photo should display on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Add Location")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void AddLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Location", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 64
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
       testRunner.And("I click on Location tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
       testRunner.When("I select preferred Location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
       testRunner.Then("Location should be listed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Description")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditDescription()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Description", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 71
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
       testRunner.And("I click on existing Description record edit tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
       testRunner.When("I edit Description", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 74
       testRunner.Then("edited Description should be updated under Description tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Language")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Language", ((string[])(null)));
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
       testRunner.And("I click on existing language record edit tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
       testRunner.When("I edit language level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
       testRunner.Then("edited language level should be updated under level tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete Language")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void DeleteLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Language", ((string[])(null)));
#line 82
this.ScenarioSetup(scenarioInfo);
#line 83
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
       testRunner.And("I click on existing language record delete tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
       testRunner.When("I delete language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
       testRunner.Then("deleted language should be removed from languages listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Skill")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditSkill()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Skill", ((string[])(null)));
#line 88
this.ScenarioSetup(scenarioInfo);
#line 89
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
       testRunner.And("I click on existing skill record edit tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
       testRunner.When("I edit skill level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
       testRunner.Then("edited skill level should be updated under level tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete Skill")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void DeleteSkill()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Skill", ((string[])(null)));
#line 94
this.ScenarioSetup(scenarioInfo);
#line 95
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 96
       testRunner.And("I click on existing skill record delete tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
       testRunner.When("I delete skill", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
       testRunner.Then("deleted skill should be removed from skills listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Education")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditEducation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Education", ((string[])(null)));
#line 100
 this.ScenarioSetup(scenarioInfo);
#line 101
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 102
       testRunner.And("I click on existing Education record edit tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
       testRunner.When("I edit Degree", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
       testRunner.Then("edited Degree should be updated under Degree tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete Education")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void DeleteEducation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Education", ((string[])(null)));
#line 106
this.ScenarioSetup(scenarioInfo);
#line 107
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 108
       testRunner.And("I click on existing Education record delete tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
       testRunner.When("I delete Education", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
       testRunner.Then("deleted skill should be removed from skills listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Certification")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditCertification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Certification", ((string[])(null)));
#line 113
this.ScenarioSetup(scenarioInfo);
#line 114
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 115
       testRunner.And("I click on existing Certification record edit tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
       testRunner.When("I edit Certificate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 117
       testRunner.Then("edited Certificate should be updated under Certification tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Delete Certification")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void DeleteCertification()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Certification", ((string[])(null)));
#line 120
this.ScenarioSetup(scenarioInfo);
#line 121
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 122
       testRunner.And("I click on existing Certification record delete tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
       testRunner.When("I delete Certification", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
       testRunner.Then("deleted certificate should be removed from Certificates listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Availability")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditAvailability()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Availability", ((string[])(null)));
#line 126
this.ScenarioSetup(scenarioInfo);
#line 127
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 128
       testRunner.And("I click on Edit Availability tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
       testRunner.When("I Edit Availability", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 130
       testRunner.Then("Edited Availability should be updated in Availability section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Hours")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditHours()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Hours", ((string[])(null)));
#line 132
this.ScenarioSetup(scenarioInfo);
#line 133
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 134
       testRunner.And("I click on Edit Hours tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
       testRunner.When("I Edit Hours", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 136
       testRunner.Then("Edited Hours should be updated in Hours section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Earn Targets")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditEarnTargets()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Earn Targets", ((string[])(null)));
#line 138
this.ScenarioSetup(scenarioInfo);
#line 139
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 140
       testRunner.And("I click on Edit Earn Targets tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
       testRunner.When("I Edit Earn Targets", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
       testRunner.Then("Edited Earn Targets should be updated in Earn Targets section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit First Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditFirstName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit First Name", ((string[])(null)));
#line 144
this.ScenarioSetup(scenarioInfo);
#line 145
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 146
       testRunner.And("I click on profile name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
       testRunner.When("I Edit First Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 148
       testRunner.Then("Edited First Name should be updated in First Name section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Last Name")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditLastName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Last Name", ((string[])(null)));
#line 151
this.ScenarioSetup(scenarioInfo);
#line 152
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 153
       testRunner.And("I click on profile name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
       testRunner.When("I Last First Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 155
       testRunner.Then("Edited Last Name should be updated in Last Name section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Profile Photo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditProfilePhoto()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Profile Photo", ((string[])(null)));
#line 157
this.ScenarioSetup(scenarioInfo);
#line 158
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 159
       testRunner.And("I click on photo edit tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
       testRunner.When("I change photo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 161
       testRunner.Then("Changed photo should display on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Edit Location")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Add Profile")]
        public virtual void EditLocation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Location", ((string[])(null)));
#line 163
this.ScenarioSetup(scenarioInfo);
#line 164
       testRunner.Given("I click on profile tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 165
       testRunner.And("I click on Location Edit tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
       testRunner.When("I Edited Location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 167
       testRunner.Then("Edited Location should be listed on Profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

