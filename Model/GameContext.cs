using Microsoft.EntityFrameworkCore;

namespace DnD.Model;

public class GameContext : DbContext
{
    public DbSet<Event> Events { get; set; }
}