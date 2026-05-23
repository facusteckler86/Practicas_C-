using System;

public class Book
{
    private string _name;
    private string _author;
    private string _text;

    public Book(string name, string author, string text)
    {
        _name = name;
        _author = author;
        _text = text;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Author
    {
        get => _author;
        set => _author = value;
    }

    public string Text
    {
        get => _text;
        set => _text = value;
    }

    public string ReplaceWordInText(string word, string text)
    {
        return _text.Replace(word, text);
    }

    public bool IsWordInText(string word)
    {
        return _text.Contains(word);
    }

    public void PrintTextToConsole()
    {
        Console.WriteLine(_text);
    }

    public class BookPrinter
    {
        public void PrintTextToconsole(string text)
        {
            Console.WriteLine(text);
        }

        public void PrintTextToAnotherMedium(string text)
        {
            // Aca se aplica la logica para enviar el texto a otro dispositivo
            Console.WriteLine($"[Otro medio] (text)");
        }
    }
}


