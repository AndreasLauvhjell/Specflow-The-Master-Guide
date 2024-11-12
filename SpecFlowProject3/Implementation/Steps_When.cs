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
        private ProductTestDataContext _productTestDataContext;
        private ClothesSizeContext _clothesSizeContext;

        public Steps_When(ProductTestDataContext productTestDataContext, ClothesSizeContext clothesSizeContext)
        {
            _productTestDataContext = productTestDataContext;
            _clothesSizeContext = clothesSizeContext;
        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if (_productTestDataContext.TestingProduct.Stock > 0 && _productTestDataContext.TestingProduct.Basket == 0)
            {
                _productTestDataContext.TestingProduct.Basket++;
                _productTestDataContext.TestingProduct.Stock--;
            }

            // NOE HER DIN IDIOT
        }

        [When(@"I add offer code '([^']*)' to the basket")]
        public void WhenIAddOfferCodeToTheBasket(string p0)
        {

        }

    }
}
