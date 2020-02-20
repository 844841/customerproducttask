using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace customerproducttask
{
    class Product
    {
        [Key]

        public int Pid { set; get; }

        public string PName { set; get; }

        public int Quantity { set; get; }

        public double Price { set; get; }
    }
}
