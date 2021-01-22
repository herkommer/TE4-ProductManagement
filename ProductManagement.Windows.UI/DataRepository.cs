using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Windows.UI
{
    public class DataRepository : IRepository
    {
        private ProductEntities _data;

        public DataRepository()
        {
            _data = new ProductEntities();
        }
        public void Add(Product product)
        {
            _data.Products.Add(product);
            _data.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            return _data.Products.ToList();
        }
    }
}
