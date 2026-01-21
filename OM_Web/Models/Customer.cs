using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OM_Web.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }

        [Required(ErrorMessage = "Company Name is mandatory")]
        [MaxLength(50, ErrorMessage = "Maximum Length of this field is 50 charachters")]
        [DisplayName ("Company")]
        public string Company { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Length of this field is 50 charachters")]
        [DisplayName("Last Name")]
        public string? Last_Name { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Length of this field is 50 charachters")]
        [DisplayName("First Name")]
        public string? First_Name { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Length of this field is 50 charachters")]
        [DisplayName("Email")]
        public string? E_Mail_Address { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Length of this field is 50 charachters")]
        [DisplayName("Job Titl")]
        public string? Job_Title { get; set; }

        [MaxLength(25, ErrorMessage = "Maximum Length of this field is 25 charachters")]
        [DisplayName("Business Phone")]
        public string? Business_Phone { get; set; }

        [MaxLength(25, ErrorMessage = "Maximum Length of this field is 25 charachters")]
        [DisplayName("Fax")]
        public string? Fax_Number { get; set; }

        public string? Address { get; set; }
        public string? Notes { get; set; }

    }
}
