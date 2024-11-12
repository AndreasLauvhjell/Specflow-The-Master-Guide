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

    public class ClothesSizeContext
    {
        public IEnumerable<Clothes_Size> ClothesSizes;
    }

    public class OfferCodesContext
    {
        public IEnumerable<OfferCodes> OfferCodes;
        public DateTime Today;
    }

    public class OfferCodes
    {
        public string OfferCode { get; set; }
        public DateTime ExpiryDate { get; set; }
        public OfferCodesType OfferCodeType { get; set; }
        public bool IsValid { get; set; }
    }

    public enum OfferCodesType
    {
        ByDate,
        ByProduct,
        ByDay
    }

    public class Clothes_Size
    {
        public string Name { get; set; }
        public InternalSize Size { get; set; }

    }

    public class InternalSize
    {
        public string InternalName { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }

    public enum UserTypeEnum
    {
        Supervisor,
		Staff,
		Customer,
		Visitor
    }

    public class Users
    {
        public string Name { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public string InternalName { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
