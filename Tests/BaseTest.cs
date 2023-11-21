using Framework;
using Framework.POM;
using NUnit.Framework;
using System;


namespace Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Login.Open();
            //System.Threading.Thread.Sleep(1000);
            //Framework.POM.Login.CloseWhereDoYouLive();
            System.Threading.Thread.Sleep(1000);
            Framework.POM.Login.ClickButtonDeclineCookies();
            System.Threading.Thread.Sleep(1000);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
