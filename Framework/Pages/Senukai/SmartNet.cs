namespace Framework.Pages.Senukai
{
    public class SmartNet
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.senukai.lt/");
        }

        public static void ClickFieldSmartNet()
        {
            Common.ScrollToElement(Locators.SmartNet.fieldSmartNet);
            Common.ClickElement(Locators.SmartNet.fieldSmartNet);
        }

        public static void ClickFieldBecomeSmartNetMember()
        {
            Common.ClickElement(Locators.SmartNet.fieldBecomeSmartNetMember);
        }

        public static void ClickAlreadyHavePlasticCard()
        {
            Common.ClickElement(Locators.SmartNet.clickAlreadyHavePlasticCard);
        }

        public static string GetSmartNetCardFieldNameOutput()
        {
            return Common.GetElementText(Locators.SmartNet.outputSmartNetCardFieldName);
        }

        public static string GetSmartNetCardNumbersOutput()
        {
            return Common.GetAttributeValue(Locators.SmartNet.outputSmartNetCardNumbers, "value");
        }
    }
}
