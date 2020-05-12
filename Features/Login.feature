Feature: Login
	As a registered user of giftrete.com
	I want to login
	So that I can access wishlist


@mytag
Scenario: Login with valid user details
	Given I navigate to site "https://www.qa.giftrete.com/"
	When I click on sign in button
	And I enter email address "Email"
	And I enter password "Password"
	When I click on Remember me button
	And I press sign in button
	Then I am logged in and my user homepage is displayed


	Scenario: Login with Invalid user details
	Given I navigate to site "https://www.qa.giftrete.com/"
	When I click on sign in button
	And I enter email address "Email"
	And I enter wrong password "WrongPassword"
	When I click on Remember me button
	And I press sign in button
	Then the error message "Your login credentials are invalid. Please try again."



