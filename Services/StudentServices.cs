using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efcore1.Models;
using efcore1.Responsitory;

namespace efcore1.Services
{
    public class StudentServices : IStudent
    {
        private readonly IResponsitory _iResponsitory;
        
        public StudentServices(IResponsitory iResponsitory)
        {
            _iResponsitory = iResponsitory;
        }

        public void Create(Student student)
        {
           _iResponsitory.Create(student);
        }

        public void Delete(int Id)
        {
            _iResponsitory.Delete(Id);
        }

        public List<Student> GetStudents()
        {
            return _iResponsitory.GetStudents();
        }

        public void Update(Student student)
        {
            _iResponsitory.Update(student);
        }
    }
}