using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProsperApp.Models;

namespace ProsperApp.Services.Interfaces
{
    public interface IStudentService
    {
        void RegisterStudent(string name, string Email, string phoneNumber, string address);
        void DeleteStudent(int id );
        Student? ViewStudent (int id);
        List<Student> ViewAllStudents();
    }
}