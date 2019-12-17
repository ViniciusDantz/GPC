using GPC.Models;
using Microsoft.EntityFrameworkCore;

namespace GPC.Services
{
    public class GPC_Context : DbContext
    {
        public GPC_Context (DbContextOptions<GPC_Context> options) : base(options) { }
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Placar> Placar { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}