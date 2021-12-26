using BlazorFilms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFilms.Data.Repositories
{
    public interface IFilmRepository
    {
        Task<IEnumerable<Film>> GetAll();
        Task<Film> GetById(int id);
        Task<bool> InsertFilm(Film film);
        Task<bool> UpdateFilm(Film film);
        Task<bool> DeleteFilm(int id);
    }
}
