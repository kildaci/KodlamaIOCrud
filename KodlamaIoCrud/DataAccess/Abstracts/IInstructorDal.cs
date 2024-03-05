using KodlamaIoCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCrud.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor>GetAll();
        void Add(Instructor ınstructor);
        void Update(Instructor ınstructor);
        void Delete(Instructor ınstructor);
    }
}
