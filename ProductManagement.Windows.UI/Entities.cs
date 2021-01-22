using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Windows.UI
{
    public partial class Product : ProductManagement.Business.Abstract.IProduct
    {
        public override string ToString()
        {
            return Name;
        }
    }
}
