using DataLayer;
using IdentityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CN_Product
    {
        private CD_Product objDataLayer = new CD_Product();

        public List<Product> List()
        {
            return objDataLayer.List();
        }

        public static implicit operator List<object>(CN_Product v)
        {
            throw new NotImplementedException();
        }
    }
}
