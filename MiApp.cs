Persona persona1 = new Alumno(); 

persona1.SetNombre("Facundo");
persona1.SetApellido("Steckler");
persona1.SetEdad(39);
persona1.SetMail("facundomsteckler@gmail.com");


Console.WriteLine(persona1.Saludar());

Visitante visitante1 = new Visitante();

visitante1.SetNombre("Juan");
visitante1.SetApellido("Perez");
visitante1.SetEdad(18);
visitante1.SetMail("juanperez@mail.com");

Console.WriteLine(visitante1.Saludar());


public class Persona
{
    // Campo protegido para que las clases hijas (como Alumno) para que se pueda acceder
    protected string? nombre;
    protected string? apellido;
    protected int edad;
    protected string? mail;

    public void SetNombre(string nombre) => this.nombre = nombre;
    public void SetApellido(string apellido) => this.apellido = apellido;
    public void SetEdad(int edad) => this.edad = edad;
    public void SetMail(string mail) => this.mail = mail;

   
    public string Saludar()
    {
        return $"Hola, mi nombre es {this.nombre} {this.apellido}, tengo {this.edad} años y mi mail es {this.mail}";
    }
}



// El colocar los dos puntos, esta clase hereda los atributos de la clase Persona
public class Alumno : Persona
{
    private int numeroDeMatricula;
    public int Matricula
    {
        get { return numeroDeMatricula; }
        set { numeroDeMatricula = value; }
    }
    
}

public class Profesor : Persona
{
    private int numeroDeLegajo;
    public int Legajo
    {
        get { return numeroDeLegajo; }
        set { numeroDeLegajo = value; }
    }
    
}

// Clase del dia 17/03/2026
public class Visitante : Persona
{
    
}










// Console.WriteLine("mi primer linea en C#");

