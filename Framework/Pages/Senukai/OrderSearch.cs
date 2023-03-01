namespace Framework.Pages.Senukai
{
    public class OrderSearch
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.senukai.lt/");
        }

        public static void ClickFieldOrderInformation()
        {
            Common.ClickElement(Locators.OrderSearch.fieldOrderInformation);
        }

        public static void EnterOrderNumber(string inputOrderNumber)
        {
            Common.SendKeys(Locators.OrderSearch.inputOrderNumber, inputOrderNumber);
        }

        public static void EnterEmail(string inputEmail)
        {
            Common.SendKeys(Locators.OrderSearch.inputEmail, inputEmail);
        }

        public static void ClickButtonCheck()
        {
            Common.ClickElement(Locators.OrderSearch.buttonCheck);
        }

        public static string OutputMessageBelowOrderNumberField()
        {
            return Common.GetElementText(Locators.OrderSearch.outputMessageBelowOrderNumberField);
        }
    }
}
