Feature: WishlistforMyself
	As a registered user 
	I want to click on Wishlist category
	So that I can create a Wishlist for myself

@mytag
Scenario: Create Wishlist for Myself
	Given I navigate to site https://www.qa.giftrete.com/
	##When I click on sign in button
	##And I enter email address "1990eze@gmail.com"
	##And I enter password "Example"
	##And I click on Remember me button
	##And I press sign in button
	##When I click on Wishlist 
	##And I click on Create New List
	##And I click on Myself
	##And I enter Wishlist Name/Occassion
	#When I click on Calendar
	##And I select event date from displayed Calender
	##And I enter Wishlist Description
	#And I click on Save Wishlist button
	#Then Created successfully message is displayed


	Scenario: Create Wishlist for Myself2
	Given I navigate to site https://www.qa.giftrete.com/
	When I click on Wishlist Resource
	And I click on Create Wishlist
	And I enter email address "1990eze@gmail.com"
	And I enter password "Example"
	And I click on Remember me button
	And I press sign in button
	And I click on Myself
	And I enter Wishlist Name/Occassion
	#When I click on Calendar
	And I select event date from displayed Calender
	And I enter Wishlist Description
	#And I click on Save Wishlist button
	#Then Created successfully message is displayed
