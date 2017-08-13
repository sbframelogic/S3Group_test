using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontTests3group
{
    class RemoteDriver
    {
        private IWebDriver driver;
        private String typ_browser;
        public RemoteDriver(String url, String typ_browser)
        {

          
            switch(typ_browser)
            {
                case "firefox":
                    driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
                    break;
                case "chrome":
                    driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                    break;

            }
            driver.Manage().Window.Maximize();
            driver.Url = url;

        }
        public IWebDriver get_driver()
        {
            return driver;
        }
        public void  close_driver()
        {
            driver.Close();
        }
    }
}
