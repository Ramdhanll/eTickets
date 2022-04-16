namespace eTickets.Controllers
{
   using System.Linq;
   using System.Threading.Tasks;
   using eTickets.Data;
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.EntityFrameworkCore;

   public class ProducersController : Controller
   {
      private readonly AppDbContext _context;

      public ProducersController(AppDbContext context)
      {
         _context = context;
      }

      public async Task<IActionResult> Index()
      {
         var allProducers = await _context.Producers.ToListAsync();
         return View(allProducers);
      }


   }
}