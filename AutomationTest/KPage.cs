using AutomationTest.BaseClass;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutomationTest
{
    internal  class KPage: BasePage
    {
        [FindsBy(How = How.XPath,Using = "//div//span[contains(text(),'Resources')]")]
        public IWebElement linkTest { get; set; }

        [FindsBy(How = How.XPath, Using = "//a//span[contains(text(),'White Papers & eBooks')]")]
        public IWebElement pLink { get; set; }



        [FindsBy(How = How.LinkText, Using = "UCITS White Paper")]
        public IWebElement whitePaper { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231669pi_18882_231669")]
        public IWebElement fName { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231669pi_18882_231669")]
        public IWebElement inputFName { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231671pi_18882_231671")]
        public IWebElement lName { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231671pi_18882_231671")]
        public IWebElement inputlName { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231675pi_18882_231675")]
        public IWebElement Company { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231675pi_18882_231675")]
        public IWebElement Com { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231677pi_18882_231677")]
        public IWebElement industry { get; set; }

        [FindsBy(How = How.Name, Using = "18882_231677pi_18882_231677")]
        public IWebElement indus { get; set; }


        public void FillTheFields()
        {
            fName.Click();
            inputFName.SendKeys("test");  
            lName.Click();  
            inputlName.SendKeys("tester");  
            Company.Click();    
            Com.SendKeys("Kurtosys");
            industry.Click();
            indus.SendKeys("ICT");
           

        }
    }

    
}
