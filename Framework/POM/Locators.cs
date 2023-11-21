

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
            internal static string ClickSiustiProblemaPerziurejimui = "//*[@class='web_ui__Button__button web_ui__Button__filled web_ui__Button__medium web_ui__Button__primary web_ui__Button__truncated']";
            internal static string GetSearchTitleTitle = "(//*[@data-testid='catalog-search-delete-button--text'])[2]";
        }

        internal class ProductCatalogue
        {
            internal static string ClickButtonVaikams = "//*[@data-testid='nav-tab-1193']";
            internal static string ClickButtonKudykiuIrVaikuPrieziura = "//*[@data-testid='category-item-1500--content']";
            internal static string ClickButtonkudykiuNesynesVaikjuostes = "//*[@data-testid='catalog-item-1674--content']";
            internal static string ClickButtonPrekZenklas = "//*[@data-testid='catalog--brand-filter--trigger']";
            internal static string EnterPrekZenklas = "//*[@id='brand_keyword']";
            internal static string ClickButtonTricot = "//*[@id='brand_ids-list-item-353014']/div[2]";
            internal static string ClickIssaugotiPaieska = "(//*[@data-testid='catalog-search-save-button--text'])[2]";
            internal static string GetLoginTitle = "//*[@class='catalog-search-delete-button--text']";
            internal static string ClickToProduct = "//*[@data-testid='product-item-id-3766261272--overlay-link']";
            internal static string ClickPirkti = "//*[@data-testid='item-buy-button']";
            internal static string GetPurchaseTitle = "//*[@data-testid='purchase']";
        }
    }
}
