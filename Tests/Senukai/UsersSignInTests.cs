using Framework.Pages.Senukai;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Senukai
{
    internal class UsersSignInTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            UsersSignIn.Open();
        }

        [Test]
        public void UserEntersInvalidEmail()
        {
            string valueEmail = "invalidEmail";
            string expectedMessageBelowEmailField = "nerastas";

            UsersSignIn.ClickIconRegisterLogin();
            UsersSignIn.ClickButtonSignIn();
            UsersSignIn.ClickFieldForgotPassword();
            UsersSignIn.InsertEmail(valueEmail);
            UsersSignIn.ClickButtonRemind();

            string actualMessageBelowEmailField = UsersSignIn.GetMessageBelowEmailFieldOutput();

            Assert.AreEqual(expectedMessageBelowEmailField, actualMessageBelowEmailField);
            Assert.IsTrue(UsersSignIn.CheckIfEmailFieldBorderIsRed());
        }
    }
}
