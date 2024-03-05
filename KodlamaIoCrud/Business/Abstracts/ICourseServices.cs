using KodlamaIoCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCrud.Business.Abstracts
{
    public interface ICourseServices
    {
        List<Course> GetAll();
        void Add(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
