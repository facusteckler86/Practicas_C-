namespace Persona.Dominio;

public class Docente : Persona
{
    private string _materia;
    public string Materia
    {
        get { return _materia; }
        set { _materia = value; }
    }
    
}