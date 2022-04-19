using System.Threading.Tasks;
using eTickets.Base;
using eTickets.Models;
using eTickets.ViewModels;

namespace eTickets.Services
{
   public interface IMoviesService : IEntityBaseRepository<Movie>
   {
      Task<Movie> GetMovieByIdAsync(int id);
      Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
      Task AddNewMovieAsync(NewMovieVM data);
      Task UpdateMovieAsync(NewMovieVM data);

   }
}
