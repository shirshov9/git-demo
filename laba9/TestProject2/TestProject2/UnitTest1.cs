using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace lab9._2
{
    public class Tests
    {
        [Test]
        public void ICanWin()
        {
            WebDriver driver = new ChromeDriver("C:\\webdriver\\chromedriver.exe");
            driver.Url = "https://aldebaran.ru/";

            driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div[2]/ul/li[2]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[2]/div/div/div[1]/ul[2]/li[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[2]/div/div/div[2]/ul/li[1]/div/div/div[2]/p[2]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[2]/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/div/div[3]/div[1]/button")).Click();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Quit();
        }
    }
}