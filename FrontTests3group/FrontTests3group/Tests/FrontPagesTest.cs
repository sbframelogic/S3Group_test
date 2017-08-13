using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FrontTests3group.PageObject;
using FrontTests3group.MenuObject;
using FrontTests3group.ModalWindows;
namespace FrontTests3group.Tests
{
    [TestFixture]
    class FrontPagesTest
    {
        private RemoteDriver remoeteDriver;

        [SetUp]
        public void RunBeforeAnyTests()
        {
            remoeteDriver = new RemoteDriver("https://www.s3group.com/", "chrome");
        }

       [Test]
        public void HomePageTest01()
        {
            TestContext.WriteLine("Start the test for home page");
            HomePageView homePage = new HomePageView(remoeteDriver.get_driver());
            Assert.IsTrue(homePage.i_see_home_page(), "I dont see home page content");
            Assert.IsTrue(homePage.i_see_Link_About(), "I dont see About link from menu");
            Assert.IsTrue(homePage.i_see_Link_Careers(), "I dont see Careers link from menu");
            Assert.IsTrue(homePage.i_see_Link_News_Event(), "I dont see News Event link from menu");
            Assert.IsTrue(homePage.i_see_Link_Our_Businesses(), "I dont see Our_Businesses link from menu");
            Assert.IsTrue(homePage.i_see_Link_search(), "I dont see Search link from menu");
            Assert.IsTrue(homePage.i_see_link_login(), "I dont see LogIn link from menu");
            Assert.IsTrue(homePage.i_see_link_Sing_Up(), "I dont see LogIn link from menu");
            Assert.IsTrue(homePage.close_cookie());
            TestContext.WriteLine("End the test");


        }
       [Test]
        public void Menu_Our_BusinessesTest02()
        {
            TestContext.WriteLine("Start the test for link Our_Businesses");
            HomePageView homePage = new HomePageView(remoeteDriver.get_driver());
            homePage.click_Link_Our_Businesses();
            Assert.IsTrue(homePage.i_see_Link_About(), "I dont see About link from menu");
            Assert.IsTrue(homePage.i_see_Link_Careers(), "I dont see Careers link from menu");
            Assert.IsTrue(homePage.i_see_Link_News_Event(), "I dont see News Event link from menu");
            Assert.IsTrue(homePage.i_see_Link_Our_Businesses(), "I dont see Our_Businesses link from menu");
            Assert.IsTrue(homePage.i_see_Link_search(), "I dont see Search link from menu");
            Assert.IsTrue(homePage.i_see_link_login(), "I dont see LogIn link from menu");
            Assert.IsTrue(homePage.i_see_link_Sing_Up(), "I dont see LogIn link from menu");
            TestContext.WriteLine("End test");
        }
        [Test]
        public void Menu_Our_BusinessesTest03()
        {
            TestContext.WriteLine("Start the test for link Our_Businesses");
            MenuOurBusinesses menu = new MenuOurBusinesses(remoeteDriver.get_driver());
            menu.move_mause_to_Our_Businesses();
            Assert.IsTrue( menu.i_see_link_SemiconductorSolutions());
            Assert.IsTrue( menu.click_link_SemiconductorSolutions());
            remoeteDriver.get_driver().Navigate().Back();
            menu.move_mause_to_Our_Businesses();
            Assert.IsTrue(menu.i_see_link_Connected_Health());
            Assert.IsTrue( menu.click_link_Connected_Health());
            TestContext.WriteLine("End test");
        }
        [Test]
        public void Login_from_home_pageTest04()
        {
            TestContext.WriteLine("Start the test for link login user");
            HomePageView homePage = new HomePageView(remoeteDriver.get_driver());
            Assert.IsTrue(homePage.i_see_link_login());
            Assert.IsTrue(homePage.i_see_link_Sing_Up());
            Assert.IsTrue(homePage.click_link_login());
            Login loginmodal = new Login(remoeteDriver.get_driver());
            Assert.IsTrue(loginmodal.set_user_name("bednarz.sebastian@wp.pl"));
            Assert.IsTrue(loginmodal.set_pass("test_11"));
            Assert.IsTrue(loginmodal.click_button_login());
            Assert.IsTrue(loginmodal.close_windows());
            TestContext.WriteLine("End test");

        }
        [Test]
        public void Sing_Up_from_home_pageTest04()
        {
            TestContext.WriteLine("Start the test for Sing_Up user");
            HomePageView homePage = new HomePageView(remoeteDriver.get_driver());
            Assert.IsTrue(homePage.i_see_link_Sing_Up());
            Assert.IsTrue(homePage.click_link_Sing_Up());
            RegisterPageView register = new RegisterPageView(remoeteDriver.get_driver());
            Assert.IsTrue(register.close_cookie());
            Assert.IsTrue(register.set_first_name("Seastian"));
            Assert.IsTrue(register.set_last_name("Bednarz"));
            Assert.IsTrue( register.set_jobtitle("Tester"));
            Assert.IsTrue(register.set_name_company("S3Group"));
            Assert.IsTrue(register.click_link_Register());
            Assert.IsTrue(register.check_error_from_register(),"I dont see error message for validations");
            TestContext.WriteLine("End test");
        }

        [TearDown]
        public void RunAfterAnyTests()
        {
            this.remoeteDriver.close_driver();
        }
    }
}
