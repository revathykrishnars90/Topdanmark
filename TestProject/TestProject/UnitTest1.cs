using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace TestProject
{

    public class UnitTest1
    {
        
        public void TC_1_verifyTopDanmarkIsAppearingFirstInSearch()
        {
            ChromeDriver driver = new ChromeDriver();
            INavigation navi =  driver.Navigate();
            navi.GoToUrl("http://google.com");
            IWebElement search = driver.FindElementByName("q");
            search.SendKeys("topdanmark");
            search.Click();
            IWebElement searchButton = driver.FindElementByName("btnK");
            searchButton.Click();
            IWebElement resultsPanel = driver.FindElement(By.Id("search"));
            ReadOnlyCollection<IWebElement> searchResults = resultsPanel.FindElements(By.XPath(".//a"));
            Assert.AreEqual("Topdanmark.com - Topdanmark.com\r\nwww.topdanmark.com/en/", searchResults[0].Text);
            driver.Close();
        }

        
        public void TC_2_verifyAccessibleViaDifferentBrowsers()
        {
            verifyAccessibleVia(new InternetExplorerDriver());
            verifyAccessibleVia(new ChromeDriver());
            verifyAccessibleVia(new FirefoxDriver());
        }

        public void verifyAccessibleVia(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://topdanmark.com");
            driver.FindElement(By.ClassName("logo"));
            driver.Close();
        }
    }
}




























