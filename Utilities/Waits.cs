using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteWishlist.Utilities
{
    public class Waits
    {
        public IWebElement WaitForElement(IWebDriver driver, IWebElement element)
        {

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            if (fluentWait.Until(XPathLookupException => element.Displayed))
            //return fluentWait.Until(XPathLookupException => element.Displayed) ? element : null;
            return element;
            else
                return null;

        }

            //DefaultWait`1.ThrowTimeoutException(String exceptionMessage, Exception lastException)
            //DefaultWait`1.Until[TResult] (Func`2 condition)

        public IWebElement MyDriverWait(IWebDriver driver, IWebElement element)
        {
            bool elementIsDisplayed = false;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) =>
            {
                elementIsDisplayed = element.Displayed;
                return element.Displayed;
            });
            wait.Until(waitForElement);
            if (elementIsDisplayed)
                return element;
            else
                return null;


        }



    }


    }