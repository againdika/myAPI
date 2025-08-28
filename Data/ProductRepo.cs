using ProductAPI.Model;

namespace ProductAPI.Data
{
    public class ProductRepo
    {
        private companyDBContext compDB;

        public ProductRepo(companyDBContext context)
        {
            compDB=context;
        }

        public bool SaveProduct()
        { 
            int count=compDB.SaveChanges();
            if (count > 0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        public bool CreateProduct(Product product)
        {
            if (product != null)
            {
                compDB.Products.Add(product);
                return SaveProduct();
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            if (product != null)
            {
                compDB.Products.Update(product);
                return SaveProduct();
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(Product product)
        {
            if (product != null)
            {
                compDB.Products.Remove(product);
                return SaveProduct();
            }
            else
            {
                return false;
            }
        }

        public Product GetProduct(int id)
        {
            return compDB.Products.FirstOrDefault(pro => pro.Id == id);
        }

        public IEnumerable<Product> GetProduct()
        {
            return compDB.Products.ToList();
        }
    }
}
