using DemoWebLayoutDB.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebLayoutDB.ViewComponents
{
    public class LoaiSPMenuViewComponent : ViewComponent
    {
        private readonly ILoaiSPRepository _loaiSPRepository;
        public LoaiSPMenuViewComponent(ILoaiSPRepository loaiSPRepository)
        {
            _loaiSPRepository = loaiSPRepository;
        }

        public IViewComponentResult Invoke()
        {
            var loaisps = _loaiSPRepository.GetAllLoaiSp().OrderBy(x => x.Loai);
            return View(loaisps);
        }
    }
}
