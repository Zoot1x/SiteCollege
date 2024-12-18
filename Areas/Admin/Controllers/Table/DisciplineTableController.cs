using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Areas.Admin.Repositories.Interfaces;

namespace Project.Areas.Admin.Controllers.Table
{
    [Authorize(Roles = "Admin")]
    public class DisciplineTable : Controller
    {
        private readonly IDisciplineRepository _disciplineRepository;

        public DisciplineTable(IDisciplineRepository disciplineRepository)
        {
            _disciplineRepository = disciplineRepository;
        }

        public ActionResult Index(int specialityId)
        {
            var disciplines = _disciplineRepository
                .GetAll()
                .Where(d => d.SpecialityId == specialityId)
                .ToList();

            return View(disciplines);
        }
    }
}
