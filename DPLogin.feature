Feature: DPLogin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

	Scenario: Login with valid username and password should able to reach on dashboard
	Given I have entered username 'xxxxxx' into the login page
	And I have entered password 'xxxxxx' into the login page
	When I clicked signIn 
	Then user able to view DeliveryPerformance dashboard