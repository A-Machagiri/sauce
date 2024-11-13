using TechTalk.SpecFlow;
using PageObjects.Login;

[Binding]
public class LoginSteps
{
    private LoginPage_Actions _loginPageActions;

    public LoginSteps(LoginPage_Actions loginPageActions)
    {
        _loginPageActions = loginPageActions;
    }

    [Given("I am on the login page")]
    public void GivenIAmOnTheLoginPage()
    {
        // Navigate to login page
    }

    [When("I enter valid credentials")]
    public void WhenIEnterValidCredentials()
    {
        _loginPageActions.EnterUsername("standard_user");
        _loginPageActions.EnterPassword("secret_sauce");
        _loginPageActions.ClickLoginButton();
    }

    [When("I enter invalid credentials")]
    public void WhenIEnterInvalidCredentials()
    {
        _loginPageActions.EnterUsername("locked_out_user");
        _loginPageActions.EnterPassword("secret_sauce");
        _loginPageActions.ClickLoginButton();
    }

    [Then("I should be redirected to the products page")]
    public void ThenIShouldBeRedirectedToTheProductsPage()
    {
        // Check redirection
    }

    [Then("I should see an error message")]
    public void ThenIShouldSeeAnErrorMessage()
    {
        var errorMessage = _loginPageActions.GetErrorMessage();
        Assert.IsTrue(errorMessage.Contains("error"));
    }
}