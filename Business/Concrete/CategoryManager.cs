using KodlamaIOGün2Ödev3.Business.Abstract;
using KodlamaIOGün2Ödev3.DAL.Abstract;
using KodlamaIOGün2Ödev3.Entity.Concrete;

namespace KodlamaIOGün2Ödev3.Business.Concrete
{
    public class CategoryManager : ICategoryManager
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public Category Delete(Category entity)
        {
            var deletedCategory = _categoryDal.Delete(entity);
            return deletedCategory;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
