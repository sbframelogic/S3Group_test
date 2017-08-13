using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace FrontTests3group.ModalWindows
{
    class Login
    {


        private IWebDriver driver;
        private IJavaScriptExecutor js;
        public Login(IWebDriver driver)
        {
            Thread.Sleep(2000);
            this.driver = driver;
            js = (IJavaScriptExecutor)driver;
        }

        public bool set_user_name(String name)
        {
            js.ExecuteScript("$('input[name=log]').val('" + name + "');");
            return true;
        }

        public bool set_pass(String pass)
        {
            js.ExecuteScript("$('input[name=pwd]').val('" + pass + "');");
            return true;
        }

        public bool click_button_login()
        {
            js.ExecuteScript("$('input[name=wp-submit]').click();");
            return true;
        }
        public bool close_windows()
        {
            Thread.Sleep(2000);
            js.ExecuteScript("$('.close').click();");
            return true;
        }
     
    }
}
