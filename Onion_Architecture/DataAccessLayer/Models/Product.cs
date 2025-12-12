using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is Single Responsibility principle .
//A class should have single reason to change .
namespace DataAccessLayer.Models
{

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //Nullable
        public string? color  { get; set; }

        public int size { get; set; }

        public string quality { get; set; }

        public string Description { get; set; }



    }
}
