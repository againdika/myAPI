using System.ComponentModel.DataAnnotations;

namespace ProductAPI.DTO
{
    public class DTOWriteProduct
    {      
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int stock { get; set; }
    }
}
