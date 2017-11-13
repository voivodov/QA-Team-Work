using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumDemo
{
    [TestClass]
    public class Tests
    {
        private IWebDriver Driver;

        [TestInitialize]
        public void OpenBrowser()
        {
            this.Driver = new ChromeDriver();
        }
        [TestMethod]
        public void Register()
        {
            this.Driver.Navigate().GoToUrl("http://store.demoqa.com/wp-login.php?action=register");
            Thread.Sleep(6000);
            Driver.FindElement(By.Id("user_login")).SendKeys(Faker.Internet.UserName());

            Driver.FindElement(By.Id("user_email")).SendKeys(Faker.Internet.Email());

            Driver.FindElement(By.Id("wp-submit")).Click();
        }

        [TestMethod]
        public void Rate()
        {
            this.Driver.Navigate().GoToUrl("http://store.demoqa.com/products-page/product-category/");
            Thread.Sleep(3001);
            Driver.FindElement(By.CssSelector("div.rater-0:nth-child(3) > a:nth-child(1)")).Click();
            Driver.FindElement(By.CssSelector("div.rater-1:nth-child(5) > a:nth-child(4)")).Click();
            Driver.FindElement(By.CssSelector("div.rater-2:nth-child(4) > a:nth-child(2)")).Click(); 

        }
        [TestCleanup]
        public void CloseBrowser()
        {
            this.CloseBrowser();
        }
    }
}
