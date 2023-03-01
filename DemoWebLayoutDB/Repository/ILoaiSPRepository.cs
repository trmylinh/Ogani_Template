using DemoWebLayoutDB.Models;

namespace DemoWebLayoutDB.Repository
{
    public interface ILoaiSPRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(String Maloai);
        TLoaiSp GetLoaiSp(String Maloai);

        IEnumerable<TLoaiSp> GetAllLoaiSp();
    }
}
