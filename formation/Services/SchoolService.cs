using formation.Models;
using formation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace formation.Services
{
    public class SchoolService
    {
        private readonly IUnitOfWork _iuow;

        public SchoolService(IUnitOfWork unitOfWork)
        {
            _iuow = unitOfWork;
        }

        public void add(Student student)
        {
            _iuow.GetRepository<Student>().Add(student);
            _iuow.Commit();
        }

        public List<Student> getAll()
        {
            return _iuow.GetRepository<Student>().GetAll();
        }

            
            
    }
}
