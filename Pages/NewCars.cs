using AutonationFirst.Utiles;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutonationFirst.Pages
{

    public class NewCars : Stale
    {

        By logoHome = By.CssSelector("img#headerLogoHomeImage");
        By Shop = By.CssSelector("a#headerPrimaryItem_1");
        By Sell = By.CssSelector("a#headerPrimaryItem_2");
        By Service = By.CssSelector("a#headerPrimaryItem_3");
        By Offer = By.CssSelector("a#headerPrimaryItem_4");
        By Financing = By.CssSelector("a#headerPrimaryItem_5");
        By SearchBox = By.CssSelector("input#js-typeahead-inventory");
        By Cash = By.CssSelector("input#cash");
        By MinPrice = By.CssSelector("select#MinPriceDropDown");
        By MaxPrice = By.CssSelector("select#MaxPriceDropDown");



        public NewCars(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void SellButton()
        {
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(Financing)).Build();
            act.MoveToElement(driver.FindElement(Offer)).Build();
            act.MoveToElement(driver.FindElement(Service)).Build();
            act.MoveToElement(driver.FindElement(Sell)).Build();
            act.MoveToElement(driver.FindElement(Shop)).Build().Perform();
        }
        public void CashCars()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Click(By.CssSelector("a#headerEntryUrl_0"));
            SelectElement PriceMin = new SelectElement(driver.FindElement(MinPrice));
            PriceMin.SelectByValue("15K");
            SelectElement PriceMax = new SelectElement(driver.FindElement(MaxPrice));
            PriceMax.SelectByValue("25K");
            IWebElement LabelNew = driver.FindElement(By.CssSelector("label#input-stocktype-new-label"));
            Assert.IsFalse(LabelNew.Selected, "new Cars");
            IWebElement LabelCertf = driver.FindElement(By.CssSelector("label#input-stocktype-cpo-label"));
            LabelCertf.Click();
            Assert.IsFalse(LabelCertf.Selected, "Certified Cars");
            Click(By.CssSelector("span#panelLabel-make"));
            Thread.Sleep(2000);
            Click(By.CssSelector("input#bmw"));
            Click(By.CssSelector("input#toyota"));
            Click(By.CssSelector("input#volkswagen"));
            Click(By.CssSelector("span#panelLabel-exteriorgenericcolor"));
            Click(By.CssSelector("label#input-exteriorgenericcolor-silver-label"));
            Click(By.CssSelector("label#input-exteriorgenericcolor-black-label"));
            Click(By.CssSelector("label#input-exteriorgenericcolor-white-label"));
        }
        public void SelectACare()
        {
           // string priceone = driver.FindElement(By.CssSelector("div#srp-tile-lockedprice-0")).Text;
           // Console.WriteLine(priceone);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            for (int i = 0; i < 24 ; i++)
            {
                string partXpthOne = "//div[contains(@id,'";
                string partXpthTwo = "')]";
                Console.WriteLine(driver.FindElement(By.XPath(partXpthOne + i + partXpthTwo)).Text);
            }
        }
    }
        }
    
    
