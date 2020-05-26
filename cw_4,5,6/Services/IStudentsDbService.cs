using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public interface IStudentsDbService

{
    EnrollResponse EnrollStudent(EnrollRequest request);

    PromoteResponse PromoteStudents(PromoteRequest request);

    Student GetStudent(int id);

    IEnumerable<Student> GetStudents();

}
}