using EFMVC.Models;

namespace EFMVC.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects ();
        public void DeleteASubject(int id);
        public void CreateSubject(Subject subject);
    }
}
