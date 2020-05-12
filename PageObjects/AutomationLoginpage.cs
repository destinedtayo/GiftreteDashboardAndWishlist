using GiftreteWishlist.Hooks;
using GiftreteWishlist.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace GiftreteWishlist.PageObjects
{
    class AutomationLoginpage
    {
        IWebDriver driver;

        Waits waits = new Waits();

        IWebElement sIGNIN => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[3]"));

        IWebElement emailAddress => driver.FindElement(By.Id("user_email"));

        IWebElement enterPassword => driver.FindElement(By.Id("user_password"));

        IWebElement signIn => driver.FindElement(By.Id("btn_signin"));

        IWebElement loggedIn => driver.FindElement(By.CssSelector("#content > div > div > div > div > div"));

        IWebElement errorMsg => driver.FindElement(By.Id("dng_msg_t"));

        IWebElement enterWrongPassword => driver.FindElement(By.Id("user_password"));

        IWebElement rememberMe => driver.FindElement(By.Id("store_session"));

        IWebElement wishlist => driver.FindElement(By.CssSelector("#mywhishlist > div.d-flex.justify-content-start > span > p.main-font.no-mrg.color--black.font-weight-500"));

        IWebElement createNewList => driver.FindElement(By.CssSelector("#content > div.page-content-inner > div > div > div > div > div > div > div.d-flex-col.bg--white.width-73.sm-width-100.mt-sm--10 > div.d-flex-col.align-items-center.pt--100 > a"));

        IWebElement myself => driver.FindElement(By.CssSelector("#create-wishlist > div > div.switch-field > label:nth-child(2)"));

        IWebElement wishlistNameOccassion => driver.FindElement(By.Id("name"));

        //IWebElement calendar => driver.FindElement(By.CssSelector("#example2 > div > i"));

        IWebElement dateFromCalendar => driver.FindElement(By.Id("eventdate"));

        IWebElement wishlistDescription => driver.FindElement(By.Id("description"));

        IWebElement wishlistResource => driver.FindElement(By.XPath("/html/body/footer/div/div/article[2]/li[4]/a"));

        IWebElement createWishlist => driver.FindElement(By.XPath("/html/body/section[2]/div[2]/div/div/div/div/a[1]"));

        IWebElement clickAFriendOption => driver.FindElement(By.CssSelector("#create-wishlist > div > div.switch-field > label:nth-child(4)"));

        IWebElement selectFriendFromDropdown => driver.FindElement(By.Id("friend_id"));

        IWebElement userHomepageElement => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div[1]/div/div[2]/h2/span"));

        IWebElement acctDetailTab => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/ul/a[2]"));

        IWebElement editDetails => driver.FindElement(By.Id("lnk_edit_personal"));

        IWebElement titleDropdown => driver.FindElement(By.Id("name_prefix"));

        IWebElement selectTittleFromDropdownBox => driver.FindElement(By.XPath("//*[@id='name_prefix']/option[3]"));

        IWebElement editFirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));

        IWebElement editLastName => driver.FindElement(By.XPath("//*[@id='last_name']"));

        IWebElement editDateOfBirth => driver.FindElement(By.XPath("//*[@id='dateofbirth']"));

        IWebElement editEmailAddress => driver.FindElement(By.Id("email"));

        IWebElement phoneCountryCodeClick => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div/div/div/div/form[1]/div[6]/div/div/div/div[3]"));

        IWebElement selectNewCountryCode => driver.FindElement(By.CssSelector("#iti-item-ng > span.country-name"));

        IWebElement editMobileNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));

        IWebElement editAboutTxtBox => driver.FindElement(By.XPath("//*[@id='about']"));

        IWebElement selectYes => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/div[1]/div/div/div/div/form[1]/div[8]/div[2]/label[1]"));

        IWebElement submitButtonForChange => driver.FindElement(By.Id("btn_save_details"));

        IWebElement closeButton => driver.FindElement(By.CssSelector("#btn_cancel"));

        public void CheckErrorMessageIsDisplayed()
        {
            Assert.IsTrue(errorMsg.Displayed);
        }


        public string GetTextForError()
        {
            IWebDriver myDriver = driver;
            //return waits.WaitForElement(driver, errorMsg).Text;
            return waits.MyDriverWait(driver, errorMsg).Text;
        }

        public bool IsUserHomepageDisplayed()
        {
            return userHomepageElement.Displayed;
        }

        public void SelectFriendFromDropdown()
        {
            selectFriendFromDropdown.Click();
        }

        public void ClickAFriendOption()
        {
            clickAFriendOption.Click();
        }

        public void SIGNIN()
        {
            sIGNIN.Click();
        }

        public void RememberMe()
        {
            rememberMe.Click();
        }

        public void EmailAddress(string email)
        {
            emailAddress.SendKeys("1990eze@gmail.com");
        }

        public void Password(string password)
        {
            enterPassword.SendKeys("Example");
        }

        public void WrongPassword(string wrongpassword)
        {
            enterWrongPassword.SendKeys("Example1");
        }

        public void SignIn()
        {
            signIn.Click();
        }

        public void LoggedIn()
        {
            loggedIn.Click();
        }

        public void Wishlist()
        {
            wishlist.Click();
        }

        public void CreateNewList()
        {
            createNewList.Click();
        }

        public void Myself()
        {
            myself.Click();
        }

        public void WishlistNameOccassion()
        {
            wishlistNameOccassion.SendKeys("Building Donation");
        }

        public void Calendar()
        {
            //calendar.Click();
        }

        public void DateFromCalendar()
        {
            dateFromCalendar.SendKeys("September 30, 2020");
        }

        public void WishlistDescription()
        {
            wishlistDescription.SendKeys("This is towards New Covenant Church Woolwich Building Project");
        }

        public void WishlistResource()
        {
            wishlistResource.Click();
        }

        public void CreateWishlist()
        {
            createWishlist.Click();
        }

        public void ClickAcctDetailTab()
        {
            acctDetailTab.Click();
        }

        public void ClickEditDetails()
        {
            editDetails.Click();
        }

        public void TitleDropdown()
        {
            titleDropdown.Click();
        }

        public void SelectTittleFromDropdownBox()
        {
            selectTittleFromDropdownBox.Click();
        }

        public void EditFirstName()
        {
            editFirstName.Clear();
            editFirstName.SendKeys("Bohn");
        }

        public void EditLastName()
        {
            editLastName.Clear();
            editLastName.SendKeys("Besting -Wilson");
        }

        public void EditDateOfBirth()
        {
            editDateOfBirth.Click();
            editDateOfBirth.SendKeys(Keys.Control + "May 10, 2020");
            editDateOfBirth.SendKeys("May 10, 2020");
        }

        public void EditEmailAddress()
        {
            editEmailAddress.Clear();
            editEmailAddress.SendKeys("kingty4u@gmail.com");

        }

        public void PhoneCountryCodeClick()
        {
            phoneCountryCodeClick.Click();
        }

        public void SelectNewCountryCode()
        {
            //SelectElement select = new SelectElement(selectNewCountryCode);
            //select.SelectByValue("Nigeria");
            //selectNewCountryCode.SendKeys(Keys.Control + "Nigeria +234");
            //selectNewCountryCode.SendKeys("Nigeria +234");
            selectNewCountryCode.Click();
        }

        public void EditMobileNumber()
        {
            editMobileNumber.Clear();
            editMobileNumber.SendKeys("08056119874");
        }

        public void EditAboutTxtBox()
        {
            editAboutTxtBox.Clear();
            editAboutTxtBox.SendKeys("GiftreteWishlist Profile Detail");
        }

        public void ClickToSelectYes()
        {
            selectYes.Click();
        }

        public void ClickSubmitButtonForChange()
        {
            submitButtonForChange.Click();
        }

        public void ClickCloseButton()
        {
            closeButton.Click();
        }


        public AutomationLoginpage()
        {
            driver = Hook.driver;
        }


        public void NavigateToGiftrete(string url)
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/");
        }


    }



}
