

using System;

namespace Framework.POM
{
    public class Login
    {
        public static void ClickButtonDeclineCookies()
        {
            System.Threading.Thread.Sleep(150);
            Common.ClickElement(Locators.Login.ClickButtonDeclineCookies);
        }

        public static void ClickButtonElPastu()
        {
            Common.ClickElement(Locators.Login.ClickButtonElPastu);
        }

        public static void ClickButtonRegistruotis()
        {
            Common.ClickElement(Locators.Login.ClickButtonRegistruotis);
        }

        public static void ClickButtonRegistruotisPrisijungti()
        {
            Common.ClickElement(Locators.Login.ClickButtonRegistruotisPrisijungti);
        }

        public static void ClickTesti()
        {
            Common.ClickElement(Locators.Login.ClickTesti);
        }

        public static void CloseWhereDoYouLive()
        {
            Common.ClickElement(Locators.Login.CloseWhereDoYouLive);
        }

        public static void EnterElPastasArbaVartotojoVardas(string ElPastas)
        {
            Common.SendKeysToElement(Locators.Login.EnterElPastasArbaVartotojoVardas, ElPastas);
        }

        public static void EnterSlaptazodis(string slaptazodis)
        {
            Common.SendKeysToElement(Locators.Login.EnterSlaptazodis, slaptazodis);
        }

        public static void Open ()
        {
            Driver.OpenPage("https://www.vinted.lt");
        }
        public static string GetLoginTitle()
        {
            return Common.GetElementText(Locators.Login.GetLoginTitle);
        }
    }
}
