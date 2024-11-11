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
    public class Steps_Given : ContextHelper
    {
        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            ProductContext.ProductWithQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(int productId)
        {
            ProductContext.TestingProduct = ProductContext.ProductWithQuantities.FirstOrDefault(t => int.Parse(t.ProductID) == productId);

        }
    }
}
