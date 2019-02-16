using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordpressAutomation;

namespace WordpressTests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Admin_User_Can_Login()
        {
            LoginPage.GoTo();
            LoginPage.Login("")
                .WithPassword("password")
                .Login();
            Assert.IsTrue(DashboardPage.isAt, "Failed to login");
        }
    }

}
