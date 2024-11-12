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
        private ClothesSizeContext _clothesSizeContext;

        public Steps_Given(ProductTestDataContext productTestDataContext, ClothesSizeContext clothesSizeContext)
        {
            _productTestDataContext = productTestDataContext;
            _clothesSizeContext = clothesSizeContext;
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

        [Given(@"I have the following offer codes")]
        public void GivenIHaveTheFollowingOfferCodes(Table table)
        {
            var result = table.CreateSet<OfferCodes>();
        }

        [Given(@"today is '([^']*)'")]
        public void GivenTodayIs(DateTime today)
        {

        }

        [Given(@"I have an offer with '([^']*)' and offertype of '([^']*)'")]
        public void GivenIHaveAnOfferWithAndOffertypeOf(string offerCode, OfferCodesType offerType)
        {

        }
        
        [Given(@"I have the following clothes size data")]
        public void GivenIHaveTheFollowingClothesSizeData(Table table)
        {
            _clothesSizeContext.ClothesSizes = table.CreateSet<Clothes_Size>();
        }

        [Given(@"I have the following users")]
        public void GivenIHaveTheFollowingUsers(Table table)
        {
            
        }

    }
}
