Feature: ManageRequest
	

@mytag
Scenario: Manage the profiel Requests
	Given I am on profiel page and clicked on the manage request tab
	When I click on the received request option
	Then I should be navigated to received request page
