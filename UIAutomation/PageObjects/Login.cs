using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomation.PageObjects
{
    public class Login
    {
        IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How=How.Id, Using ="user-name")]
        public IWebElement username { get; set; }

        [FindsBy(How=How.Id,Using ="password")]
        public IWebElement password { get; set; }

        [FindsBy(How=How.Id,Using ="login-button")]
        IWebElement loginBttn { get; set; }

        public Home login()
        {
            username.SendKeys("standard_user");
            password.SendKeys("secret_sauce");
            loginBttn.Click();
            return new Home(driver);
        }
    }
}
