using System;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

public class BookPersistence
{
    public void SaveTextToFile(Book book, string filePath)
    {
        Console.WriteLine($"Texto guardado en {filePath}");
    
    try{
        File.WriteAllText(filePath, book.Text);
        Console.WriteLine($"Texto guardado en {filePath}");
    }
    catch(Exception ex)
    {
        Console.Error.WriteLine($"Error al guardar el archivo: {ex.Message}");
    }
}
}
