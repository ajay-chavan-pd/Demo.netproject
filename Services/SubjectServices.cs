using EFMVC.Context;
using EFMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Services
{
    public class SubjectServices : ISubjectServices
    {
        MVCcontext db;
        public SubjectServices(MVCcontext _db)
        {
            this.db = _db;
        }

        public void DeleteASubject(int id)
        {
            Subject subject = db.Subjects.FirstOrDefault(subject => subject.SubjectId == id);
            if (subject != null)
            {
                db.Remove(subject);
                db.SaveChanges();
            }
        }

        [HttpPost]
        public void CreateSubject(Subject subject)
        {
            db.Add(subject);
            db.SaveChanges();

        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            return(db.Subjects.Select(s => s).ToList());
            
        }
    }
}
