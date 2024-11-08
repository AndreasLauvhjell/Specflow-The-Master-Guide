﻿using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.Assist.Attributes;
using TechTalk.SpecFlow.UnitTestProvider;

namespace SpecflowProject3
{
    [Binding]
    public class StepDefinitions
    {
        private IEnumerable<ProductQuantities> productWithQuantities;
        private ProductQuantities testingProduct;

        private class ProductQuantities
        {
            [TableAliases("Product ID")]
            public string ProductID { get; set; }

            [TableAliases("Reserved Qty")]
            public int Stock { get; set; }
            public int Basket { get; set; }
        }

        [Given(@"I have the following data")]
        public void GivenIHaveTheFollowingData(Table table)
        {
            productWithQuantities = table.CreateSet<ProductQuantities>();
        }

        [Given(@"I am on the product detail page of product (.*)")]
        public void GivenIAmOnTheProductDetailPageOfProduct(int productId)
        {
            testingProduct = productWithQuantities.FirstOrDefault(t => int.Parse(t.ProductID) == productId);
        }


        [Then(@"the quantities are")]
        public void ThenTheQuantitiesAre(Table table)
        {
            var comparisonList = productWithQuantities.Where(t => t.ProductID == testingProduct.ProductID);
            table.CompareToSet<ProductQuantities>(comparisonList);
        }

        [Then(@"a message '(.*)' is displayed to the customer")]
        public void ThenAMessageIsDisplayedToTheCustomer(string p0)
        {

        }

        [When(@"I click the Add to Basket button")]
        public void WhenIClickTheAddToBasketButton()
        {
            if(testingProduct.Stock > 0 && testingProduct.Basket == 0)
            {
                testingProduct.Basket++;
                testingProduct.Stock--;
            }
        }
    }
}