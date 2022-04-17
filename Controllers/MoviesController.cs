namespace eTickets.Controllers
{
   using System.Linq;
   using System.Threading.Tasks;
   using eTickets.Data;
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.EntityFrameworkCore;

   public class MoviesController : Controller
   {
      private readonly AppDbContext _context;

      public MoviesController(AppDbContext context)
      {
         _context = context;
      }

      public async Task<IActionResult> Index()
      {
         // join
         var allMovies = await _context.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
         return View(allMovies);
      }
   }
}