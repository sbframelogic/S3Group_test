using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FrontTests3group.PageObject
{
    class AboutPageView : HomePageView
    {
        private IWebDriver driver;
        private IWebElement contentPage;
        public AboutPageView(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public bool i_see_content_page()
        {
            return true;
        }
    }
}
