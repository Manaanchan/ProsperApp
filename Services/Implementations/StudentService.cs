using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ProseperApp.Contexts;
using ProsperApp.Models;
using ProsperApp.Repositories.Implementations;
using ProsperApp.Services.Interfaces;

namespace ProsperApp.Services.Implementations
{
    public class StudentService : IStudentService
    {
        StudentRepository studentRepository = new StudentRepository();
        public void DeleteStudent(int id)
        {
            Student? student = null;
            
            foreach (var item in ProsperContext.Students)
            {
                if(item.Id == id)
                {
                   Console.WriteLine("Student has been deleted successfully");
                   student = item ;
                }
                if(student == null )
                {
                   Console.WriteLine("Student not ");
                    
                }
            }
            
        }

        public void RegisterStudent(string name, string Email, string phoneNumber, string address)
        {
            throw new NotImplementedException();
        }

        public List<Student> ViewAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student? ViewStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}