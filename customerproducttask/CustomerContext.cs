using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace customerproducttask
{
    class CustomerContext : DbContext
    {
        public DbSet<Customer> customers { set; get; }
    }
}
