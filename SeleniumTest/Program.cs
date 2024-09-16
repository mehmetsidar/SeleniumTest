using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
namespace SeleniumTest
{
	class Programs
	{
		static void Main(String[] args)
		{
			IWebDriver driver = new FirefoxDriver(); // Firefox tarayıcısını başlatmak için bir WebDriver nesnesi oluşturuyor.
			string link = @"https://www.n11.com/"; // Ziyaret edilecek URL'yi belirliyor.
			driver.Navigate().GoToUrl(link); // Belirtilen URL'ye tarayıcı ile gidiyor.

			//driver.FindElement(By.ClassName("btnSignIn")).Click(); // Giriş yap butonuna tıklıyor.
			//driver.FindElement(By.Id("email")).SendKeys("mehmetsidar6@gmail.com"); // E-posta alanına e-posta adresi yazıyor.
			//driver.FindElement(By.Id("password")).SendKeys("asadad"); // Şifre alanına şifreyi yazıyor.
			//driver.FindElement(By.Id("loginButton")).Click(); // Giriş yap butonuna tıklıyor.

			driver.FindElement(By.Id("searchData")).SendKeys("Samsung"); // Arama alanına 'Samsung' kelimesini yazıyor.
			driver.FindElement(By.ClassName("iconsSearch")).Click(); // Arama butonuna tıklayarak arama işlemini başlatıyor.
			driver.FindElement(By.Id("p-600403130")).Click(); // Arama sonuçlarındaki belirli bir ürüne (ID'si 'p-600403130') tıklıyor.
			driver.FindElement(By.ClassName("product-add-cart")).Click(); // Seçilen ürünü sepete eklemek için 'Sepete Ekle' butonuna tıklıyor.

			//driver.FindElement(By.XPath(".//*[@id='listingUl']")).Click(); // Belirtilen XPath'e göre listelenen ürünlere tıklıyor (Yorum satırı).







		}
	}
}