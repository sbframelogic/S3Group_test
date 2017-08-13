using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrontTests3group.PageObject
{
    class CareersPageView :HomePageView
    {
        //simply driver for home page
        private IWebDriver driver;

        //conntent Search for Jobs form
        private IWebElement search_job_input;
        private IWebElement search_job_button;

        public CareersPageView(IWebDriver driver) :base(driver)
        {
            this.driver = driver;
        }

        public bool i_see_search_job_input()
        {
            return true;
        }
        public bool set_job_name_input(String name)
        {
            return true;
        }
        public  bool i_see_button_job_input()
        {
            return true;
        }
        public bool click_button_job_input()
        {
            return true;
        }

        public bool check_result_find_job(String name)
        {
            return true;
        }




    }
}
