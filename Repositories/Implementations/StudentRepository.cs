using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProseperApp.Contexts;
using ProsperApp.Models;
using ProsperApp.Repositories.Interfaces;

namespace ProsperApp.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public void AddStudent(Student student)
        {
            ProsperContext.Students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            ProsperContext.Students.Remove(student);
        }

        public Student? GetStudent(int id)
        {
            foreach (var item in ProsperContext.Students)
            {
                if(item.Id ==  id )
                {
                    return item;
                }
            }
            return null;
        }

        public List<Student> GetStudents()
        {
            return ProsperContext.Students;
        }
    }
}