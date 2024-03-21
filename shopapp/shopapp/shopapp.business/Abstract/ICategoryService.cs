using System.Collections.Generic;
using shopapp.entity;
using System.Threading.Tasks;


namespace shopapp.business.Abstract
{
    public interface ICategoryService: IValidator<Category>
    {
        Task<Category> GetById(int id);

        Category GetByIdWithProducts(int categoryId);

        Task<List<Category>> GetAll();

        void Create(Category entity);
        
        Task<Category> CreateAsync (Category entity);

        void Update(Category entity);
        void Delete(Category entity);
        void DeleteFromCategory(int productId,int categoryId);
    }
}