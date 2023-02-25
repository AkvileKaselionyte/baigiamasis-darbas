﻿using Framework.Pages.Senukai;
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
        public void UserEnterQuestionInSearchField()
        {
            string valueInputQuestion = "kada gausiu savo užsakymą?";
            string expectedGetOutputField = "Kada gausiu savo užsakymą? Kaip žinoti kada gausiu savo užsakymą?";

            FrequentlyAskedQuestionsSection.ClickFieldDUK();
            FrequentlyAskedQuestionsSection.ClickFieldSearchQuestion();
            FrequentlyAskedQuestionsSection.EnterQuestion(valueInputQuestion);
            FrequentlyAskedQuestionsSection.ClickTheSelectionFieldInDropdownList();

            string actualGetSection = FrequentlyAskedQuestionsSection.GetOutputSection();

            Assert.AreEqual(expectedGetOutputField, actualGetSection);
        }
    }
}