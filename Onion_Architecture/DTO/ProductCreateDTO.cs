using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /*DTO = Data transfer object is a class used to transfer only the required data between the client & server. It contains only fields no bussiness logic 
    and it helps to hide unnecessary or sensitive data  */

    public class ProductCreateDTO 
    {
        public string Name { get; set; }

        public string? color { get; set; }

        public int size { get; set; }

        public string quality { get; set; }

        public string Description { get; set; }
    }
}
