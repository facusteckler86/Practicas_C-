using System;
using System.IO;

public interface IBookPersistence
{
    void Save(Book book);
}

public class TextFilePersistance : IBookPersistence
{
    public void Save(Book book)
    {
        
        string filePath = $"{book.Name}.txt";
        File.WriteAllText(filePath,book.Text);
        Console.WriteLine($"Texto del libro guardado en archivo: {filePath}");
    }
}

public class DbPersistence : IBookPersistence
{
    public void Save(Book book)
    {
        Console.WriteLine($"Texto del libro '{book.Name}' guardado en la base de datos");
    }
}