using Microsoft.EntityFrameworkCore;
using MyStudyApp.Models.Domain;

namespace MyStudyApp.Models.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> options): base(options)
        {

        }
        //Create a Regions table for us and establist connection
        public DbSet<Region> Regions  { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
