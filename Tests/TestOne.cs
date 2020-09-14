using AutonationFirst.Pages;
using AutonationFirst.Utiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace AutonationFirst.Tests
{
    [TestClass]
    public class TestOne : Base
    {
        
        [Test]
        public void SellTest()
        {
            NewCars LP = new NewCars(driver);
            LP.SellButton();
            LP.CashCars();
            LP.SelectACare();
        }

    }
}
