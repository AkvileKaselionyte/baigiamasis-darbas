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
            internal static string outputMessageBelowOrderNumberField = "//*[@class='error-message']";
        }
        internal class SmartNet
        {
            internal static string fieldSmartNet = "//*[@class='priority-navigation__link' and @href='https://www.senukai.lt/smart_net']";
            internal static string fieldBecomeSmartNetMember = "//*[@class='smart-net-header__button smart-net-header__button--link']";
            internal static string clickAlreadyHavePlasticCard = "//*[@id='user_has_physical_card']";
            internal static string outputSmartNetCardFieldName = "//*[@class='users-session-form__label users-session-form__label--text' and @for='user_physical_card_number']";
            internal static string smartNetCardNumbers = "//*[@id='card_prefix']";
        }
        internal class Stores
        {
            internal static string iconRetailsChain = "//*[@class='icon-svg icon-location site-top__menu-right-icon']";
            internal static string buttonArrow = "//*[@class='select2-selection__arrow']";
            internal static string dropdownList = "//*[@class='select2-results__options']";
            internal static string fieldCitySiauliai = "//*[@class='select2-results__options']/li[text()='Šiauliai']";
            internal static string buttonFind = "//*[@class='button-grey' and @name='button']";
            internal static string fieldWithCityInformation = "//*[@id='Šiauliai']";
        }
        internal class UsersSignIn
        {
            internal static string iconRegisterLogin = "//*[@class='user-block__icon icon-svg']";
            internal static string buttonSignIn = "//*[@class='main-button user-block-dropdown__main-button' and @href='/users/sign_in']";
            internal static string fieldForgotPassword = "//*[@href='/users/password/new']";
            internal static string inputEmail = "//*[@id='user_email']";
            internal static string buttonRemind = "//*[@class='main-button button-full-width button-size-lg']";
            internal static string outputMessageBelowEmailField = "//*[@class='error-message']";
        }
    }
}
