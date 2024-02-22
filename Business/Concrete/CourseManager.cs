using KodlamaIOGün2Ödev3.Business.Abstract;
using KodlamaIOGün2Ödev3.DAL.Abstract;
using KodlamaIOGün2Ödev3.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOGün2Ödev3.Business.Concrete
{
    public class CourseManager : ICourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course entity)
        {
            _courseDal.Add(entity);
        }

        public Course Delete(Course entity)
        {
            var deletedCourse = _courseDal.Delete(entity);
            return deletedCourse;
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course entity)
        {
            _courseDal.Update(entity);
        }
    }
}
