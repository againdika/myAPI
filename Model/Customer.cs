using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Model
{
    public class Customer
    {
   
        //public int CusId { get; set; }
        [Key]
        public string Cusemail { get; set; } = string.Empty;
        [Required]
        public string CusPassword { get; set; } = string.Empty;
        [Required]
        public string CusAddress { get; set; } = string.Empty;
        [Required]
        public string CusContact { get; set; } = string.Empty;
        [Required]
        public decimal CreditLimit { get; set; }
        [Required]
        public string CustomerType { get; set; } = string.Empty;
    }
}
