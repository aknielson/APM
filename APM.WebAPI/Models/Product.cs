using System;

namespace APM.WebAPI.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }


        //"productId": 1,
        //  "productName": "Leaf Rake",
        //  "productCode": "GDN-0011",
        //  "releaseDate": "March 19, 2009",
        //  "description": "Leaf rake with 48-inch wooden handle.",
        //  "price": 19.95
    }
}