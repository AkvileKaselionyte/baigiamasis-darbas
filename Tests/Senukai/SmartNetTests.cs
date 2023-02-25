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
        public void ToTheUserSuccessfullyThrowsSmartNetCardNumbersAndField()
        {
            string expectedSmartNetFieldName = "SMART NET kortelės numeris";

            SmartNet.ClickFieldSmartNet();
            SmartNet.ClickFieldBecomeSmartNetMember();
            SmartNet.ClickAlreadyHavePlasticCard();

            string actualSmartNetFieldName = SmartNet.GetSmartNetCardFieldNameOutput();

            Assert.AreEqual(expectedSmartNetFieldName, actualSmartNetFieldName);
            Assert.IsTrue(SmartNet.GetSmartNetCardNumbersOutput());
        }
    }
}
