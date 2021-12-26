using BlazorFilms.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFilms.Data.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private string _connectionString;
        public FilmRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public Task<bool> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Film>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Film> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertFilm(Film film)
        {
            var db = dbConnection();
            var sql = @"
                        INSERT INTO Films (Title, Director, ReleaseDate) 
                        VALUES (@Title, @Director, @ReleaseDate)
                        ";
            var result = await db.ExecuteAsync(sql.ToString(), 
                new {film.Title,film.Director,film.ReleaseDate });

            return result > 0;
        }

        public Task<bool> UpdateFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}
