using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutomation.BaseClass;
using UIAutomation.PageObjects;

namespace UIAutomation.Testscripts
{
    [TestFixture]
    public class LoginTest : Base
    {
       
        [Test]
        public void LogintoHomePage()
        {
            var loginObject = new Login(driver);
            var homepage = loginObject.login();
            var title= homepage.verifyhometitle();
            Assert.AreEqual("Swag Labs", title);
        }
    }
}
