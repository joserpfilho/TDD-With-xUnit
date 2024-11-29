namespace Domain.Entities;

public record Task(string Title, 
                   DateTime DueDate, 
                   int Priority,
                   string? Description = null,
                   List<string>? Labels = null);
