using DataLayer;
using IdentityLayer;
using System;
using System.Collections.Generic;


namespace BusinessLayer
{
    public class CN_Brands
    {
        private CD_Brands objDataLayer = new CD_Brands();

        public List<Brand> List()
        {
            return objDataLayer.List();
        }

        public static implicit operator List<object>(CN_Brands v)
        {
            throw new NotImplementedException();
        }
    }
}
