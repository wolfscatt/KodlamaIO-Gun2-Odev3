using KodlamaIOGün2Ödev3.DAL.Abstract;
using KodlamaIOGün2Ödev3.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOGün2Ödev3.DAL.Concrete
{
    public class CourseDal : ICourseDal
    {
        private readonly List<Course> _courses;

        public CourseDal(List<Course> courses)
        {
            _courses = courses;
        }

        public CourseDal()
        {

        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public Course Delete(Course entity)
        {
            var isDeleted = _courses.Remove(entity);
            if (isDeleted)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course entity)
        {
            _courses.Where(c => c.Id == entity.Id).ToList().ForEach(c =>
            {
                c.CategoryId = entity.CategoryId;
                c.CourseName = entity.CourseName;
                c.CourseInstructor = entity.CourseInstructor;
            });
        }
    }

}
