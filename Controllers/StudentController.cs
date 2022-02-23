using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using efcore1.Models;
using efcore1.Services;
using System.Net;

namespace efcore1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {   
        private readonly IStudent _iStudent;
        
        public StudentController(IStudent iStudent)
        {   
            _iStudent = iStudent;
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return _iStudent.GetStudents();
        }
        [HttpPost]
        public HttpStatusCode Create(Student student)
        {   
            _iStudent.Create(student);
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode Update(Student student)
        {
            _iStudent.Update(student);
            return HttpStatusCode.OK;
        }
        [HttpDelete]
        public HttpStatusCode Delete(int Id)
        {
            _iStudent.Delete(Id);
            return HttpStatusCode.OK;
        }
    }   
}