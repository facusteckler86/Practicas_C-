// Objetos del codigo

Persona persona1 = new Alumno();

persona1.SetNombre("Facundo");
persona1.SetApellido("Steckler");
persona1.SetEdad(39);
persona1.SetMail("facundomsteckler@gmail.com");
persona1.SetDni(15000000);


Console.WriteLine(persona1.Saludar());

// Objeto visitante (ejrecicio 08)

Visitante visitante1 = new Visitante();

visitante1.SetNombre("Juan");
visitante1.SetApellido("Perez");
visitante1.SetEdad(18);
visitante1.SetMail("juanperez@mail.com");
visitante1.SetDni(12345600);

Console.WriteLine(visitante1.Saludar());

// Objeto guardia (ejrecicio 08)

Guardia guardia1 = new Guardia();
guardia1.SetNombre("Marcelo");
guardia1.SetApellido("Perez");
guardia1.SetEdad(25);
guardia1.SetMail("marceperez@mail.com");
guardia1.SetDni(10000000);

Console.WriteLine(guardia1.Saludar());
Console.WriteLine(guardia1.ControlarDocumento(visitante1.GetDni(), visitante1.GetNombre()));



public class Persona
{
    // Campo protegido para que las clases hijas (como Alumno) para que se pueda acceder - Son las propiedades, atributos de los objetos
    protected string? nombre;
    protected string? apellido;
    protected int edad;
    protected string? mail;

    protected int Dni;

    public void SetNombre(string nombre) => this.nombre = nombre;
    public void SetApellido(string apellido) => this.apellido = apellido;
    public void SetEdad(int edad) => this.edad = edad;
    public void SetMail(string mail) => this.mail = mail;
    public void SetDni(int Dni) => this.Dni = Dni;

    public int GetDni() => this.Dni;
    public string GetNombre() => this.nombre ?? "";


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
    public string ControlarDocumento(int Dni, string nombre)
    {
        return "Estoy controlando el Dni de : " + nombre + "" + " Con DNI: " + Dni;
    }
}

// Creo la clase guardia como lo indica el ejercicio 08
public class Guardia : Persona
{

    public string ControlarDocumento(int Dni, string nombre)
    {
        return "Estoy controlando el Dni de : " + nombre + "" + " Con DNI: " + Dni;
    }

}










// Console.WriteLine("mi primer linea en C#");

