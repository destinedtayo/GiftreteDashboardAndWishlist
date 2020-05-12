	Feature: GiftreteProfileForm
	In order to manage my Giftrete account details
	I want to be able to edit my personal information

@mytag
Scenario: Valid View To Change Giftrete Profile Form 
	Given I navigate to site "https://www.qa.giftrete.com/"
	When I click on sign in button
	And I enter email address "Email"
	And I enter password "Password"
	And I click on Remember me button
	And I press sign in button
	And I click on account detail tab
	And I click on the edit details
	And I click tittle dropdown
	And I select tittle from dropdown box
	And I edit first name
	And I edit last name
	And I edit date of birth
	And I edit email address
	And I click on phone country code Icon
	And I select new country code
	And I edit phone number
	And I edit about text box
	And I click to select Yes or No from community activity emails
	And I click on submit button
	#And a successful message display "User details saved successfully" 
	Then I click on close button