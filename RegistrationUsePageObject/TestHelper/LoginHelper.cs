using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistrationUsePageObject.Pages;
using NUnit.Framework;
using BaseObjectInit.Framework;

namespace RegistrationUsePageObject.TestHelper
{
    public class LoginHelper
    {
        private LoginPage loginPage = new LoginPage();

        public LoginHelper DoLogin(string email, string name, string phone)
        {
            BaseObject.InitPage(loginPage);
            loginPage.
                OpenWidndowCheckIn().
                TypeEmail(email).
                TypeName(name).
                TypePhone(phone).
                ActivateCheckboxAgree().
                ClickCheckInButton().
                ClickCloseInfoWidowButton();
            return this;
        }

    }
}
