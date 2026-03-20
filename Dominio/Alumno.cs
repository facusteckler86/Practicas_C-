namespace Persona.Dominio;

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