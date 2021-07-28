Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers
@SmokeTest
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When i press add
	Then  result should be 120 on the screen.


Scenario: Create a new employee with mandatary details
    #Given I have opened my application.----
    #Then I sholud see employee details page
	When I fill all the mandatory details in form
    |Name   |  Age   | Phone     | Email                         |
    |karthik| 28     | 8956741232| karthik@executeautomation.com |
	|john| 20     | 1556741232| john@executeautomation.com |
	|paul| 32    | 3556741232|paul@executeautomation.com |
    #And I clicked the save button
    #Then I should see all the details saved in my application and DB


Scenario Outline: Create a new employee with mandatary details for different itterations
    #Given I have opened my application.----
    #Then I sholud see employee details page
	When I fill all the mandatory details in form <Name>,<Age> and <Phone>
    #And I clicked the save button
    #Then I should see all the details saved in my application and DB
Examples:  
    |Name   |  Age   | Phone            |
    |karthik| 28     | 8956741232       | 
	|john| 20     | 1556741232          | 
	|paul| 32    | 3556741232           |


