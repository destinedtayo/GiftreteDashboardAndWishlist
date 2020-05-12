Feature:Registration
	In order to use Giftrete website
	I want to test the Wishlist platform of the site
	Which has a lot of element i will be automating in future

@mytag 
Scenario:Valid Registration
	Given I navigate to site https://www.qa.giftrete.com/
	#When I click on CREATE ACCOUNT
	When I click on GET STARTED FOR FREE
	And I click on Register Button on Top
	And I enter First Name
	And I enter Last Name
	And I enter Email Address "Email"
	When I click to select country code
	And I select United Kingdom as country
	And I enter Mobile Number
	And I enter Password "mysecurePassword"
	And I Confirm Password "mysecurePassword"
	And I click to Register
	#Then I am registered and "Thank you for signing up! You may now login" is displayed


	Scenario:Invalid Registration
	Given I navigate to site https://www.qa.giftrete.com/
	#When I click on CREATE ACCOUNT
	When I click on GET STARTED FOR FREE
	And I click on Register Button on Top
	And I enter First Name
	And I enter Last Name
	And I enter Email Address "Email"
	When I click to select country code
	And I select United Kingdom as country
	And I enter Mobile Number
	And I enter Password "mysecurePassword"
	And I Confirm Wrong Password "mysecurePassword1"
	And I click to Register
	Then error message "The Confirm Password field does not match the Password field."