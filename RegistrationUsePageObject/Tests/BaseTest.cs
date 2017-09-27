using NUnit.Framework;
using BaseObjectInit.Framework;
using OpenQA.Selenium.Chrome;

namespace TestingProject
{
    public class BaseTest : BaseObject
    {
        [TestFixtureSetUp] //выполняется перед запуском всех тестов
        public void BeforeClass()
        {
            driver = new ChromeDriver();
        }

        [SetUp] //выполнялся перед запуском каждого теста в текущем тест сьюте 
        public void BeforeTest()
        {
            driver.Navigate().GoToUrl(BaseObject.baseUrl);
            driver.Manage().Window.Maximize();
        }

        //[TearDown]
        //public void AfterTest()
        //{
        //    driver.Close();
        //}

        [TestFixtureTearDown]
        public void AfterClass()
        {
            driver.Quit();
        }
    }
}
