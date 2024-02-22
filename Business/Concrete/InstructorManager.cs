using KodlamaIOGün2Ödev3.Business.Abstract;
using KodlamaIOGün2Ödev3.DAL.Abstract;
using KodlamaIOGün2Ödev3.Entity.Concrete;

namespace KodlamaIOGün2Ödev3.Business.Concrete
{
    public class InstructorManager : IInstructorManager
    {
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor entity)
        {
            _instructorDal.Add(entity);
        }

        public Instructor Delete(Instructor entity)
        {
            var deletedInstructor = _instructorDal.Delete(entity);
            return deletedInstructor;
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Update(Instructor entity)
        {
            _instructorDal.Update(entity);
        }
    }
}
