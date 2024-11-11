using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.Implementation
{
    [Binding]
    public class Steps_When
    {
        private ScenarioContext _scenarioContext;

        public Steps_When(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            var testingProduct = (ProductQuantities)_scenarioContext[ContextConstants.TESTINGPRODUCT];

            if (testingProduct.Stock > 0 && testingProduct.Basket == 0)
            {
                testingProduct.Basket++;
                testingProduct.Stock--;
            }

            _scenarioContext[ContextConstants.TESTINGPRODUCT] = testingProduct;
        }
    }
}
