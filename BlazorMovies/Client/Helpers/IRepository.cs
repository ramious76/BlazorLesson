using BlazorMovies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}
