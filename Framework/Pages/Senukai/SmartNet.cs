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

        public static bool GetSmartNetCardNumbersOutput()
        {
            string attributeClassValue = Common.GetAttributeValue(Locators.SmartNet.outputSmartNetCardNumbers, "value");

            if (attributeClassValue.Contains("9440381500"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
