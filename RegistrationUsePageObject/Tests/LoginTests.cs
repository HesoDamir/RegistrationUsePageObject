﻿
using RegistrationUsePageObject.TestHelper;
using NUnit.Framework;
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
            string name = "testic";
            string phone = "82222332222";

            loginHelper.
                DoLogin(email, name, phone);
        }
    }
}
