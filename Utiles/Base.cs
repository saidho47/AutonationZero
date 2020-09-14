using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutonationFirst.Utiles
{
    public class Base
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www2.qaautonation.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();

        }
    }
}
