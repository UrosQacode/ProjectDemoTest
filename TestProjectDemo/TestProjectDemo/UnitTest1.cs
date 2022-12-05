using TestProjectDemo.Driver;
using TestProjectDemo.Page;

namespace TestProjectDemo
{
    public class Tests
    {

        private LoginPage loginPage;
        private HomePage homePage;
        [SetUp]
        public void BeforeScenario()


        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            homePage = new HomePage();
        }
        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.CleanUp();
        }


        [Test]
        public void TC01_FillTestFormWithValidData_AllDataShouldBeDisplayedInHomePage()
        {
            loginPage.Login("Uros", "12345");


            homePage.SelectCountry("Serbia");
            homePage.Adress.SendKeys("BGD");
            homePage.Email.SendKeys("uros@gmail.com");
            homePage.Phone.SendKeys("+38163757312");
            homePage.SaveButton.Click();
            homePage.LogoutButton.Click();

           

        }
    }
}