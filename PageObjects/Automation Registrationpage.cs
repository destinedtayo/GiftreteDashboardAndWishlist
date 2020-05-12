using GiftreteWishlist.Hooks;
using GiftreteWishlist.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text;
using System.Collections.Generic;

namespace GiftreteWishlist.PageObjects
{
    class Automation_Registrationpage
    {
        Waits waits = new Waits();

        IWebDriver driver;

        IWebElement cREATEACCOUNT => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));

        IWebElement getStartedForFree => driver.FindElement(By.XPath("/html/body/section[1]/div[3]/div/div/a"));

        IWebElement registerButtonOnTop => driver.FindElement(By.Id("nav-register-tab"));

        IWebElement firstName => driver.FindElement(By.CssSelector("#first_name"));

        IWebElement lastName => driver.FindElement(By.Id("last_name"));

        IWebElement emailAddress => driver.FindElement(By.Id("email"));

        IWebElement countryCode => driver.FindElement(By.CssSelector("#nav-register > form > div:nth-child(4) > div > div > div > div.iti-flag.gb"));

        IWebElement selectUnitedKingdomAsACountry => driver.FindElement(By.CssSelector("#iti-item-gb > span.country-name"));

        IWebElement mobileNumber => driver.FindElement(By.CssSelector("#mobile"));

        IWebElement confirmWrongPassword => driver.FindElement(By.Id("confirm_password"));

        IWebElement confirmPassword => driver.FindElement(By.Id("confirm_password"));

        IWebElement enterPassword => driver.FindElement(By.Name("password"));

        IWebElement registerButton => driver.FindElement(By.CssSelector("#btn_register"));

        IWebElement errorMsg => driver.FindElement(By.CssSelector("#dng_msg > p"));

        IWebElement thenIAmRegistered => driver.FindElement(By.CssSelector("#suc_msg"));

        IWebElement signIn => driver.FindElement(By.Id(""));

        public string GetPageTittle => driver.Title;



        internal void NavigateToSite(string url)
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        public string GetTextForMessage()
        {
            //return waits.MyDriverWait(driver, theMessage).Text;
            return waits.WaitForElement(driver, thenIAmRegistered).Text;
        }

        public string GetTextForError()
        {
            return waits.WaitForElement(driver, errorMsg).Text;
            //IWebDriver myDriver = driver; (to be used later)
            //return waits.MyDriverWait(driver, errorMsg).Text;
        }

        public void EnterCREATEACCOUNT()
        {
            cREATEACCOUNT.Click();
        }

        public void GetStartedForFree()
        {
            getStartedForFree.Click();
        }

        public void RegisterButtonOnTop()
        {
            registerButtonOnTop.Click();
        }

        public void FirstName()
        {
            firstName.SendKeys("Tayo");
        }

        public void LastName()
        {
            lastName.SendKeys("Ojo");
        }

        public void SignIn()
        {
            signIn.Click();
        }
        

        public void EmailAddress(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailAddress.SendKeys("1990eze" + randomInt + "@gmail.com");
        }

        public void CountryCode()
        {
            countryCode.Click();
        }

        public void SelectUnitedKingdomAsCountry()
        {
            //SelectElement select = new SelectElement(country);
            //select.SelectByValue("United Kingdom");
            selectUnitedKingdomAsACountry.Click();
        }

        public void MobileNumber()
        {
            mobileNumber.SendKeys("07400123456");
        }

        public void Password(string password)
        {
            enterPassword.SendKeys("mysecurePassword");
        }

        public void ConfirmPassword(string password)
        {
            confirmPassword.SendKeys("mysecurePassword");
        }

        public void ConfirmWrongPassword(string wrongpassword)
        {
            confirmWrongPassword.SendKeys("mysecurePassword1");
        }

        public void RegisterButton()
        {
            waits.WaitForElement(driver, registerButton).Click();
            //registerButton.Click();
        }

        public Automation_Registrationpage()
        {
            driver = Hook.driver;
        }

        public void NavigateToGiftrete()
        {
            driver.Navigate().GoToUrl("https://www.qa.giftrete.com/");
        }

    }
}
