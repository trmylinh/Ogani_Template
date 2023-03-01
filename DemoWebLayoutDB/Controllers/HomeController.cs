using DemoWebLayoutDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;

namespace DemoWebLayoutDB.Controllers
{
    public class HomeController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page = 1)
        {
            int pageNumber = page;
            int pageSize = 8;
            var lstanpham = db.TDanhMucSps.AsNoTracking().OrderBy(x => x.TenSp);
            PagedList<TDanhMucSp> pagelist = new PagedList<TDanhMucSp>(lstanpham, pageNumber, pageSize);
            return View(pagelist);
        }

        // component : giong partial view nhưng mạnh mẽ hơn, những chức năng phức tạp thì dùng component: menu, giỏ hàng....
        public IActionResult PLSanPham(string MaLoai, int? page)
        {
            // home/plsanpham?maloai=vali (tui, balo...)
            int pageNumber = page == null || page < 1 ? 1 : page.Value;
            int pageSize = 8;
            var lstanpham = db.TDanhMucSps.Where(x=>x.MaLoai==MaLoai).OrderBy(x=>x.TenSp);
            PagedList<TDanhMucSp> pagelist = new PagedList<TDanhMucSp>(lstanpham, pageNumber, pageSize);
            ViewBag.maLoai = MaLoai;
            return View(pagelist);
        }

        public IActionResult Privacy()
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