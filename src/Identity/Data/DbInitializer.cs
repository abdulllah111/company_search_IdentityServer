using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Data
{
    public class DbInitializer
    {
        public static void Initialize(AuthDbContext context){
            context.Database.EnsureCreated();
        }
    }
}