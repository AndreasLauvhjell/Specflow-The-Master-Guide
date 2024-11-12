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
        private ProductTestDataContext _productTestDataContext;

        public Steps_Then(ProductTestDataContext productTestDataContext)
        {
            _productTestDataContext = productTestDataContext;
        }

        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = _productTestDataContext.ProductWithQuantities.Where(t => t.ProductID == _productTestDataContext.TestingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }

        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }
    }
}
