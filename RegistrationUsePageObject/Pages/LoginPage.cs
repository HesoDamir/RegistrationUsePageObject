using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using BaseObjectInit.Framework;



namespace RegistrationUsePageObject.Pages
{
    public class LoginPage : BaseObject
    {
        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        public IWebElement emailTextField;

        [FindsBy(How = How.XPath, Using = "//input[@type='text']")]
        public IWebElement nameTextField;

        [FindsBy(How = How.XPath, Using = "//input[@type='tel']")]
        public IWebElement phoneTextField;

        [FindsBy(How = How.CssSelector, Using = "p.qd-overlay-auth__choose > label.qd-overlay-auth__checkbox")]
        public IWebElement agreeCheckBox;

        [FindsBy(How = How.CssSelector, Using = "button.DD-button.qd-button_auth.DD-button__action-target > span.DD-button__caption")]
        public IWebElement openWindowLogin;

        [FindsBy(How = How.XPath, Using = "//button[@title='На весь экран']")]
        public IWebElement fullscreenButton;

        [FindsBy(How = How.CssSelector, Using = "div.qd-overlay-auth__content > button.button.expand.secondary.qd-overlay-auth__button")]
        public IWebElement signInButton;

        [FindsBy(How = How.CssSelector, Using = "div.qd-overlay-auth__content > button.button.expand.secondary.qd-overlay-auth__button")]
        public IWebElement goToCheckInFormButton;

        [FindsBy(How = How.CssSelector, Using = "form.qd-overlay-auth__form > button.expand.qd-overlay-auth__button")]
        public IWebElement checkInButton;

        [FindsBy(How = How.CssSelector, Using = "div.qd-overlay-auth > button.qd-overlay-auth__close")]
        public IWebElement closeInfoWidowButton;

        public static LoginPage GetLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            InitPage(loginPage);
            return loginPage;
        }

        public LoginPage OpenWidndowCheckIn()
        {
            fullscreenButton.Click();
            System.Threading.Thread.Sleep(1000);
            openWindowLogin.Click();
            System.Threading.Thread.Sleep(500);
            signInButton.Click();
            return GetLoginPage();
        }

        public LoginPage TypeEmail(string userName)
        {
            System.Threading.Thread.Sleep(1500);
            emailTextField.Clear();
            emailTextField.SendKeys(userName);
            return GetLoginPage();
        }

        public LoginPage TypeName(string name)
        {
            nameTextField.Clear();
            nameTextField.SendKeys(name);
            return GetLoginPage();
        }

        public LoginPage TypePhone(string phone)
        {
            phoneTextField.Clear();
            phoneTextField.SendKeys(phone);
            return GetLoginPage();
        }

        public LoginPage ActivateCheckboxAgree()
        {
            agreeCheckBox.Click();
            return GetLoginPage();
        }

        public LoginPage ClickCheckInButton()
        {
            checkInButton.Click();
            return GetLoginPage();
        }

        public LoginPage ClickCloseInfoWidowButton()
        {
            System.Threading.Thread.Sleep(500);
            closeInfoWidowButton.Click();
            return GetLoginPage();
        }
    }
}

