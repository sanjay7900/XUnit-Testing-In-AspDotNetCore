using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XUnitTesting_Implement.Models;
using XUnitTesting_Implement.Services;

namespace XUnitTesting_Implement.Controllers
{
    public class StudentsController : Controller
    {
        private IDataServices<Student> _dataServices;

        public StudentsController(IDataServices<Student> dataServices)
        {
            _dataServices = dataServices;
        }
        // GET: StudentsController
        public ActionResult Index()
        {
            var listStudent = _dataServices.GetAll();
            return View(listStudent);
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            var data= _dataServices.GetById(id);
            return View(data);
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                _dataServices.AddEntity(student);
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            var student = _dataServices.GetById(id);
            return View(student);
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                _dataServices.UpdateEntity(student, id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            var IsDeleted = _dataServices.DeleteEntity(id);
            if (IsDeleted)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
