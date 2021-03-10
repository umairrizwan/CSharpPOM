using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UIAutomation.BaseClass;
using UIAutomation.PageObjects;

namespace UIAutomation.Testscripts
{
    [TestFixture]
    class HomeTest : Base
    {      

        [Test]
        public void clickOnItem()
        {
            ExtentTest test= extent.CreateTest("Test").Info("Test Started");
            var loginPage = new Login(driver);       
            
            var homePage = loginPage.login();
            var itemPage = homePage.clickOnProduct();
            var items= itemPage.getitemName();
            var itemPrice = itemPage.getItemPrice();

            //Assertions
            Assert.AreEqual("Sauce Labs Backpack", items,"Item name not found");
            Assert.AreEqual("$29.99", itemPrice,"Item price is not matched");
            test.Log(Status.Pass);

        }

        
    }
}
