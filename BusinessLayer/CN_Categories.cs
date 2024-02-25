using DataLayer;
using IdentityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CN_Categories
    {
        private CD_Categories objDataLayer = new CD_Categories();

        public List<Category> List()
        {
            return objDataLayer.List(); 
        }

        public static implicit operator List<object>(CN_Categories v)
        {
            throw new NotImplementedException();    
        }
    }
}
