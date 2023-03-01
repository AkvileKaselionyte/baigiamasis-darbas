using Framework.Pages.Senukai;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Senukai
{
    internal class SmartNetTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            SmartNet.Open();
        }

        [Test]
        public void SmartNetFieldAndCardNumbersCheckTest()
        {
            string expectedSmartNetFieldName = "SMART NET kortelės numeris";
            string expectedCardNumber = "9440381500";

            SmartNet.ClickFieldSmartNet();
            SmartNet.ClickFieldBecomeSmartNetMember();
            SmartNet.ClickAlreadyHavePlasticCard();

            string actualSmartNetFieldName = SmartNet.GetSmartNetCardFieldNameOutput();
            string actualCardNumber = SmartNet.GetSmartNetCardNumbersOutput();

            Assert.AreEqual(expectedSmartNetFieldName, actualSmartNetFieldName);
            Assert.AreEqual(expectedCardNumber, actualCardNumber);
        }
    }
}
