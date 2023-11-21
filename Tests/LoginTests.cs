using Framework;
using NUnit.Framework;

namespace Tests
{
    public class LoginTests
    {
        internal class LoginScenario : BaseTest
        {
            [Test, Order(1)]
            public void Login()
            {
                string ElPastas = "demo141488";
                string slaptazodis = "Demo881414";

                Framework.POM.Login.ClickButtonRegistruotisPrisijungti();
                Framework.POM.Login.ClickPrisijungti();
                Framework.POM.Login.ClickButtonElPastu();
                Framework.POM.Login.EnterElPastasArbaVartotojoVardas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickTesti();
                string actualResult = Driver.GetLoginTitle();
                Assert.That(Driver.GetLoginTitle(), Is.EqualTo("Rekomenduojama tau"));

            }

            [Test, Order(2)]
            public void ContactHelpCentre()
            {
                Framework.POM.Login.ClickButtonRegistruotisPrisijungti();
                Framework.POM.Login.ClickButtonRegistruotis();
                Framework.POM.Login.ClickButtonElPastu();
                Framework.POM.Login.ClickReikiaPagalbos();
                Framework.POM.Login.ClickRegistrPanaudojauNetinkamaElPastoAdresa();
                Framework.POM.Login.ClickSusisiekSuMumis();
                string actualResult = Driver.GetSiustiProblemaPerziurejimui();
                Assert.That(Driver.GetLoginTitle(), Is.EqualTo("Siųsti problemną peržiūrėjimui"));

            }
        }
    }
}
