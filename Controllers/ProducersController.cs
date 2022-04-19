namespace eTickets.Controllers
{
   using System.Linq;
   using System.Threading.Tasks;
   using eTickets.Data;
   using eTickets.Models;
   using eTickets.Services;
   using Microsoft.AspNetCore.Mvc;
   using Microsoft.EntityFrameworkCore;

   public class ProducersController : Controller
   {
      private readonly IProducersService _service;


      public ProducersController(IProducersService service)
      {
         _service = service;
      }

      public async Task<IActionResult> Index()
      {
         var allProducers = await _service.GetAllAsync();
         return View(allProducers);
      }

      public IActionResult Create()
      {
         return View();
      }

      [HttpPost]
      public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Producer producer)
      {
         if (!ModelState.IsValid)
         {
            return View(producer);
         }

         await _service.AddAsync(producer);
         return RedirectToAction(nameof(Index));
      }

      public async Task<IActionResult> Details(int id)
      {
         var producerDetails = await _service.GetByIdAsync(id);

         if (producerDetails == null) return View("NotFound");
         return View(producerDetails);
      }

      public async Task<IActionResult> Edit(int id)
      {

         var producerDetails = await _service.GetByIdAsync(id);

         if (producerDetails == null) return View("NotFound");
         return View(producerDetails);
      }


      [HttpPost]
      public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Bio")] Producer producer)
      {
         if (!ModelState.IsValid)
         {
            return View(producer);
         }

         await _service.UpdateAsync(id, producer);
         return RedirectToAction(nameof(Index));
      }

      public async Task<IActionResult> Delete(int id)
      {

         var producerDetails = await _service.GetByIdAsync(id);
         if (producerDetails == null) return View("NotFound");
         return View(producerDetails);
      }

      [HttpPost, ActionName("Delete")]
      public async Task<IActionResult> DeleteConfirmed(int id)
      {
         var producerDetails = await _service.GetByIdAsync(id);
         if (producerDetails == null) return View("NotFound");

         await _service.DeleteAsync(id);
         return RedirectToAction(nameof(Index));
      }

   }
}