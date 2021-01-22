using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Business.Abstract;
using ProductManagement.Business.Concrete;

namespace ProductManagement.Business.Concrete
{
    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> _products;

        public ShoppingCart()
        {
            _products = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            _products.Add(product); //Explicit! as Product
            //Nu blir det förvirrat, vi har en produkt klass från Business
            //och en produkt klass från entity framework
            //därför funkar inte "as" och svaret blir NULL
            //som senare gör att listan kraschar på item is null
        }

        public List<IProduct> GetProducts()
        {
            return _products;
        }

        public void RegisterCustomer(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(IProduct product)
        {
            throw new NotImplementedException();
        }
    }
}
