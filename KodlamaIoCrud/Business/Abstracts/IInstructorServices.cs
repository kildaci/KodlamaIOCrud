using KodlamaIoCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCrud.Business.Abstracts
{
    public interface IInstructorServices
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);    
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
    }
}
