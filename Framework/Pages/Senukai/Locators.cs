namespace Framework.Pages.Senukai
{
    public class Locators
    {
        internal class FrequentlyAskedQuestionsSection
        {
            internal static string fieldDUK = "//*[@class='site-top__menu-left-link' and @href='https://www.senukai.lt/faq']";
            internal static string inputSearchQuestion = "//*[@class='select2-selection select2-selection--multiple']";
            internal static string givenSelectionField = "//*[@class='select2-results__options']/li[@data-select2-id='10']";
            internal static string sectionHowToCancelTheOrder = "//*[@class='faq-question__title']";
        }
        internal class OrderSearch
        {
            internal static string fieldOrderInformation = "//*[@class='site-top__menu-left-link' and @href='/order_search']";
            internal static string inputOrderNumber = "//*[@class='string required form-control' and @name='order_number']";
            internal static string inputEmail = "//*[@class='string email required form-control' and @name='email']";
            internal static string buttonCheck = "//*[@class='main-button button-full-width button-size-lg' and @type='submit']";
            internal static string outputMessage = "//*[@class='error-message']";
        }
    }
}
