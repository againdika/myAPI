using System.ComponentModel.DataAnnotations;

namespace ProductAPI.DTO
{
    public class DTOWriteCustomer
    {
        public string Cusemail { get; set; }
        public string CusPassword { get; set; }
        public string CusAddress { get; set; }
        public string CusContact { get; set; }  
        public decimal CreditLimit { get; set; }
        public string CustomerType { get; set; }

    }
}
