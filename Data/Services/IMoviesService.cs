using System.Threading.Tasks;
using eTickets.Base;
using eTickets.Models;

namespace eTickets.Services
{
   public interface IMoviesService : IEntityBaseRepository<Movie>
   {
      Task<Movie> GetMovieByIdAsync(int id);
   }
}
