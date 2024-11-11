using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist.Attributes;
using TechTalk.SpecFlow.UnitTestProvider;

namespace SpecFlowProject3
{
    public static class Products
    {
        private static IEnumerable<ProductQuantities> _productWithQuantities;
        private static ProductQuantities _testingProduct;



        public static IEnumerable<ProductQuantities> ProductQuantities { get { return _productWithQuantities; } set { _productWithQuantities = value; } }

        public static ProductQuantities TestingProduct { get { return _testingProduct; } set { _testingProduct = value; } }
    }

    public class ProductQuantities
    {
        [TableAliases("Product ID")]
        public string ProductID { get; set; }

        [TableAliases("Reserved Qty")]
        public int Stock { get; set; }
        public int Basket { get; set; }
    }
}
