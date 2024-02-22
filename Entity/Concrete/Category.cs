using KodlamaIOGün2Ödev3.Entity.Abstract;

namespace KodlamaIOGün2Ödev3.Entity.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
