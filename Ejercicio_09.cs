

public class Robot
{
    // llamada a los datos
    public string MostrarInformacion()
    {
        return "Numero de Serie: " + this.NumeroSerie + "" + "Potencia: " + this.PotenciaBase + "" + "Tipo de Traccion:" + this.TipoTraccion.GetType().Name + "Autonomia: " + this.TipoTraccion.Autonomia + this.TipoTraccion.DesgastePorUso ;
    }
    private string? _nroSerie;
    public string? NumeroSerie
    {
        get { return _nroSerie; }
        set { _nroSerie = value; }
    }

    private int _potenciaBase;
    public int PotenciaBase
    {
        get { return _potenciaBase; }
        set { _potenciaBase = value; }
    }

    private TipoTraccion? _tipoTraccion;
    public TipoTraccion? TipoTraccion
    {
        get { return _tipoTraccion; }
        set { _tipoTraccion = value; }
    }

    public void Recorrer(int distancia)
    {
        this.PotenciaBase = this.PotenciaBase - (this.TipoTraccion?.DesgastePorUso ?? 0);
    }

    public Robot(string nroSerie, int potenciaBase, TipoTraccion tipoTraccion)
    {
        this.NumeroSerie = nroSerie;
        this.PotenciaBase = potenciaBase;
        this.TipoTraccion = tipoTraccion;
    }
}

public abstract class TipoTraccion
{
    private int _desgastePorUso;
    public int DesgastePorUso
    {
        get { return _desgastePorUso; }
        set { _desgastePorUso = value; }
    }

    private int _autonomia;
    public int Autonomia
    {
        get { return _autonomia; }
        set { _autonomia = value; }
    }

}

public class RuedaDeCaucho : TipoTraccion
{
    public RuedaDeCaucho()
    {
        this.DesgastePorUso = 3;
        this.Autonomia = 100;
    }
}

public class Oruga : TipoTraccion
{
    private string? _sensor;
    public string? Sensor
    {
        get { return _sensor; }
        set { _sensor = value; }
    }
    public Oruga()
    {
        this.DesgastePorUso = 3;
        this.Autonomia = 400;
    }
}

public static class RobotDemo
{
    public static void Run()
    {
        Robot Robotina = new Robot("Robotina", 100, new RuedaDeCaucho());
        Console.WriteLine(Robotina.MostrarInformacion());
        Robotina.Recorrer(10);
        Console.WriteLine(Robotina.MostrarInformacion());
        Robotina.Recorrer(15000);
        Console.WriteLine(Robotina.MostrarInformacion());
    }
}

