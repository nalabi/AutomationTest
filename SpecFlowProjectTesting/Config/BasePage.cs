using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;


namespace SpecFlowProjectTesting.Config
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(TestDriver.Driver, this);
           
        }
    }
}
