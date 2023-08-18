using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace packageReference.Main.Base
{
    [TestFixture]
    public class BaseClass
    {
        public IWebDriver driver;
        string url = "http://localhost:8888";

        [SetUp]
        public void SetUP()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver=new ChromeDriver();
        }
        [Test]
        public void Test()
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
