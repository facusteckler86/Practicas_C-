class Programa
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona();
        persona1.SetNombre("Facundo");
        persona1.SetApellido("Steckler");
        persona1.SetEdad(39);
        persona1.SetMail("facundomsteckler@gmail.com"); 
    }
}


public class Persona
{

    private string nombre;
    private string apellido;
    private int edad;
    private string mail;

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

    public static Saludar()
    {
        return $"Hola, mi nombre es {this.nombre}{this.apellido}, tengo {this.edad} y mi mail es {this.edad} ";
    }

}






// Console.WriteLine("mi primer linea en C#");

