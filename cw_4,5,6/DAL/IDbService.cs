using Cw_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw_3.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
        
        public void RemoveStudent(int id);
        public void AddStudent(Student s);
        public Student GetStudent(int id);
        public void UpdateStudent(Student s, int id);
        public int ListLength();
    }
}
