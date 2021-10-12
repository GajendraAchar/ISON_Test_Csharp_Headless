using NUnit.Framework;
using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;
//using NUnit.Framework;

namespace iLearnSample
{
    [TestFixture]
    public class UntitledTestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            //var chromeOptions = new ChromeOptions
            //{
            //    BinaryLocation = @"C:\Users\2-as Aukstas\Documents\Visual Studio 2017\Projects\ChromeTest\ChromeTest\bin\Debug\chromedriver.exe",
            //    DebuggerAddress = "localhost:9222"
            //};

            //chromeOptions.AddArguments(new List<string>() { "headless", "disable-gpu" });

            //var browser = new ChromeDriver(chromeOptions);
            //driver = new ChromeDriver();



            //DesiredCapabilities dc = new DesiredCapabilities();
            //dc.setAcceptInsecureCerts(true);

            //ChromeOptions options = new ChromeOptions();
            //options.addArguments("enable-automation");
            //options.addArguments("--headless");
            //options.addArguments("--window-size=1920,1080");
            //options.addArguments("--no-sandbox");
            //options.addArguments("--disable-extensions");
            //options.addArguments("--dns-prefetch-disable");
            //options.addArguments("--disable-gpu");
            //options.setPageLoadStrategy(PageLoadStrategy.NORMAL);

            //driver = new ChromeDriver(options);


            //var chromeOptions = new ChromeOptions();
            //chromeOptions.AddArguments("headless");
            //chromeOptions.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" });


            //var browser = new ChromeDriver(chromeOptions);
            
                // add your code here
            




            //baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            
            var options = new ChromeOptions();
            options.AddArguments("headless");
            
            using (IWebDriver driver = new ChromeDriver(options))
            {
                Task.Delay(2000);
                driver.Navigate().GoToUrl("https://lmstraining.isonxperiences.com/");
                Task.Delay(20000);
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Login'])[1]//*[name()='svg'][1]")).Click();
                driver.FindElement(By.Id("username")).Click();
                driver.FindElement(By.Id("username")).Clear();
                driver.FindElement(By.Id("username")).SendKeys("brajesh");
                Task.Delay(2000).Wait();
                driver.FindElement(By.Id("password")).Click();
                driver.FindElement(By.Id("password")).Clear();
                driver.FindElement(By.Id("password")).SendKeys("ison12345");
                Task.Delay(2000);
                driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                Task.Delay(1000).Wait();
                driver.FindElement(By.LinkText("Events")).Click();
                Task.Delay(2000);
                driver.FindElement(By.LinkText("Management")).Click();
                Task.Delay(2000);
                driver.FindElement(By.LinkText("L&D Programs")).Click();
                Task.Delay(2000);
                driver.FindElement(By.LinkText("Logout")).Click();
            }
            
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
