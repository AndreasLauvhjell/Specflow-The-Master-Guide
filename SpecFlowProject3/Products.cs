using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist.Attributes;
using TechTalk.SpecFlow.UnitTestProvider;

namespace SpecFlowProject3
{
    public class ProductQuantities
    {
        [TableAliases("Product ID")]
        public string ProductID { get; set; }

        [TableAliases("Reserved Qty")]
        public int Stock { get; set; }
        public int Basket { get; set; }
    }

    public class ProductTestDataContext
    {
        public IEnumerable<ProductQuantities> ProductWithQuantities;
        public ProductQuantities TestingProduct;
    }
}
