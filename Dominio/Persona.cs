namespace Persona.Dominio;

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

