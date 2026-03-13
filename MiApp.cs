
Persona persona1 = new Persona();
persona1.SetNombre("Facundo");
persona1.SetApellido("Steckler");
persona1.SetEdad(39);
persona1.SetMail("facundomsteckler@gmail.com");

Console.WriteLine(persona1.Saludar())

public class Persona
{

    private string? nombre;
    private string? apellido;
    private int edad;
    private string? mail;

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void SetApellido(string apellido)
    {
        this.apellido = apellido;
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }

    public void SetMail(string mail)
    {
        this.mail = mail;

    }

  public string Saludar()
{
    
    return $"Hola, mi nombre es {this.nombre} {this.apellido}, tengo {this.edad} años y mi mail es {this.mail}";
}

}







// Console.WriteLine("mi primer linea en C#");

