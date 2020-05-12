using FluentAssertions;
using GiftreteWishlist.PageObjects;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace GiftreteWishlist.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        Automation_Registrationpage automation_Registrationpage;
        public RegistrationSteps()
        {
            automation_Registrationpage = new Automation_Registrationpage();
        }

        [Given(@"I navigate to site https://www\.qa\.giftrete\.com/")]
        public void GivenINavigateToSiteHttpsWww_Qa_Giftrete_Com()
        {
            automation_Registrationpage.NavigateToGiftrete();
        }


        [When(@"I click on CREATE ACCOUNT")]
        public void WhenIClickOnCREATEACCOUNT()
        {
            automation_Registrationpage.EnterCREATEACCOUNT();
        }

        [When(@"I click on GET STARTED FOR FREE")]
        public void WhenIClickOnGETSTARTEDFORFREE()
        {
            automation_Registrationpage.GetStartedForFree();
        }

        [When(@"I click on Register Button on Top")]
        public void WhenIClickOnRegisterButtonOnTop()
        {
            automation_Registrationpage.RegisterButtonOnTop();
        }

        [When(@"I enter First Name")]
        public void WhenIEnterFirstName()
        {
            automation_Registrationpage.FirstName();
        }
        
        [When(@"I enter Last Name")]
        public void WhenIEnterLastName()
        {
            automation_Registrationpage.LastName();
        }

        [When(@"I enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            automation_Registrationpage.EmailAddress(email);
        }

        [When(@"I click to select country code")]
        public void WhenIClickToSelectCountryCode()
        {
            automation_Registrationpage.CountryCode();
        }


        [When(@"I select United Kingdom as country")]
        public void WhenISelectUnitedKingdomAsCountry()
        {
            automation_Registrationpage.SelectUnitedKingdomAsCountry();
        }


        [When(@"I enter Mobile Number")]
        public void WhenIEnterMobileNumber()
        {
            automation_Registrationpage.MobileNumber();
        }

        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            automation_Registrationpage.Password(password);
        }

        [When(@"I Confirm Password ""(.*)""")]
        public void WhenIConfirmPassword(string password)
        {
            automation_Registrationpage.ConfirmPassword(password);
        }

        [When(@"I Confirm Wrong Password ""(.*)""")]
        public void WhenIConfirmWrongPassword(string wrongPassword)
        {
            automation_Registrationpage.ConfirmWrongPassword(wrongPassword);
        }
 
        [When(@"I click to Register")]
        public void WhenIClickToRegister()
        {
            automation_Registrationpage.RegisterButton();
        }

        [Then(@"I am registered and ""(.*)"" is displayed")]
        public void ThenIAmRegisteredAndIsDisplayed(string thenIAmRegistered)
        {
            Thread.Sleep(5000);
            automation_Registrationpage.GetTextForMessage();
            //Assert.AreEqual(theMessage, automation_Registrationpage.GetTextForMessage()); //Nunit
            thenIAmRegistered.Should().Be(automation_Registrationpage.GetTextForMessage()); //FluentAssertion
            //theMessage.Should().Contain("Your account is successfully activated. You may login now");

            //automation_Registrationpage.GetTextForMessage().Should().Contain("Your account is successfully activated. You may login now");
        }



        [Then(@"error message ""(.*)""")]
        public void ThenErrorMessage(string errorMessage)
        {
            Thread.Sleep(5000);
            automation_Registrationpage.GetTextForError();

            //Assert.AreEqual(errorMessage, automation_Registrationpage.GetTextForError()); //Nunit

            errorMessage.Should().Be(automation_Registrationpage.GetTextForError()); //FluentAssertion
            //errorMessage.Should().Contain("The email address is already used, please login instead or click this link to reset your password: Forget Password");

            //automation_Registrationpage.GetTextForError().Should().Contain("The email address is already used, please login instead or click this link to reset your password: Forget Password");
        }


    }
}
