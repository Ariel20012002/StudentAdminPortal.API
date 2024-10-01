using StudentAdminPortal.API.DataModels;
using System.Linq;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;

        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }

        public List<Student> GetStudents()
        {
            return context.Student.ToList();
        }
    }
}
