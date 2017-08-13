using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrontTests3group.PageObject;
using OpenQA.Selenium;
using System.Threading;
namespace FrontTests3group.MenuObject
{
    class MenuOurBusinesses : HomePageView
    {
        private IWebDriver driver;
        //link from menu from  OurBusinesses
        private IWebElement Link_SemiconductorSolutions;
        private IWebElement Link_Connected_Health;

        public MenuOurBusinesses(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public bool i_see_link_Connected_Health()
        {
            Thread.Sleep(2000);
            Link_Connected_Health = driver.FindElement(By.Id("menu-item-779"));
            return true;
        }
        public bool click_link_Connected_Health()
        {
            Thread.Sleep(2000);
            Link_Connected_Health.Click();
            return true;
        }
        public bool i_see_link_SemiconductorSolutions()
        {
            Thread.Sleep(2000);
            Link_SemiconductorSolutions = driver.FindElement(By.Id("menu-item-778"));
            return true;
        }
        public bool click_link_SemiconductorSolutions()
        {
            Thread.Sleep(2000);
            Link_SemiconductorSolutions.Click();
            return true;
        }
    }
}
