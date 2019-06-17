Feature: AddEducation
	In order to update profiel 
	i have to add an eduction 

@mytag
Scenario: Check if user is able to add Education 
	Given I am on the profiel page  
	When I click on the Education Tab
	Then I click on add new tab
	And  I add all the details 
	Then I click on button to add education 
	Then Education should be added 
