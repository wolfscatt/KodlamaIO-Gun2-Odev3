using KodlamaIOGün2Ödev3.Entity.Abstract;

namespace KodlamaIOGün2Ödev3.Entity.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string InstructorName { get; set; }
    }
}
