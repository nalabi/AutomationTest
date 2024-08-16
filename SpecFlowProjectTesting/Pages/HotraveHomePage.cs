using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowProjectTesting.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectTesting.Pages
{
    public class HotraveHomePage:BasePage
    {
        public HotraveHomePage() { }

        [FindsBy(How = How.CssSelector, Using = "//a[@routerlink='/'][contains(.,'My Hot Rave')]")]
        public IWebElement Hotravetext { get; set; }
     
    }
}
