using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.POM
{
    public class ProductCatalogue
    {
        public static void ClickButtonKudykiuIrVaikuPrieziura()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickButtonKudykiuIrVaikuPrieziura);
        }

        public static void ClickButtonkudykiuNesynesVaikjuostes()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickButtonkudykiuNesynesVaikjuostes);
        }

        public static void ClickButtonPrekZenklas()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickButtonPrekZenklas);
        }

        public static void ClickButtonTricot()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickButtonTricot);
        }

        public static void ClickButtonVaikams()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickButtonVaikams);
        }

        public static void ClickIssaugotiPaieska()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickIssaugotiPaieska);
        }

        public static void EnterPrekZenklas(object prekZenklas)
        {
            Common.ClickElement(Locators.ProductCatalogue.EnterPrekZenklas);
        }
        public static string GetSearchTitle()
        {
            return Common.GetElementText(Locators.ProductCatalogue.GetPurchaseTitle);
        }
        public static void ClickToProduct()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickToProduct);
        }
        public static void ClickPirkti()
        {
            Common.ClickElement(Locators.ProductCatalogue.ClickPirkti);
        }
        public static string GetPurchaseTitle()
        {
            return Common.GetElementText(Locators.ProductCatalogue.GetPurchaseTitle);
        }
    }
}
