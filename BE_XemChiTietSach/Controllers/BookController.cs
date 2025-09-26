using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            // Lấy sách có ID = 1 nếu không có id parameter
            var bookId = id ?? 1;
            var book = await _context.Books.FirstOrDefaultAsync(b => b.Id == bookId);
            
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        public IActionResult Buy()
        {
            return View();
        }
    }
}