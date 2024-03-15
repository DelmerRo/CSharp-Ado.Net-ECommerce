using IdentityLayer;
using DataLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
   public class CN_Users
    {
        private CD_Users  objDataLayer = new CD_Users();
        
        public List<User> List()
        {
            return objDataLayer.List();
        }

        public static implicit operator List<object>(CN_Users v)
        {
            throw new NotImplementedException();
        }
    }
}
