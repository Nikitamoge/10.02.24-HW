using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task1
class Film : IDisposable
{
    private bool disposed = false;
    public string Title { get; set; }
    public string Studio { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public int Year { get; set; }

    public Film(string title, string studio, string genre, int duration, int year)
    {
        Title = title;
        Studio = studio;
        Genre = genre;
        Duration = duration;
        Year = year;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
        {
        }
        disposed = true;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Studio: {Studio}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Duration: {Duration} minutes");
        Console.WriteLine($"Year: {Year}");
    }

    ~Film()
    {
        Dispose(false);
        Console.WriteLine($"Film '{Title}' has been removed from memory.");
    }
}

//Task 2
class Spectacle : IDisposable
{
    private bool disposed = false;
    public string title { get; set; }
    public string nameOfTheatre { get; set; }
    public string genre { get; set; }
    public int Duration { get; set; }
    public int listOfActors { get; set; }

    public Spectacle(string title, string nameOfTheatre, string genre, int duration, int listOfActors)
    {
        this.title = title;
        this.nameOfTheatre = nameOfTheatre;
        this.genre = genre;
        Duration = duration;
        this.listOfActors = listOfActors;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
        {
        }
        disposed = true;
    }

    ~Spectacle()
    {
        Dispose(false);
        Console.WriteLine($"Spectacle '{title}' has been removed from memory.");
    }
}
