using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace DemoSmart3D.Hooks
{
    [Binding]
    public class Hooks
    {
       // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        public static AppiumDriver<AndroidElement> driver;
        //      [BeforeTestRun()]
        //public void BeforeTestrun()
        //{
            
        //}
        //[AfterTestRun()]
        //public void AfterTestrun()
        //{
     
        //}
        //[BeforeFeature("@tag1")]
        //public void BeforeFeatureTag()
        //{

        //}
        [BeforeScenario("@tag1")]
        public static void BeforeScenarioWithTag()
        {
            Console.WriteLine("Before Scenario hookseEntered");
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("automationName", "UiAutomator2");
            appiumOptions.AddAdditionalCapability("deviceName", "Android Emulator");
            appiumOptions.AddAdditionalCapability("udid", "10BC9E09UT00094");
            appiumOptions.AddAdditionalCapability("platform Version", "13");
            appiumOptions.AddAdditionalCapability("app", "C:\\AppiumDriver\\dk.resound.smart3d-Signed.apk");
            appiumOptions.AddAdditionalCapability("appPackage", "dk.resound.smart3d");
            //appiumOptions.AddAdditionalCapability("appActivity", "crc646f76f13f64c213ab.WelcomeScreenActivity");
            appiumOptions.AddAdditionalCapability("Appium Server Address", "127.0.0.1:4723");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appiumOptions);
        }
      //  [BeforeScenario(Order = 1)]
        //public void FirstBeforeScenario()
        //{

        //}
        //[BeforeScenarioBlock]
        //public void BeforScenarioBlock()
        //{
 
        //}
        //[AfterScenarioBlock]
        //public void AfterScenarioBlock()
        //{
 
        //}
        //[Before]
        //public void Before()
        //{
  
        //}
        //[After]
        //public void After()
        //{
   
        //}
        //[AfterScenario]
        //public void AfterScenario()
        //{
       
        //}
        //[AfterFeature("@tag1")]
        //public void AfterFeatureTag()
        //{

        //}
    }
}