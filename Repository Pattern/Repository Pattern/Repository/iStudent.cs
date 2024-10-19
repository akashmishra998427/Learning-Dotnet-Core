using Repository_Pattern.Models;
using System.Collections.Generic;

namespace Repository_Pattern.Repository
{
    public interface iStudent
    {
        List<Students> Get_AllStudents();
        Students Get_AllStudentsBYid(int Id);  // Change this line
    }
}
