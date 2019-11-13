using DapperMovieAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMovieAPI
{
    public interface IMovieRepository
    {
        Task<IEnumerable<MovieModel>> GetAllMovies();
        Task<MovieModel> GetMovieById(int id);

        Task<IEnumerable<DirectorModel>> GetAllDirectors();

        Task<int> AddMovie(CreateMovieModel movie);

    }
}
