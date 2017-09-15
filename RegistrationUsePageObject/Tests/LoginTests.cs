using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistrationUsePageObject.TestHelper;
using NUnit.Framework;
using TestingProject.Tests;
using RegistrationUsePageObject.Framework;

namespace TestingProject.Tests
{
    [TestFixture] //тест-сьют
    public class LoginTests : BaseTest
    {
        private static LoginHelper loginHelper = new LoginHelper();

        [Test] //тест-кейс
        public static void AssertLogin()
        {
            string email = "test.qds." + Utils.seed + "@mail.ru";
            string name = "test";
            string phone = "82222222222";

            loginHelper.
                DoLogin(email, name, phone);
        }
    }
}
