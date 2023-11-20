using Framework;
using Framework.POM;
using NUnit.Framework;

namespace Tests
{
    public class LoginTest
    {
        internal class LoginScenario : BaseTest
        {
            [Test]
            public void Login()
            {
                string ElPastas = "demo141488";
                string slaptazodis = "Demo881414";

                Framework.POM.Login.ClickButtonRegistruotisPrisijungti();
                Framework.POM.Login.ClickButtonRegistruotis();
                Framework.POM.Login.ClickButtonElPastu();
                Framework.POM.Login.EnterElPastasArbaVartotojoVardas(ElPastas);
                Framework.POM.Login.EnterSlaptazodis(slaptazodis);
                Framework.POM.Login.ClickTesti();
                string actualResult = Driver.GetLoginTitle();
                Assert.That(Driver.GetLoginTitle(), Is.EqualTo("Rekomenduojama tau"));

            }
        }
    }
}
