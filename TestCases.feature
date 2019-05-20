Feature: Add Profile
       In order to get seen by employer
       I want to set up profile

@mytag
Scenario: Add Language
       Given I click on profile tab
       And I click on language tab
       When I add new language 
       Then language should be listed under languages tab

Scenario: Add Skills
       Given I click on profile tab
       And I click on skills tab
       When I write new skill
	   And I select skill level
       Then skill should be listed under skills tab

Scenario: Add Education
       Given I click on profile tab
       And I click on Education tab
       When I write all the details of Education
	   And I click on add button
       Then Education should be listed under Education tab

Scenario: Add Certifications
       Given I click on profile tab
       And I click on Certifications tab
       When I add all Certification details
	   And I click add button
       Then Certification should be listed under Certifications tab

Scenario: Add Description
       Given I click on profile tab
       And I click on Description tab
       When I add Description
       Then   Description should be listed under on Profile

Scenario: Add Availability
       Given I click on profile tab
       And I click on Availability tab
       When I select Availability
       Then Availability should be listed in Availability section

Scenario: Add Hours
       Given I click on profile tab
       And I click on Hours tab
       When I select Hours
       Then Hours should be listed in Hours section

Scenario: Add Earn Targets
       Given I click on profile tab
       And I click on Earn Targets tab
       When I add Earn Targets
       Then Earn Targets should be listed in Earn Targets section

Scenario: Add Profile Photo
       Given I click on profile tab
       And I click on upload photo tab
       When I upload photo from computer
       Then Uploaded photo should display on Profile page

Scenario: Add Location
       Given I click on profile tab
       And I click on Location tab
       When I select preferred Location
       Then Location should be listed on Profile page
	   
	   
Scenario: Edit Description
       Given I click on profile tab
       And I click on existing Description record edit tab
       When I edit Description
       Then edited Description should be updated under Description tab

Scenario: Edit Language
       Given I click on profile tab
       And I click on existing language record edit tab
       When I edit language level
       Then edited language level should be updated under level tab

Scenario: Delete Language
       Given I click on profile tab
       And I click on existing language record delete tab
       When I delete language
       Then deleted language should be removed from languages listing

Scenario: Edit Skill
       Given I click on profile tab
       And I click on existing skill record edit tab
       When I edit skill level
       Then edited skill level should be updated under level tab

Scenario: Delete Skill
       Given I click on profile tab
       And I click on existing skill record delete tab
       When I delete skill
       Then deleted skill should be removed from skills listing

 Scenario: Edit Education
       Given I click on profile tab
       And I click on existing Education record edit tab
       When I edit Degree 
       Then edited Degree should be updated under Degree tab

Scenario: Delete Education
       Given I click on profile tab
       And I click on existing Education record delete tab
       When I delete Education
       Then deleted skill should be removed from skills listing


Scenario: Edit Certification
       Given I click on profile tab
       And I click on existing Certification record edit tab
       When I edit Certificate 
       Then edited Certificate should be updated under Certification tab


Scenario: Delete Certification
       Given I click on profile tab
       And I click on existing Certification record delete tab
       When I delete Certification
       Then deleted certificate should be removed from Certificates listing

Scenario: Edit Availability
       Given I click on profile tab
       And I click on Edit Availability tab
       When I Edit Availability
       Then Edited Availability should be updated in Availability section

Scenario: Edit Hours
       Given I click on profile tab
       And I click on Edit Hours tab
       When I Edit Hours
       Then Edited Hours should be updated in Hours section

Scenario: Edit Earn Targets
       Given I click on profile tab
       And I click on Edit Earn Targets tab
       When I Edit Earn Targets
       Then Edited Earn Targets should be updated in Earn Targets section

Scenario: Edit First Name
       Given I click on profile tab
       And I click on profile name
       When I Edit First Name
       Then Edited First Name should be updated in First Name section


Scenario: Edit Last Name
       Given I click on profile tab
       And I click on profile name
       When I Last First Name
       Then Edited Last Name should be updated in Last Name section

Scenario: Edit Profile Photo
       Given I click on profile tab
       And I click on photo edit tab
       When I change photo
       Then Changed photo should display on Profile page

Scenario: Edit Location
       Given I click on profile tab
       And I click on Location Edit tab
       When I Edited Location
       Then Edited Location should be listed on Profile page
	   
	  


