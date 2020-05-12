using GiftreteWishlist.PageObjects;
using NUnit.Framework;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;
using System.Threading;

namespace GiftreteWishlist.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        [When(@"I click on Wishlist Resource")]
        public void WhenIClickOnWishlistResource()
        {
            automationLoginpage.WishlistResource();
        }

        [When(@"I click on Create Wishlist")]
        public void WhenIClickOnCreateWishlist()
        {
            automationLoginpage.CreateWishlist();
        }


        [When(@"I enter wrong password ""(.*)""")]
        public void WhenIEnterWrongPassword(string wrongpassword)
        {
            automationLoginpage.WrongPassword(wrongpassword);
        }

        AutomationLoginpage automationLoginpage;

        public LoginSteps()
        {
            automationLoginpage = new AutomationLoginpage();
        }

        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            automationLoginpage.NavigateToGiftrete(url);
        }

        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            automationLoginpage.SIGNIN();
        }

        [When(@"I enter email address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            automationLoginpage.EmailAddress(email);
        }

        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automationLoginpage.Password(password);
        }

        [When(@"I click on Remember me button")]
        public void WhenIClickOnRememberMeButton()
        {
            automationLoginpage.RememberMe();
        }

        [When(@"I press sign in button")]
        public void WhenIPressSignInButton()
        {
            automationLoginpage.SignIn();
        }

        [Then(@"I am logged in and my user homepage is displayed")]
        public void ThenIAmLoggedInAndMyUserHomepageIsDisplayed()
        {
            Assert.True(automationLoginpage.IsUserHomepageDisplayed());//Nunit 
           //Assert.AreEqual(Displayed, automationLoginpage.Displayed());
        }

         [Then(@"the error message ""(.*)""")]
         public void ThenTheErrorMessage(string errorMessage)
         {
            automationLoginpage.GetTextForError();
            Assert.AreEqual(errorMessage, automationLoginpage.GetTextForError());
            errorMessage.Should().Be(automationLoginpage.GetTextForError()); //FluentAssertion
        }


        [When(@"I click on a friend option")]
         public void WhenIClickOnAFriendOption()
         {
             automationLoginpage.ClickAFriendOption();
         }


         [When(@"I select friend from drop down list")]
         public void WhenISelectFriendFromDropDownList()
        {
             automationLoginpage.SelectFriendFromDropdown();
        }

        [When(@"I click on account detail tab")]
        public void WhenIClickOnAccountDetailTab()
        {
            automationLoginpage.ClickAcctDetailTab();
        }

        [When(@"I click on the edit details")]
        public void WhenIClickOnTheEditDetails()
        {
            automationLoginpage.ClickEditDetails();
        }

        [When(@"I click tittle dropdown")]
        public void WhenIClickTittleDropdown()
        {
            automationLoginpage.TitleDropdown();
        }

        [When(@"I select tittle from dropdown box")]
        public void WhenISelectTittleFromDropdownBox()
        {
            automationLoginpage.SelectTittleFromDropdownBox();
        }

        [When(@"I edit first name")]
        public void WhenIEditFirstName()
        {
            automationLoginpage.EditFirstName();
        }

        [When(@"I edit last name")]
        public void WhenIEditLastName()
        {
            automationLoginpage.EditLastName();
        }

        [When(@"I edit date of birth")]
        public void WhenIEditDateOfBirth()
        {
            automationLoginpage.EditDateOfBirth();
        }

        [When(@"I edit email address")]
        public void WhenIEditEmailAddress()
        {
            automationLoginpage.EditEmailAddress();
        }

        [When(@"I click on phone country code Icon")]
        public void WhenIClickOnPhoneCountryCodeIcon()
        {
            automationLoginpage.PhoneCountryCodeClick();
        }

        [When(@"I select new country code")]
        public void WhenISelectNewCountryCode()
        {
            automationLoginpage.SelectNewCountryCode();
        }

        [When(@"I edit phone number")]
        public void WhenIEditPhoneNumber()
        {
            automationLoginpage.EditMobileNumber();
        }

        [When(@"I edit about text box")]
        public void WhenIEditAboutTextBox()
        {
            automationLoginpage.EditAboutTxtBox();
        }

        [When(@"I click to select Yes or No from community activity emails")]
        public void WhenIClickToSelectYesOrNoFromCommunityActivityEmails()
        {
            automationLoginpage.ClickToSelectYes();
        }

        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            automationLoginpage.ClickSubmitButtonForChange();
        }

        [When(@"a successful message display ""(.*)""")]
        public void WhenASuccessfulMessageDisplay(string p0)
        {

        }

        [Then(@"I click on close button")]
        public void ThenIClickOnCloseButton()
        {
            automationLoginpage.ClickCloseButton();
        }


    }
}
