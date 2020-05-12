using GiftreteWishlist.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteWishlist.PageObjects
{
    class DataTablePage
    {
        IWebDriver driver;

        IWebElement emailAddress => driver.FindElement(By.Id("user_email"));

        IWebElement enterPassword => driver.FindElement(By.Id("user_password"));

        public DataTablePage()
        {
            driver = Hook.driver;
        }
        public void EnterEmailandPassword(string email, string password)
        {
            emailAddress.SendKeys(email);
            enterPassword.SendKeys(password);
        }

    }
}
