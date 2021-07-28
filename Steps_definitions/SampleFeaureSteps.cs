using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowIntro.Steps_definitions
{
    [Binding]
    class SampleFeaureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine(numbers);
        }

        [When(@"i press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("Pressed Add button");

        }

        [Then(@"result should be (.*) on the screen\.")]
        public void ThenResultShouldBeOnTheScreen_(int result)
        {
            //ScenarioContext.Current.Pending();
            if (result == 120)
                Console.WriteLine("The test FAILED");
            else
            {
                Console.WriteLine("The test Failed");
                throw new Exception("The value is different");

            }
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            //ScenarioContext.Current.Pending();.....
            EmployeeDetails details  = table.CreateInstance<EmployeeDetails>();
            Console.WriteLine(details.Age);
            Console.WriteLine(details.Email);
            Console.WriteLine(details.Name);
            Console.WriteLine(details.Phone);
        }

    }
}
