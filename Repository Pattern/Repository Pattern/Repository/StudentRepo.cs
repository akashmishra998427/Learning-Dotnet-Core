using Repository_Pattern.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository_Pattern.Repository
{
    public class StudentRepo : iStudent
    {
        public List<Students> Get_AllStudents()
        {
            return Datasource();
        }

        // This method should return a single Students object, not a list
        public Students Get_AllStudentsBYid(int id)
        {
            return Datasource().FirstOrDefault(x => x.RollNo == id); // Return a single student or null if not found
        }


        private List<Students> Datasource()
        {
            return new List<Students>
            {
                new Students { RollNo = 1, Name = "Akash Mishra", Gender = "Male", Standerd = 12 },
                new Students { RollNo = 2, Name = "Adarsh Upadhyay", Gender = "Male", Standerd = 12 },
                new Students { RollNo = 3, Name = "Akhilesh Baniya", Gender = "Male", Standerd = 12 },
                new Students { RollNo = 4, Name = "Adatiya Singh", Gender = "Male", Standerd = 12 },
                new Students { RollNo = 5, Name = "Ankit Mishra", Gender = "Male", Standerd = 12 },
                new Students { RollNo = 6, Name = "Anurag Verma", Gender = "Male", Standerd = 12 },
            };
        }
    }
}
