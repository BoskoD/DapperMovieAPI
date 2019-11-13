using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMovieAPI.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DirectorName { get; set; }
        public short ReleaseYear { get; set; }
    }
}
