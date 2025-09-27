using Microsoft.AspNetCore.Mvc;
using BookStoreAPI.Data;
using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonHangController : ControllerBase
    {
        private readonly BookStoreContext _context;

        public DonHangController(BookStoreContext context)
        {
            _context = context;
        }

        // GET api/DonHang?ngay=2025-09-09&trangThai=Đang Xử lí
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DonHang>>> GetDonHangs(
            DateTime? ngay = null, string? trangThai = null)
        {
            var query = _context.DonHangs.AsQueryable();

            if (ngay != null)
                query = query.Where(d => d.NgayDatHang.Date == ngay.Value.Date);

            if (!string.IsNullOrEmpty(trangThai) && trangThai != "Tất cả")
                query = query.Where(d => d.TrangThai == trangThai);

            return await query.ToListAsync();
        }

        // GET api/DonHang/1
        [HttpGet("{id}")]
        public async Task<ActionResult<DonHang>> GetDonHang(int id)
        {
            var donhang = await _context.DonHangs.FindAsync(id);
            if (donhang == null) return NotFound();
            return donhang;
        }
    }
}
