//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Scenario_outline_demo_specflow.StepDefinitions
//{
//    [Binding]
//     public class Login_step_definition
//    {
//        public IWebDriver? driver;
//        [Given(@"User is at the Home Page")]
//        public void GivenUserIsAtTheHomePage()
//        {
//            driver = new ChromeDriver();
//            Console.WriteLine("=========>>>>   i m in WhenEnterTheUrl() method  ");
//            String test_url = "https://www.rediff.com/";
//            driver.Url = test_url;
//        }

//        [Given(@"Navigate to LogIn Page")]
//        public void GivenNavigateToLogInPage()
//        {
//            Console.WriteLine("=========>>>>   i m in ThenClickOnLoginLink() method  ");
//            driver.FindElement(By.LinkText("Sign in")).Click();
//        }

//        [When(@"User enter (.*) and (.*)")]
//        public void WhenUserEnterAnd(string username, string password)
//        {
//            //Console.WriteLine("=========>>>>   i m in ThenEnterUsernameInUsernameField() method  ");
//            driver.FindElement(By.Name("login")).SendKeys(username);
//            //  Console.WriteLine("=========>>>>   i m in ThenEnterPasswordInPasswordField() method  ");
//            driver.FindElement(By.Name("passwd")).SendKeys(password);
//        }

//        [When(@"Click on the LogIn button")]
//        public void WhenClickOnTheLogInButton()
//        {
//            driver.FindElement(By.Name("proceed")).Click();
//        }

//        [When(@"User LogOut from the Application")]
//        public void WhenUserLogOutFromTheApplication()
//        {
//            Console.WriteLine(" i m in logout1 method ");
//        }

//        [Then(@"Successful LogIN message should display")]
//        public void ThenSuccessfulLogINMessageShouldDisplay()
//        {
//            //This Checks that if the LogOut button is displayed
//            //true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
//            Console.WriteLine(" Successful LogIN message should display ");
//        }

//        [Then(@"Successful LogOut message should display")]
//        public void ThenSuccessfulLogOutMessageShouldDisplay()
//        {
//            Console.WriteLine(" i m in logout method ");
//           // driver.Close();
//        }
//    }
//}
    

