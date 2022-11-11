using System.ComponentModel.DataAnnotations;

namespace ODataTutorial.Entities;

public class Note
{
    public Guid Id { get; set; }
    [Required]
    public string MessageNote { get; set; } = default!;
}

public static class Notes
{
    public static IReadOnlyList<Note> Items = new List<Note>
    {
        new Note {Id = Guid.NewGuid(), MessageNote = "Test"}
    };
}