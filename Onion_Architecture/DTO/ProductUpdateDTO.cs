using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductUpdateDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string color { get; set; }

        public int size { get; set; }

        public string quality { get; set; }

        public string Description { get; set; }
    }
}
