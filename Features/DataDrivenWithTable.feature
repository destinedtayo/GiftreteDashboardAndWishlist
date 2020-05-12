Feature: DataDrivenWithTable
	In order to repeat my data or to be able to Login
	I want to add my data to the feature file


@mytag
Scenario: Validate Form With Table
	Given I navigate to site "https://www.qa.giftrete.com"
	When I click on sign in button
	And  I enter email address and password 
	#When I click on Remember me button
	#And I press sign in button

	| Email					| Password  |
	| 1990eze@gmail.com		| Example	|

