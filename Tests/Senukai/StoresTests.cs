using Framework.Pages.Senukai;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Senukai
{
    internal class StoresTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Stores.Open();
        }

        [Test]
        public void UserSelectsCityWhereTheStoresAreLocated()
        {
            string expectedCitySection = "Šiauliai";

            Stores.ClickIconRetailsChain();
            Stores.ClickArrow();
            Stores.ClickFieldSiauliai();
            Stores.ClickButtonFind();

            string actualCitySection = Stores.GetCitySectionOutput();

            Assert.AreEqual(expectedCitySection, actualCitySection);
        }
    }
}
