using GiftreteWishlist.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Globalization;
using TechTalk.SpecFlow;

namespace GiftreteWishlist.StepDefinitions
{
    [Binding]
    public class WishlistforMyselfSteps
    {
        AutomationLoginpage automationLoginpage;

        public WishlistforMyselfSteps()
        {
            automationLoginpage = new AutomationLoginpage();
        }

        [When(@"I click on Wishlist")]
        public void WhenIClickOnWishlist()
        {
            automationLoginpage.Wishlist();
        }
        
        [When(@"I click on Create New List")]
        public void WhenIClickOnCreateNewList()
        {
            automationLoginpage.CreateNewList();
        }
        
        [When(@"I click on Myself")]
        public void WhenIClickOnMyself()
        {
            automationLoginpage.Myself();
        }
        
        [When(@"I enter Wishlist Name/Occassion")]
        public void WhenIEnterWishlistNameOccassion()
        {
            automationLoginpage.WishlistNameOccassion();
        }


        [When(@"I click on Calendar")]
        public void WhenIClickOnEventDate()
        {
            //automationLoginpage.Calendar();
        }
        
        [When(@"I select event date from displayed Calender")]
        public void WhenISelectEventDateFromDisplayedCalender()
        {
            automationLoginpage.DateFromCalendar();            
        }
        
        [When(@"I enter Wishlist Description")]
        public void WhenIEnterWishlistDescription()
        {
            automationLoginpage.WishlistDescription();
        }
        
        [When(@"I click on Save Wishlist button")]
        public void WhenIClickOnSaveWishlistButton()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Created successfully message is displayed")]
        public void ThenCreatedSuccessfullyMessageIsDisplayed()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
