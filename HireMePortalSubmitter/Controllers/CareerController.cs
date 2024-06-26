using HireMePortalSubmitter.Models;
using Microsoft.AspNetCore.Mvc;

namespace HireMePortalSubmitter.Controllers
{
    public class CareerController : Controller
    {
        readonly ApplicationDBContext _db;
        public CareerController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Career> obj = _db.Careers.ToList();
            return View(obj);
        }
        public IActionResult Apply(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var category = _db.Careers.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            CareerApply careerApply = new CareerApply();
            careerApply.CareerId=category.Id;
            careerApply.JobCode=category.JobCode;
            return View(careerApply);
        }

        [HttpPost, ActionName("Apply")]
        public IActionResult Apply(CareerApply obj)
        {
            if (ModelState.IsValid)
            {
                _db.CareerApply.Add(obj);
                _db.SaveChanges();
                TempData["Sucess"] = "Category created sucefully";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
