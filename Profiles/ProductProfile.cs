using AutoMapper;
using ProductAPI.Model;
using ProductAPI.DTO;

namespace ProductAPI.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile() 
        {
            CreateMap<Product, DTOReadProduct>();
            CreateMap<DTOWriteProduct, Product>();
        }
    }
}
