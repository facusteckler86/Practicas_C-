using clases;

public class Formacion
{

    private List<Locomotora> _locomotoras;
    public List<Locomotora> Locomotoras
    {
        get { return _locomotoras; }
        set { _locomotoras = value; }
    }
    
    private Boolean _estaEnMovimiento;
    public Boolean EstaEnMovimiento
    {
        get { return _estaEnMovimiento; }
        set { _estaEnMovimiento = value; }
    }
    
}