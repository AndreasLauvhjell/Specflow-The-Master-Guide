using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject3.Implementation
{
    [Binding]
    public class Steps_Then
    {
        private ScenarioContext _scenarioContext;

        public Steps_Then(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = (IEnumerable<ProductQuantities>)_scenarioContext[ContextConstants.PRODUCTQUANTITIES];
            var testingProduct = (ProductQuantities)_scenarioContext[ContextConstants.TESTINGPRODUCT];
            comparisonList = comparisonList.Where(t => t.ProductID == testingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }

        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }
    }
}
