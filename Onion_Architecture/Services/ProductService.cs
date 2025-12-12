using AutoMapper;
using DataAccessLayer;
using DataAccessLayer.Models;
using DTO;
using Microsoft.EntityFrameworkCore;
using Services.IServices;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;

        public ProductService(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ProductCreateDTO> Add(ProductCreateDTO productCreateDTO)
        {
            var product = _mapper.Map<Product>(productCreateDTO);
            await _dbContext.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<ProductCreateDTO>(product);
        }

        public async Task<bool> DeleteById(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product != null)
            {
                _dbContext.Products.Remove(product);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            else
                return false;
        }

        public async Task<IEnumerable<ProductReadDTO>> GetAll()
        {
            var products = await _dbContext.Products.ToListAsync();
            return _mapper.Map<IEnumerable<ProductReadDTO>>(products);
        }

        public async Task<ProductReadDTO> GetById(int id)
        {
            var product = await _dbContext.Products.FindAsync(id);
            if (product == null)
                return null;
            else
            {
                return _mapper.Map<ProductReadDTO>(product);
            }
        }

        public async Task<ProductReadDTO> Update(ProductUpdateDTO productUpdateDTO)
        {
            var existingProduct = await _dbContext.Products.FindAsync(productUpdateDTO.Id);
            if (existingProduct == null)
                return null;
            else
            {
                //we get data from the resquest body & get inside productupdteDTO & we can pass the data to Product table . 
                //productUpdateDTO is our source from swagger 
                //existingProduct is our destination in the database

                _mapper.Map(productUpdateDTO, existingProduct);
                await _dbContext.SaveChangesAsync();
                return _mapper.Map<ProductReadDTO>(existingProduct);
            }
        }
    }
}
