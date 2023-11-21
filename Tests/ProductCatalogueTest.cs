using Framework;
using NUnit.Framework;
using System;


namespace Tests
{
    internal class ProductCatalogueTest
    {
        internal class SearchScenario : BaseTest
        {
            [TestCase(1)]
            public void Search()
            {
                string ElPastas = "demo141488";
                string slaptazodis = "Demo881414";

                Framework.POM.Login.ClickButtonRegistruotisPrisijungti();
                Framework.POM.Login.ClickButtonElPastu();
                Framework.POM.Login.EnterElPastasArbaVartotojoVardas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickTesti();

                string prekZenklas = "Tricot";
                Framework.POM.ProductCatalogue.ClickButtonVaikams();
                Framework.POM.ProductCatalogue.ClickButtonKudykiuIrVaikuPrieziura();
                Framework.POM.ProductCatalogue.ClickButtonkudykiuNesynesVaikjuostes();
                Framework.POM.ProductCatalogue.ClickButtonPrekZenklas();
                Framework.POM.ProductCatalogue.EnterPrekZenklas(prekZenklas);
                Framework.POM.ProductCatalogue.ClickButtonTricot();
                Framework.POM.ProductCatalogue.ClickIssaugotiPaieska();

                string actualResult = Driver.GetSearchTitle();
                Assert.That(Driver.GetSearchTitle(), Is.EqualTo("Ištrinti Paiešką"));
            }
            [TestCase(2)]
            public void Purchase()
            {
                string ElPastas = "demo141488";
                string slaptazodis = "Demo881414";

                Framework.POM.Login.ClickButtonRegistruotisPrisijungti();
                Framework.POM.Login.ClickButtonElPastu();
                Framework.POM.Login.EnterElPastasArbaVartotojoVardas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickTesti();

                string prekZenklas = "Tricot";
                Framework.POM.ProductCatalogue.ClickButtonVaikams();
                Framework.POM.ProductCatalogue.ClickButtonKudykiuIrVaikuPrieziura();
                Framework.POM.ProductCatalogue.ClickButtonkudykiuNesynesVaikjuostes();
                Framework.POM.ProductCatalogue.ClickButtonPrekZenklas();
                Framework.POM.ProductCatalogue.EnterPrekZenklas(prekZenklas);
                Framework.POM.ProductCatalogue.ClickButtonTricot();
                Framework.POM.ProductCatalogue.ClickToProduct();
                Framework.POM.ProductCatalogue.ClickPirkti();

                string actualResult = Driver.GetPurchaseTitle();
                Assert.That(Driver.GetPurchaseTitle(), Is.EqualTo("Mokėti dabar"));
            }
        }
    }
}
