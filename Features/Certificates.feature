Feature: Certificates
	In orderto update profile
	I have to add certifications

@mytag
Scenario: Check if user can add certification 
	Given I am logged in and on the profiel pag  
	When I click on the CertificationsTab
	Then I click on the add new tab
	And  I add all the details of certification 
	Then I click on add button to add the certification 
	Then Certification should be added 