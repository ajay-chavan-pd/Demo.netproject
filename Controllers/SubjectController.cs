using EFMVC.Context;
using EFMVC.Models;
using EFMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFMVC.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;
        public SubjectController(ISubjectServices _iss)
        {
            this.iss = _iss;
        }

        public IActionResult Index()
        {
            return View(iss.GetAllSubjects());
        }

        public IActionResult Delete(int id)
        {
            iss.DeleteASubject(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subject subject)
        {
            iss.CreateSubject(subject);
            return RedirectToAction("Index");
            return View();
        }
        
        
    }
 }
