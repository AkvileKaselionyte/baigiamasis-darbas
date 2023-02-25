using Framework.Pages.Senukai;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Senukai
{
    internal class OrderSearchTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            OrderSearch.Open();
        }

        [Test]
        public void UserEntersInvalidOrderNumberAndValidEmail()
        {
            string valueInputOrderNumber = "invalidOrderNumber";
            string valueInputEmail = "email@gmail.com";
            string expectedMessageBelowOrderNumberField = "neegzistuoja";

            OrderSearch.ClickFieldOrderInformation();
            OrderSearch.EnterOrderNumber(valueInputOrderNumber);
            OrderSearch.EnterEmail(valueInputEmail);
            OrderSearch.ClickButtonCheck();
            string actualGetMessage = OrderSearch.OutputMessageBelowOrderNumberField();

            Assert.AreEqual(expectedMessageBelowOrderNumberField, actualGetMessage);
        }
    }
}
