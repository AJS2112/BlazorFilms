using BlazorFilms.Model;
using BlazorFilms.UI.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorFilms.UI.Services
{
    public class FilmService : IFilmService
    {
        public Task<bool> DeleteFilm(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Film>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Film> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveFilm(Film film)
        {
            throw new System.NotImplementedException();
        }
    }
}
