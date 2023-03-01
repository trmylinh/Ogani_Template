using DemoWebLayoutDB.Models;

namespace DemoWebLayoutDB.Repository
{
    public class LoaiSPRepository : ILoaiSPRepository
    {
        private readonly QlbanVaLiContext _context;
        public LoaiSPRepository(QlbanVaLiContext context)
        {
            _context = context;
        }
        public TLoaiSp Add(TLoaiSp loaiSp)
        {
            throw new NotImplementedException();
        }

        public TLoaiSp Delete(string Maloai)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TLoaiSp> GetAllLoaiSp()
        {
            return _context.TLoaiSps;
        }

        public TLoaiSp GetLoaiSp(string Maloai)
        {
            return _context.TLoaiSps.Find(Maloai);
        }

        public TLoaiSp Update(TLoaiSp loaiSp)
        {
            throw new NotImplementedException();
        }
    }
}
