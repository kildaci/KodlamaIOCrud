using KodlamaIoCrud.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoCrud.Business.Abstracts
{
    public interface ICategoryServices
    {
        List<Category> GetAll();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
