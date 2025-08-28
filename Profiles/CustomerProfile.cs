using AutoMapper;
using ProductAPI.Model;
using ProductAPI.DTO;

namespace ProductAPI.Profiles
{
    public class CustomerProfile:Profile
    {
        public CustomerProfile() 
        {
            CreateMap<Customer, DTOReadCustomer>();
            CreateMap<DTOWriteCustomer, Customer>();
        }

    }
}
