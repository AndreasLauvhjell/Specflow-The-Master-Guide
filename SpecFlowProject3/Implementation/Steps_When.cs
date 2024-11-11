using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.Implementation
{
    [Binding]
    public class Steps_When : ContextHelper
    {
        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if (ProductContext.TestingProduct.Stock > 0 && ProductContext.TestingProduct.Basket == 0)
            {
                ProductContext.TestingProduct.Basket++;
                ProductContext.TestingProduct.Stock--;
            }

            // NOE HER DIN IDIOT
        }
    }
}
