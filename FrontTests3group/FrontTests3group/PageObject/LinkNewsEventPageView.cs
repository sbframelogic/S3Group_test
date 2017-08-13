using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrontTests3group.PageObject
{
    class LinkNewsEventPageView : HomePageView
    {
        //simply driver for home page
        private IWebDriver driver;
        private IWebElement contentPage;
        public LinkNewsEventPageView(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public bool i_see_content_page()
        {
            return true;
        }


    }
}
