using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace BaseObjectInit.Framework
{
    public class BaseObject
    {
        public static IWebDriver driver;
        public static string baseUrl = "http://www.freshdoc.ru";

        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            PageFactory.InitElements(driver, pageClass);
        }
    }
}
