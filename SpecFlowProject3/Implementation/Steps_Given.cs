using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;
using TechTalk.SpecFlow.UnitTestProvider;

namespace SpecFlowProject3.Implementation
{
    [Binding]
    public class Steps_Given
    {
        private ScenarioContext _scenarioContext;

        public Steps_Given(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            var productQuantities = table.CreateSet<ProductQuantities>();
            _scenarioContext.Add(ContextConstants.PRODUCTQUANTITIES, productQuantities);
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(int productId)
        {
            var testingProduct = ((IEnumerable<ProductQuantities>)_scenarioContext[ContextConstants.PRODUCTQUANTITIES]).FirstOrDefault(t => int.Parse(t.ProductID) == productId);
            _scenarioContext.Add(ContextConstants.TESTINGPRODUCT, testingProduct);

        }
    }
}
