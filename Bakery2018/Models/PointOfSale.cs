using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bakery2018.Models;

namespace Bakery2018.Models
{
    public class PointOfSale
    {
        public IEnumerable<Models.Sale> Sale { get; set; }
        public IEnumerable<Models.SaleDetail>SaleDetails{ get;set;} 
        public string CustomerKey { get; set; }
        public string EmployeeKey { get; set; }
        public string SaleKey { get; set; }
        public string SaleDetailKey { get; set; }
        public string SaleDate { get; set; }
        public string ProductKey { get; set; }
        public string SaleDetailPriceCharged { get; set; }
        public string SaleDetailDiscount{ get; set; }
        public string SaleDetailSaleTaxPercent { get; set; }
        public string SaleDetailEatInTax { get; set; }
        public string SaleDetailQuanity { get; set; }







    }
}