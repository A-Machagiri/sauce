using OpenQA.Selenium;

namespace Utilities.WebUtilities.Web_Utilities
{
    public class WebUtilities
    {
        private IWebDriver _driver;

        public WebUtilities(IWebDriver driver)
        {
            _driver = driver;
        }

        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void EnterText(string element, string text, string elementType)
        {
            if(elementType == "id")
            {
                _driver.FindElement(By.Id(element)).SendKeys(text);
            }
            else if(elementType == "name")
            {
                _driver.FindElement(By.Name(element)).SendKeys(text);
            }
        }

        public void Click(string element, string elementType)
        {
            if(elementType == "id")
            {
                _driver.FindElement(By.Id(element)).Click();
            }
            else if(elementType == "name")
            {
                _driver.FindElement(By.Name(element)).Click();
            }
        }
    }
}