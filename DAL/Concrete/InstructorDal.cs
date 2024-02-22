using KodlamaIOGün2Ödev3.DAL.Abstract;
using KodlamaIOGün2Ödev3.Entity.Concrete;

namespace KodlamaIOGün2Ödev3.DAL.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        private readonly List<Instructor> _instructors;

        public InstructorDal(List<Instructor> instructors)
        {
            _instructors = instructors;
        }
        public InstructorDal()
        {
            
        }
        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public Instructor Delete(Instructor entity)
        {
            var isDeleted = _instructors.Remove(entity);
            if(isDeleted) return entity;
            else return null;
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor entity)
        {
            _instructors.Where(i => i.Id == entity.Id).ToList().ForEach(i =>
            {
                i.InstructorName = entity.InstructorName;
            });
        }
    }

}
