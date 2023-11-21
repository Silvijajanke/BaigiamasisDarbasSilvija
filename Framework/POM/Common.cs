﻿using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;

namespace Framework.POM
{
    internal class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        
        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeysToElement(string locator,string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static string GetLoginTitle(string getLoginTitle)
        {
            return GetElement(getLoginTitle).Text;
        }
    }
}
