using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
namespace SeleniumTest
{
	class Programs
	{
		static void Main(String[] args)
		{
			IWebDriver driver = new FirefoxDriver();
			string link = @"https://www.n11.com/";
			driver.Navigate().GoToUrl(link);

			//driver.FindElement(By.ClassName("btnSignIn")).Click();
			//driver.FindElement(By.Id("email")).SendKeys("mehmetsidar6@gmail.com");
			//driver.FindElement(By.Id("password")).SendKeys("asadad");
			//driver.FindElement(By.Id("loginButton")).Click();

			driver.FindElement(By.Id("searchData")).SendKeys("Samsung");
			driver.FindElement(By.ClassName("iconsSearch")).Click();
			driver.FindElement(By.ClassName("lazy cardImage")).Click();

			




		}
	}
}