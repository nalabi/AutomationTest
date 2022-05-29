using SeleniumExtras.PageObjects;

namespace AutomationTest.BaseClass
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(TestDriver.Driver, this);
        }
    }
}
