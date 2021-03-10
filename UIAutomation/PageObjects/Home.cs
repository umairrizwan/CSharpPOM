using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomation.PageObjects
{
    public class Home
    {
        IWebDriver driver;
        public Home(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@class='inventory_item_name' and text()='Sauce Labs Backpack']")]
        public IWebElement item { get; set; }

        public string verifyhometitle()
        {
            return driver.Title;
        }

        public Item clickOnProduct()
        {
            item.Click();
            return new Item(driver);
        }
    }
}
