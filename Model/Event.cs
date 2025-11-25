namespace DnD.Model;

public class Event
{
    public int Id { get; set; }
    
    public virtual List<Event> Events { get; set; } = [];
}