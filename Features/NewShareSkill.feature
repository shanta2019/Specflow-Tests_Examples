Feature: NewShareSkill
	To check if user is able to add new share skill

@mytag
Scenario: Add New Share Skill
       Given I am on profiel page and I click on Share Skill tab
       When I enetered all the required details 
       Then I Clik on save
       Then Skill should be saved under manage listing tab