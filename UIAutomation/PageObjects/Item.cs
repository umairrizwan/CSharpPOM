using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomation.PageObjects
{
    public class Item
    {
        IWebDriver driver;
        public Item(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
       
        [FindsBy(How=How.XPath,Using = "//div[@class='inventory_details_name']")]
        IWebElement ItemTitle { get; set; }

        [FindsBy(How=How.XPath, Using = "//div[@class='inventory_details_price']")]
        IWebElement ItemPrice { get; set; }

        public string getitemName()
        {
            return ItemTitle.Text;
        }

        public string getItemPrice()
        {
            return ItemPrice.Text;
        }
    }
}
