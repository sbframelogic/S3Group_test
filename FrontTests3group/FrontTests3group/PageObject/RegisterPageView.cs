using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FrontTests3group.PageObject
{
    class RegisterPageView : HomePageView
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//*[@id='input_2_1_3']")]
        private IWebElement FirstName;
        [FindsBy(How = How.XPath, Using = "//*[@id='input_2_1_6']")]
        private IWebElement LastName;
        [FindsBy(How = How.XPath, Using = "//*[@id='input_2_2']")]
        private IWebElement Company;
        [FindsBy(How = How.XPath, Using = "//*[@id='input_2_3']")]
        private IWebElement JobTitle;
        [FindsBy(How = How.XPath, Using = "//*[@id='gform_submit_button_2']")]
        private IWebElement RegisterButton;


        private IJavaScriptExecutor js;

        public RegisterPageView(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            js = (IJavaScriptExecutor)driver;
        }

        public bool i_see_firstName()
        {
            if (FirstName.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool set_first_name(String name)
        {
            FirstName.SendKeys(name);
            return true;
        }
        public bool i_see_last_name()
        {
            if (LastName.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool click_link_Register()
        {

            this.RegisterButton.Click();
            return true;
        }
        public bool set_last_name(String name)
        {
            LastName.SendKeys(name);
            return true;
          
        }
  
        public bool i_see_company()
        {
            if (Company.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool set_name_company(String company)
        {
            Company.SendKeys(company);
            return true;
        }

        public bool i_see_jobtitle()
        {
            if (JobTitle.Displayed)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public bool set_jobtitle(String job)
        {
            this.JobTitle.SendKeys(job);
            return true;
        }
        public bool check_error_from_register()
        {
            IWebElement error_message = driver.FindElement(By.XPath("//*[@id='gform_2']/div[1]"));
            if (error_message.Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
