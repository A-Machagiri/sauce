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

        // Add methods that wrap IWebDriver functionality here
    }
}