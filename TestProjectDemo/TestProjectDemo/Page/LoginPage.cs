using OpenQA.Selenium;
using TestProjectDemo.Driver;

namespace TestProjectDemo.Page
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        IWebElement FullName => driver.FindElement(By.Id("name"));
        IWebElement Password => driver.FindElement(By.Id("password"));
        IWebElement ButtonLogin => driver.FindElement(By.Id("login"));

        public void Login(string username, string password)
        {

            FullName.SendKeys(username);
            Password.SendKeys(password);
            ButtonLogin.Submit();

        }
    }
}
