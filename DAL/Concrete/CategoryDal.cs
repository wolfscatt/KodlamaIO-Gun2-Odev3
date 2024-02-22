using KodlamaIOGün2Ödev3.DAL.Abstract;
using KodlamaIOGün2Ödev3.Entity.Concrete;

namespace KodlamaIOGün2Ödev3.DAL.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private readonly List<Category> _categories;

        public CategoryDal(List<Category> categories)
        {
            _categories = categories;
        }

        public CategoryDal()
        {

        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public Category Delete(Category entity)
        {
            var isDeleted = _categories.Remove(entity);

            if (isDeleted) return entity;
            else return null;
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category entity)
        {
            _categories.Where(c => c.Id == entity.Id).ToList().ForEach(c =>
            {
                c.CategoryName = entity.CategoryName;
            });
        }
    }

}
