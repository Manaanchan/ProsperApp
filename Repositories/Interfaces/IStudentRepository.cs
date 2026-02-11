using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProsperApp.Models;

namespace ProsperApp.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        
        void AddStudent (Student student);
        Student? GetStudent(int id);
         List<Student> GetStudents();
        void DeleteStudent(Student student);
    }
}