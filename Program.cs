using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace botcomunio
{
    class Program
    {
        static void Main(string[] args)
        {

            IWebDriver web = new ChromeDriver(@"C:\Users\ortiga\Documents\Visual Studio 2017\Projects\botcomunio\packages\Selenium.Chrome.WebDriver.2.31\driver");
            web.Manage().Window.Maximize();
            web.Navigate().GoToUrl("http://www.comunio.es");
            web.FindElement(By.ClassName("userlogin")).SendKeys("????????");
            web.FindElement(By.Name("pass")).SendKeys("????????");
            web.FindElement(By.ClassName("login")).Click();
            web.FindElement(By.LinkText("Mercado de fichajes")).Click();
            web.FindElement(By.LinkText("quitar jugadores del mercado de fichajes")).Click();
            web.FindElement(By.Name("choice[2460]")).Click();
            web.FindElement(By.Name("choice[213]")).Click();
            web.FindElement(By.Name("choice[2085]")).Click();
            web.FindElement(By.Name("choice[2249]")).Click();
            web.FindElement(By.Name("choice[2340]")).Click();
            web.FindElement(By.LinkText("Volver a poner en el mercado de fichajes")).Click();





            web.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.5);
            
            web.Quit();
           
        }
    }
}
