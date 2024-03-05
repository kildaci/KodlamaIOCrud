using KodlamaIoCrud.DataAccess.Abstracts;
using KodlamaIoCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCrud.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
        
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course> 
            {
                new Course {Id=1, CategoryId=1, InstructorId=1, Name="Yazılım Geliştirici Yetiştirme Kampı JavaScript" } ,
                new Course { Id = 2, CategoryId = 1, InstructorId = 1, Name = "Senior Yazılım Geliştirici Yetiştirme Kampı"  },
                new Course { Id = 2, CategoryId = 1, InstructorId = 2, Name = "Yazılım Geliştirici Yetiştirme Kampı- Python"  }
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
            Console.WriteLine("Kurs eklendi" +course.Name);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);    
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            Course existCourse = _courses.Find(x => x.Id == course.Id);
            if (existCourse is null)
                return;
            existCourse.Name = course.Name;
            existCourse.CategoryId = course.CategoryId;
            existCourse.InstructorId = course.InstructorId;
            
            
        }
    }
}
