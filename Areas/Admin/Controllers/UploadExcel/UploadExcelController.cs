using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Areas.Admin.Services.Interfaces;

namespace Project.Areas.Admin.Controllers.UploadExcel
{
    [Authorize(Roles = "Admin")]
    public class UploadExcel : Controller
    {
        private readonly ISpecialityService _specialityService;
        private readonly IDisciplineService _disciplineService;

        public UploadExcel(
            ISpecialityService specialityService,
            IDisciplineService disciplineService
        )
        {
            _specialityService = specialityService;
            _disciplineService = disciplineService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ClearTable()
        {
            _specialityService.ClearAll();
            // _disciplineService.ClearAll();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                _specialityService.UploadExcel(file);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
