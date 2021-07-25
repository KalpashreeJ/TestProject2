using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using System.Drawing;

namespace TestProject2.StepDefinition
{

    [Binding , Scope(Feature = "PMCEUIfeature")]
  
    class Stepdefintion
    {
        IWebDriver webdriver;

        [Given(@"User Navigates to ""(.*)""")]
        public void GivenUserNavigatesTo(string p0)
        {
            webdriver = new ChromeDriver(@"C:\Users\Kalpashree_J\Downloads\chromedriver_win32 (1)");
            
            webdriver.Manage().Window.Maximize();
            webdriver.Navigate().GoToUrl("http://www.google.com");

            //Screenshot test = ((ITakesScreenshot)webdriver).GetScreenshot();
            //test.SaveAsFile("c:/test.png");
        }

        [When(@"User input text ""(.*)""")]
        public void WhenUserInputText(string p0)
        {
            
        }

        [When(@"User Click on  submit ""(.*)""")]
        public void WhenUserClickOnSubmit(string p0)
        {
            
        }

        [Then(@"the result should be ""(.*)"", closes the browser\.")]
        public void ThenTheResultShouldBeClosesTheBrowser_(string p0)
        {
            webdriver.Close();

        }



    }
}
