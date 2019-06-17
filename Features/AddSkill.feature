Feature: AddSkill
	In order to update my profiel i have to add skills 

@mytag
Scenario: Check if user is able to add a skill
	Given I am on the profiel page and I have clicked on the skill tab
	When I click on Add New button
	Then  I entered the skill 
	Then I click on add button
    Then the skill should be added on my profiel
