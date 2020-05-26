using Cw_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw_3.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
             //   new Student { IdStudent = 10, FirstName = "Jan", LastName = "Kowalski" },
               // new Student { IdStudent = 22, FirstName = "Anna", LastName = "Majewska" },
                //new Student { IdStudent = 33, FirstName = "Andrzej", LastName = "Andrzejewicz" }
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
            public void AddStudent(Student s)
            {
                var List = new List<Student>(_students);
                List.Add(s);
                _students = List;
            }
        public void RemoveStudent(int id)
        {
            var tmpStudentList = GetStudents().Where(s => s.IdStudent != id).ToList();

            var modifiedStudentList = tmpStudentList.Where(s => s.IdStudent == id).ToList();

            _students = tmpStudentList;

        }

        public void UpdateStudent(Student s, int id)
            {
                RemoveStudent(id);
                var tmpList = _students.ToList();
                tmpList.Add(s);
                _students = tmpList;

            }

          
        public int ListLength()
        {
            var tmp = _students.ToList();
            return tmp.Count;
        }
        public Student GetStudent(int id)
            {
                var tmp = _students.ToList();

                return tmp.ElementAt(id);
            }

           
        }
    }