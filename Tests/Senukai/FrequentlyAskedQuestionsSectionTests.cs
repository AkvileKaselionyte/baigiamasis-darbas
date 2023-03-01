using Framework.Pages.Senukai;
using NUnit.Framework;
using Tests.BaseTests;

namespace Tests.Senukai
{
    internal class FrequentlyAskedQuestionsSectionTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            FrequentlyAskedQuestionsSection.Open();
        }


        [Test]
        public void UserEnterQuestionInDUKSearchField()
        {
            string valueInputQuestion = "Kada gausiu savo užsakymą?";
            string expectedGetSection = "Kada gausiu savo užsakymą? Kaip žinoti kada gausiu savo užsakymą?";

            FrequentlyAskedQuestionsSection.ClickFieldDUK();
            FrequentlyAskedQuestionsSection.ClickFieldSearchQuestion();
            FrequentlyAskedQuestionsSection.EnterQuestion(valueInputQuestion);
            FrequentlyAskedQuestionsSection.ClickTheSelectionFieldInDropdownList(expectedGetSection);

            string actualGetSection = FrequentlyAskedQuestionsSection.GetSectionOutput();

            Assert.AreEqual(expectedGetSection, actualGetSection);
        }
    }
}
