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
        private ProductTestDataContext _productTestDataContext;

        public Steps_Given(ProductTestDataContext productTestDataContext)
        {
            _productTestDataContext = productTestDataContext;
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            _productTestDataContext.ProductWithQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(int productId)
        {
            _productTestDataContext.TestingProduct = _productTestDataContext.ProductWithQuantities.FirstOrDefault(t => int.Parse(t.ProductID) == productId);

        }
    }
}
