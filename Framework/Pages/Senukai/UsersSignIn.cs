namespace Framework.Pages.Senukai
{
    public class UsersSignIn
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.senukai.lt/");
        }

        public static void ClickIconRegisterLogin()
        {
            Common.ClickElement(Locators.UsersSignIn.iconRegisterLogin);
        }

        public static void ClickButtonSignIn()
        {
            Common.ClickElement(Locators.UsersSignIn.buttonSignIn);
        }

        public static void ClickFieldForgotPassword()
        {
            Common.ClickElement(Locators.UsersSignIn.fieldForgotPassword);
        }

        public static void InsertEmail(string inputEmail)
        {
            Common.SendKeys(Locators.UsersSignIn.inputEmail, inputEmail);
        }

        public static void ClickButtonRemind()
        {
            Common.ClickElement(Locators.UsersSignIn.buttonRemind);
        }

        public static string OutputMessageBelowEmailField()
        {
            return Common.GetElementText(Locators.UsersSignIn.outputMessageBelowEmailField);
        }

        public static bool CheckIfEmailFieldBorderIsRed()
        {
            Common.Wait(500);
            string cssBorderColor = Common.GetCssValue(Locators.UsersSignIn.inputEmail, "border-color");
            if (cssBorderColor == "rgb(255, 0, 0)")
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
