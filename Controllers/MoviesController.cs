namespace eTickets.Controllers
{
   using System.Linq;
   using System.Threading.Tasks;
   using eTickets.Data;
   using eTickets.Services;
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.EntityFrameworkCore;

   public class MoviesController : Controller
   {
      private readonly IMoviesService _service;

      public MoviesController(IMoviesService service)
      {
         _service = service;
      }

      public async Task<IActionResult> Index()
      {
         // join
         var allMovies = await _service.GetAllAsync(n => n.Cinema);
         return View(allMovies);
      }

      public async Task<IActionResult> Details(int id)
      {
         var movieDetails = await _service.GetByIdAsync(id);
         return View(movieDetails);
      }
   }
}