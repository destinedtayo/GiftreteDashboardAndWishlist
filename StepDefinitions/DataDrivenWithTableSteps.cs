using GiftreteWishlist.PageObjects;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GiftreteWishlist.StepDefinitions
{
    [Binding]
    public class DataDrivenWithTableSteps
    {
        DataTablePage dataTablePage;

        public DataDrivenWithTableSteps()
        {
            dataTablePage = new DataTablePage();
        }

        [When(@"I enter email address and password")]
        public void WhenIEnterEmailAddressAndPassword(Table table)
        {
            var emailandPassword = table.CreateInstance<Details>();

            string email = emailandPassword.Email;
            string password = emailandPassword.Password;

            dataTablePage.EnterEmailandPassword(email, password);
        }

    }
}
