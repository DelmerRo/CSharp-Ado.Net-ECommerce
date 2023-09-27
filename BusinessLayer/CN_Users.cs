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
    }
}
