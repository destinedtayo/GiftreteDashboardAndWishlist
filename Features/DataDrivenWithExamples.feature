Feature: DataDrivenWithExamples
	In order to repeat my data or to be able to update my data from feature file
	I want to add my data to the feature file

@mytag
	Scenario: Login with valid user details
	Given I navigate to site "https://www.qa.giftrete.com/"
	When I click on sign in button
	And I enter email address "<Email>"
	And I enter password "<Password>"
	When I click on Remember me button
	When I press sign in button
	Then I am logged in


Examples:
	|Email				| Password      |
	|1990eze@gmail.com	| Example		|
	|1990eze1@gmail.com	| Example2		|
