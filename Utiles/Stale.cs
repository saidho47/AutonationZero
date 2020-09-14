using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutonationFirst.Utiles
{
    public class Stale
    {
        public IWebDriver driver;

        public bool Click(By by)
        {
            bool status = false;
            int i = 0;
            while (i == 0)
                try
                {
                    driver.FindElement(by).Click();
                    status = true;
                    break;
                }
                catch (StaleElementReferenceException e)
                {
                }
            return status;
        }
    }
}
