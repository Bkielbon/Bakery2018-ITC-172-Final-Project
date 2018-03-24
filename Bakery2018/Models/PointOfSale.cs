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
        public string SaleDate { get; set; }
        public string ProductKey { get; set; }
        public string SaleKey { get; set; }
        public string SaleDetailPriceCharged { get; set; }
        public string SaleDetailDiscount{ get; set; }





    }
}