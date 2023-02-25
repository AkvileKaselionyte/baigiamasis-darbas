namespace Framework.Pages.Senukai
{
    public class Stores
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.senukai.lt/");
        }

        public static void ClickIconRetailsChain()
        {
            Common.ClickElement(Locators.Stores.iconRetailsChain);
        }

        public static void ClickArrow()
        {
            Common.ClickElement(Locators.Stores.buttonArrow);
            Common.WaitForElementToBeVisible(Locators.Stores.citiesDropdownList);
        }

        public static void ClickFieldSiauliai()
        {
            Common.ClickElement(Locators.Stores.fieldCitySiauliai);
        }

        public static void ClickButtonFind()
        {
            Common.ClickElement(Locators.Stores.buttonFind);
        }

        public static string OutputCitySection()
        {
            return Common.GetElementText(Locators.Stores.fieldWithCityInformation);
        }

    }
}
