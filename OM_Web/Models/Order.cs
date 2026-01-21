using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OM_Web.Models
{
    public class Order
    {
        [Key]
        [Required(ErrorMessage = "Order Number is mandatory")]
        [DisplayName("Order Number")]
        public int Order_No { get; set; }

        [Required(ErrorMessage = "Customer is mandatory")]
        [DisplayName("Company")]
        public int Customer_ID { get; set; }
        //[ForeignKey("Customer_ID")]
        //[ValidateNever]
        //public Customer Customer { get; set; }

        [DisplayName("Order Date")]
        [DisplayFormat(DataFormatString = "{dd/mm/yyyy}")]
        public DateTime? Order_Date { get; set; }

        [DisplayName("Shipping Fee")]
        public decimal? Shipping_Fee { get; set; }

        [DisplayName("Taxes")]
        public decimal? Taxes { get; set; }

        public string? Notes { get; set; }
    }
}
