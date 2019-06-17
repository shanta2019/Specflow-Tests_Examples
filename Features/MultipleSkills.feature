Feature: MultipleSkills
	In sell my skill I need to add multiple 
	skills to my profiel

@mytag
Scenario Outline: Check if user can add multiple skills in profiel
	Given I have clicked on the profiel tab and add new skill tab
	When I enetered skill details <Skill> and <Level>
	And I click add button
	Then Skills should be added to the profiel
Examples: 
        | Skill      | Level    |
        | C Language | Beginner |
        | Java       | Beginner |
        | Selenium   | Beginner |
        | Jmeter     | Beginner |
        | SOAP UI    | Beginner |
        | Postman    | Beginner |
