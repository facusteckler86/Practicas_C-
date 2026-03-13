Persona persona1 = new Alumno(); 

persona1.SetNombre("Facundo");
persona1.SetApellido("Steckler");
persona1.SetEdad(39);
persona1.SetMail("facundomsteckler@gmail.com");

// Faltaba el punto y coma al final
Console.WriteLine(persona1.Saludar());


public class Persona
{
    // Campos protegidos para que las clases hijas (como Alumno) puedan acceder a ellos
    protected string? nombre;
    protected string? apellido;
    protected int edad;
    protected string? mail;

    public void SetNombre(string nombre) => this.nombre = nombre;
    public void SetApellido(string apellido) => this.apellido = apellido;
    public void SetEdad(int edad) => this.edad = edad;
    public void SetMail(string mail) => this.mail = mail;

    // El método Saludar DEBE estar dentro de las llaves de la clase
    public string Saludar()
    {
        return $"Hola, mi nombre es {this.nombre} {this.apellido}, tengo {this.edad} años y mi mail es {this.mail}";
    }
}



// El colocar los dos puntos, esta clase hereda los atributos de la clase Persona
public class Alumno : Persona
{
    
}







// Console.WriteLine("mi primer linea en C#");

