using DA_Xuong.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DA_Xuong.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            var projects = new List<Project>()
            {
                new Project()
                {
                    ID_Sach = 1,
                    LoaiSach = "Tâm lý",
                     HinhAnh = "/IMG/AnhSach/tktd.jpg",
                    TenSach = "Thời khắc tươi đẹp",
                    MoTa = "Tâm lí học là ngành khoa học nghiên cứu hoạt động, tinh thần và tư tưởng của con người (cụ thể đó là những cảm xúc, ý chí và hành động)",
                    GiaSach = 199000,
                    TacGia = "NiNa Riggs"

                },
                 new Project()
                {
                    ID_Sach = 2,
                    LoaiSach = "Tâm lý",
                    HinhAnh = "/IMG/AnhSach/tktd.jpg",
                    TenSach = "Thời khắc tươi đẹp",
                    MoTa = "Tâm lí học là ngành khoa học nghiên cứu hoạt động, tinh thần và tư tưởng của con người (cụ thể đó là những cảm xúc, ý chí và hành động)",
                    GiaSach = 199000,
                      TacGia = "NiNa Riggs"

                },
                 new Project()
                {
                    ID_Sach = 3,
                    LoaiSach = "Tâm lý",
                     HinhAnh = "/IMG/AnhSach/tktd.jpg",
                    TenSach = "Thời khắc tươi đẹp",
                    MoTa = "Tâm lí học là ngành khoa học nghiên cứu hoạt động, tinh thần và tư tưởng của con người (cụ thể đó là những cảm xúc, ý chí và hành động)",
                    GiaSach = 199000,
                      TacGia = "NiNa Riggs"

                },
                 new Project()
                {
                    ID_Sach = 4,
                    LoaiSach = "Tâm lý",
                    HinhAnh = "/IMG/AnhSach/tktd.jpg",
                    TenSach = "Thời khắc tươi đẹp",
                    MoTa = "Tâm lí học là ngành khoa học nghiên cứu hoạt động, tinh thần và tư tưởng của con người (cụ thể đó là những cảm xúc, ý chí và hành động)",
                    GiaSach = 199000,  
                     TacGia = "NiNa Riggs"

                },
            };
            return View(projects);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SanPham()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
