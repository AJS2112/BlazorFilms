using BlazorFilms.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFilms.UI.Interfaces
{
    public interface IFilmService
    {
        Task<IEnumerable<Film>> GetAll();
        Task<Film> GetById(int id);
        Task<bool> DeleteFilm(int id);
        Task<bool> SaveFilm(Film film);
    }
}
