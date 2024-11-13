using OpenQA.Selenium;
using Utilities.WebUtilities.Web_Utilities;

namespace PageObjects.Login
{
    public partial class LoginPage_Actions
    {
        private WebUtilities _webUtilities;

        public LoginPage_Actions(WebUtilities webUtilities)
        {
            _webUtilities = webUtilities;
        }

        public void EnterUsername(string username)
        {
            _webUtilities._driver.FindElement(By.CssSelector(LoginPage_Locators.UsernameField)).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _webUtilities._driver.FindElement(By.CssSelector(LoginPage_Locators.PasswordField)).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _webUtilities._driver.FindElement(By.CssSelector(LoginPage_Locators.LoginButton)).Click();
        }

        public string GetErrorMessage()
        {
            return _webUtilities._driver.FindElement(By.CssSelector(LoginPage_Locators.ErrorMessage)).Text;
        }
    }
}
