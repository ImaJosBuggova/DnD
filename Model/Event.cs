using System.Drawing;

namespace DnD.Model;

public class Event
{
    public int Id { get; set; }

    public virtual List<Event> Events { get; set; } = [];

    // Position of the event in the Editor
    public Point Position { get; set; }
}