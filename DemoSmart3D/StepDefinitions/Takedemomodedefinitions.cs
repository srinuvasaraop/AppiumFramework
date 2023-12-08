using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSmart3D.StepDefinitions
{
    [Binding]
    internal class Takedemomodedefinitions
    {
        [Given(@"I am in '([^']*)' after installing app")]
        public void GivenIAmInAfterInstallingApp(string p0)
        {
            //throw new PendingStepException();
        }

        [When(@"I click on '([^']*)'")]
        public void WhenIClickOn(string p0)
        {
           // throw new PendingStepException();
        }

        [Then(@"Validate the Demo mode Price point prompt will be dispalyed for the first time")]
        public void ThenValidateTheDemoModePricePointPromptWillBeDispalyedForTheFirstTime()
        {
           // throw new PendingStepException();
        }

    }
}
