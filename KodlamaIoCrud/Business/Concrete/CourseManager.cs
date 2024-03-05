using KodlamaIoCrud.Business.Abstracts;
using KodlamaIoCrud.DataAccess.Abstracts;
using KodlamaIoCrud.DataAccess.Concrete;
using KodlamaIoCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCrud.Business.Concrete
{
    public class CourseManager : ICourseServices
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal CourseDal)
        {
            _courseDal = CourseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
