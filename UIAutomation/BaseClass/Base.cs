using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomation.BaseClass
{
    public class Base
    {
       public ExtentReports extent = null;
        public static IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Malta\source\repos\UIAutomation\UIAutomation\ExtentReport\report.html");
            extent.AttachReporter(htmlReporter);
           
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
            extent.Flush();
        }

    }
}
