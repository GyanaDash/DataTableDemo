using DataTableDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTableDemo.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetById(int studentId);
        void Save(Student oStudent);
        void Update(Student oStudent);
        string Delete(int StudentId);
    }
}
