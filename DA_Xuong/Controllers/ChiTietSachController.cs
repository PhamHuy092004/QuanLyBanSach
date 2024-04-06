using Microsoft.AspNetCore.Mvc;

namespace DA_Xuong.Controllers
{
    public class ChiTietSachController : Controller
    {
<<<<<<< HEAD
        private readonly ApplicationDBContext _db;
        public ChiTietSachController(ApplicationDBContext db)
=======
        public IActionResult Index()
>>>>>>> pr/1
        {
            _db = db;
        }

        public IActionResult Index(int id)

        {
            var project = _db.SACH.FirstOrDefault(p => p.IDSACH == id);

            return View(project);
        }
    }
}
