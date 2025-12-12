using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IProductService 
    {
        //Wiith the help of IEnum we can fetch all the details of the products 
        Task<IEnumerable<ProductReadDTO>> GetAll();

        //Get product with the help of ID
        Task<ProductReadDTO> GetById(int id);

        //
        Task<ProductCreateDTO> Add(ProductCreateDTO productCreateDTO);

        Task<ProductReadDTO> Update(ProductUpdateDTO productUpdateDTO);

        Task<bool> DeleteById(int id);


    }
}
