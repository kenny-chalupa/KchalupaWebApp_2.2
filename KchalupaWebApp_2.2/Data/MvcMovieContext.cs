using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KchalupaWebApp_2._2.Controllers;

namespace KchalupaWebApp_2._2.Models
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<KchalupaWebApp_2._2.Controllers.Movie> Movie { get; set; }
    }
}
