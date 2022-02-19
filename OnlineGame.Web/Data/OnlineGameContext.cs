using System.Data.Entity;
using OnlineGame.Web.Models;

namespace OnlineGame.Web.Data
{
    public class OnlineGameContext : DbContext
    {
        public DbSet<Gamer> Gamers { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}