using System.Collections.Generic;
using System.Threading.Tasks;
using eTickets.Models;

namespace eTickets.Services
{
   public interface IActorsService
   {
      // untuk menggunakan async, tambahkan Task()
      Task<IEnumerable<Actor>> GetAllAsync();

      // tidak menggunakan async
      // IEnumerable<Actor> GetAll();
      Task<Actor> GetByIdAsync(int id);
      Task AddAsync(Actor actor);
      Actor Update(int id, Actor newActor);
      void Delete(int id);
   }
}
