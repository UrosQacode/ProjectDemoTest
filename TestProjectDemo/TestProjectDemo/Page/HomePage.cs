using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestProjectDemo.Driver;

namespace TestProjectDemo.Page
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public void SelectCountry(string Text)
        {
            SelectElement Country = new SelectElement(driver.FindElement(By.Id("country")));
            Country.SelectByText(Text);

        }
        public IWebElement Adress => driver.FindElement(By.Id("address"));
        public IWebElement Email => driver.FindElement(By.Id("email"));     
        public IWebElement Phone => driver.FindElement(By.Id("phone"));
        public IWebElement SaveButton => driver.FindElement(By.Id("save"));
        public IWebElement LogoutButton => driver.FindElement(By.Id("logout"));
        public IWebElement SaveText => driver.FindElement(By.ClassName("tp-saved"));






    }
}




