using System;
using System.ComponentModel.DataAnnotations;

namespace APM.WebAPI.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Product Code is required", AllowEmptyStrings = false)]
        [MinLength(6, ErrorMessage = "Product Code min length is 6 characters")]
        public string ProductCode { get; set; }
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required",AllowEmptyStrings = false)]
        [MinLength(5, ErrorMessage = "Product Name min lingth is 5 characters")]
        [MaxLength(11, ErrorMessage = "Product Name max lenght is 11 characters")]
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