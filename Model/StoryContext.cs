using Microsoft.EntityFrameworkCore;

namespace DnD.Model;

public class StoryContext : DbContext
{
    public DbSet<Event> Events { get; set; }
}