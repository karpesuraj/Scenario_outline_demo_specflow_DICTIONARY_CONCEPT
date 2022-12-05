using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using Scenario_outline_demo_specflow.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Scenario_outline_demo_specflow.StepDefinitions
{
    [Binding]
    public class LogIn_Steps
    {
        public IWebDriver? driver;
        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.rediff.com/";
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            Console.WriteLine("=========>>>>   i m in ThenClickOnLoginLink() method  ");
                       driver.FindElement(By.LinkText("Sign in")).Click();
        }

        [When(@"User enter credentials")]
        public void WhenUserEnterCredentials(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
           
            var test = dictionary["Username"];

            driver.FindElement(By.Name("login")).SendKeys(dictionary["Orderid"]);
            driver.FindElement(By.Name("passwd")).SendKeys(dictionary["Productid"]);
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            Console.WriteLine("========>Click on the LogIn button================");
            //driver.FindElement(By.Name("proceed")).Click();
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("========>User LogOut from the Application================");
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            //This Checks that if the LogOut button is displayed
            // true.Equals(driver.FindElement(By.XPath(".//*[@id='account_logout']/a")).Displayed);
            Console.WriteLine("========>Successful LogIN message should display================");
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            Console.WriteLine("========>Successful LogOut message should display================");
        }
    }
}

