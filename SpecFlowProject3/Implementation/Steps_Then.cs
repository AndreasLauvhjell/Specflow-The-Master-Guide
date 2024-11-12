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
        private ClothesSizeContext _clothesSizeContext;

        public Steps_Then(ProductTestDataContext productTestDataContext, ClothesSizeContext clothesSizeContext)
        {
            _productTestDataContext = productTestDataContext;
            _clothesSizeContext = clothesSizeContext;

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

        [Then(@"the offer is valid")]
        public void ThenTheOfferIsValid()
        {

        }

        [Then(@"the clothing data is translated as the following")]
        public void ThenTheClothingDataIsTranslatedAsTheFollowing(Table table)
        {
            table.CompareToSet<Clothes_Size>(_clothesSizeContext.ClothesSizes);
        }

        [Then(@"the user data is translated as the following")]
        public void ThenTheUserDataIsTranslatedAsTheFollowing(Table table)
        {
            
        }

    }
}
