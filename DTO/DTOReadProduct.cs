using System.ComponentModel.DataAnnotations;

namespace ProductAPI.DTO
{
    public class DTOReadProduct
    {
        public int Id { get; set; }       
        public string Name { get; set; }
        public string Description { get; set; }       
        public decimal Price { get; set; }
        public int stock { get; set; }
    }
}
