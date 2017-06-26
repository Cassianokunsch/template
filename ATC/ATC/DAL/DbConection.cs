using ATC.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DbConection
    {
        private static BDATCEntities context;

        private DbConection()
        {

        }

        public static BDATCEntities getContext()
        {
            if (context == null)
            {
                context = new BDATCEntities();
            }
            return context;
        }
    }
}
