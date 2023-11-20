using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    internal class Locators
    {

        internal class Login
        {
            internal static string ClickButtonDeclineCookies = "//*[@id='onetrust-accept-btn-handler']";
            internal static string ClickButtonElPastu = "//*[@data-testid='auth-select-type--login-email']";
            internal static string ClickButtonRegistruotisPrisijungti = "//*[@data-testid='header--login-button']";
            internal static string ClickTesti = "(//*[@class='web_ui__Button__button web_ui__Button__filled web_ui__Button__default web_ui__Button__primary web_ui__Button__truncated'])[2]";
            internal static string CloseWhereDoYouLive = "//*[@data-testid='domain-select-modal-close-button']";
            internal static string EnterElPastasArbaVartotojoVardas = "//*[@id='username']";
            internal static string EnterSlaptazodis = "//*[@id='password']";
            internal static string GetLoginTitle = "//*[@data-testid='recommended_items-header--title']";

        }
        internal class ContactHelpCentre
        {
            internal static string ClickButtonRegistruotisPrisijungti = "//*[@data-testid='header--login-button']";
            internal static string ClickButtonRegistruotis = "//*[@data-testid='auth-select-type--login-switch']";
            internal static string ClickButtonElPastu = "//*[@data-testid='auth-select-type--login-email']";
            internal static string ClickReikiaPagalbos = "//*[@href='/help/103']";
            internal static string ClickRegistrPanaudojauNetinkamaElPastoAdresa = "//*[@data-testid='help-center-question-587--title']";
            internal static string ClickSusisiekSuMumis = "//*[@data-testid='contact-button']";
            internal static string ClickSiustiProblemaPerziurejimui = "//*[@class='web_ui__Button__button web_ui__Button__filled web_ui__Button__medium web_ui__Button__primary web_ui__Button__truncated']"
        }
    }
}
