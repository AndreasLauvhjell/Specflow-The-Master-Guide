using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3
{
    public class ContextHelper : Steps
    {
        protected ProductTestDataContext ProductContext
        {
            get
            {
                ProductTestDataContext result = new ProductTestDataContext();
                result.ProductWithQuantities = new List<ProductQuantities>();
                if(ScenarioContext.ContainsKey(ContextConstants.TESTINGPRODUCTCONTEXT) == false)
                {
                    result.ProductWithQuantities = new List<ProductQuantities>();
                    ScenarioContext.Add(ContextConstants.TESTINGPRODUCTCONTEXT, result);
                }
                else
                {
                    result = (ProductTestDataContext)ScenarioContext[ContextConstants.TESTINGPRODUCTCONTEXT];
                }

                return result;
            }
        }
    }

    //Customercontext

    //Offercontext
}
