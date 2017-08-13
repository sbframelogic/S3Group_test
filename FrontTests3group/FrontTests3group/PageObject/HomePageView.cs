using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace FrontTests3group.PageObject
{
    class HomePageView
    {

        //simply driver for home page
        private IWebDriver driver;
        //logo S3Group from home page
        [FindsBy(How = How.XPath, Using = "//a[@title='S3 Group']")]
        private IWebElement LogoS3Group;
        // menu links from home page [Our Businesses , Careers ,News & Events,About ,search]
        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-1098']")]
        private IWebElement Link_Our_Businesses;
        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-401']")]
        private IWebElement Link_Careers;
        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-645']")]
        private IWebElement Link_News_Event;
        [FindsBy(How = How.XPath, Using = "//li[@id='menu-item-653']")]
        private IWebElement Link_About;
        [FindsBy(How = How.XPath, Using = "//span[@class='input-group-btn']")]
        private IWebElement Link_search;
        [FindsBy(How = How.XPath, Using = "//a[@title='Sign Up']")]
        private IWebElement Sing_Up;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        private IWebElement Login; ////*[@id="cookie-acceptance"]/button/span/span[1]
        [FindsBy(How = How.XPath, Using = "//*[@id='main-nav']/ul/li[1]/a")]
        private IWebElement Register;

        [FindsBy(How = How.XPath, Using = "//*[@id='cookie-acceptance']/button/span/span[1]")]
        private IWebElement CloseCookie;


        // home page content 
        [FindsBy(How = How.XPath, Using = "//*[@id='middle']//div[@class='hero-unit']")]
        IWebElement contentHome;

      

        public HomePageView(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public bool close_cookie()
        {
            CloseCookie.Click();
            return true;
        }
        public bool  click_link_Register()
        {
           
            this.Register.Click();
            return true;
        }
     
        public bool i_see_link_login()
        {
            if (this.Login.Displayed)
            {
                return true;
            }
            return false;
        }

        public bool click_link_login()
        {
            this.Login.Click();
            return true;
        }

        public bool i_see_link_Sing_Up()
        {
            if (this.Sing_Up.Displayed)
            {
                return true;
            }
            return false;
        }

        public bool click_link_Sing_Up()
        {
            this.Sing_Up.Click();
            return true;
        }

        public bool i_see_home_page()
        {
            if (this.contentHome.Displayed)
            {
                return true;
            }
            return false;
        }
         
        public bool i_see_logo_home_page()
        {
            if (this.LogoS3Group.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool i_see_Link_Our_Businesses()
        {
            if (this.Link_Our_Businesses.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool click_Link_Our_Businesses()
        {
            this.Link_Our_Businesses.Click();
            return true;
        }
        public void move_mause_to_Our_Businesses()
        {
            Thread.Sleep(2000);
            Actions action = new Actions(this.driver);
            action.MoveToElement(this.Link_Our_Businesses).Perform();
        }

        public bool i_see_Link_Careers()
        {
            if (this.Link_Careers.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public bool click_Link_Careers()
        {
            this.Link_Careers.Click();
            return true;
        }
        public bool i_see_Link_News_Event()
        {
            if (this.Link_News_Event.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool click_Link_News_Event()
        {
            this.Link_News_Event.Click();
            return true;
        }
        public bool i_see_Link_About()
        {
            if (this.Link_About.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool click_Link_About()
        {
            this.Link_About.Click();
            return true;
        }
        public bool i_see_Link_search()
        {
            if (this.Link_search.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool click_Link_search()
        {
            this.Link_search.Click();
            return true;
        }
    }
}
