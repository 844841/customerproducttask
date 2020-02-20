using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace customerproducttask
{
    class Customer
    {
        [Key]

        public int Cid { set; get; }

        public string Cname { set; get; }

        public long MobileNo{ set; get; }

        public List<Product> ProductDetails { set; get; }

    }
}
