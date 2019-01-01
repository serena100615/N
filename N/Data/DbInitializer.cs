using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using N.Models;

namespace N.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NisContext context)
        {
            context.Database.EnsureCreated();

            // Look for any nurses.
            


        }


    }
}
