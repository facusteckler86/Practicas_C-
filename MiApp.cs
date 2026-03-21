
namespace Persona.Dominio;

public class Profesor : Persona
{

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



public static class MiAppDemo
{
    public static void Run()
    {
        Persona persona1 = new Alumno();
        persona1.SetNombre("Facundo");
        persona1.SetApellido("Steckler");
        persona1.SetEdad(39);
        persona1.SetMail("facundomsteckler@gmail.com");
        persona1.SetDni(15000000);

        Console.WriteLine(persona1.Saludar());

        Visitante visitante1 = new Visitante();
        visitante1.SetNombre("Juan");
        visitante1.SetApellido("Perez");
        visitante1.SetEdad(18);
        visitante1.SetMail("juanperez@mail.com");
        visitante1.SetDni(12345600);

        Console.WriteLine(visitante1.Saludar());

        Guardia guardia1 = new Guardia();
        guardia1.SetNombre("Marcelo");
        guardia1.SetApellido("Perez");
        guardia1.SetEdad(25);
        guardia1.SetMail("marceperez@mail.com");
        guardia1.SetDni(10000000);

        Console.WriteLine(guardia1.Saludar());
        Console.WriteLine(guardia1.ControlarDocumento(visitante1.GetDni(), visitante1.GetNombre()));
    }
}
}
