using DA_Xuong.Database;
using Microsoft.AspNetCore.Mvc;

namespace DA_Xuong.Controllers
{
    public class ChiTietSachController : Controller
    {
        private readonly ApplicationDBContext _db;

        public IActionResult Index()
        {
            return View();
        }
    }
}
