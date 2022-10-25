#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.modelo;

namespace RazorPagesFilmes.Data
{
    public class RazorPagesFilmesContext : DbContext
    {
        public RazorPagesFilmesContext (DbContextOptions<RazorPagesFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFilmes.modelo.filme> filme { get; set; }
    }
}
