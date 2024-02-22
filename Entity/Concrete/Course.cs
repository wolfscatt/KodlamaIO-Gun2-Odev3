using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOGün2Ödev3.Entity.Abstract;

namespace KodlamaIOGün2Ödev3.Entity.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string CourseInstructor { get; set; }


        public override string ToString()
        {
            return "Id: " + Id + " CategoryId: " + CategoryId + " CourseName: " + CourseName + " CourseInstructor: " + CourseInstructor;
        }
    }

}
