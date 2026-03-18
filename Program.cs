using System;

public static class Program
{
	public static void Main()
	{
		// Demo: crear un Robot y mostrar información en consola
		var rueda = new RuedaDeCaucho();
		var oruga = new Oruga();

		var robot1 = new Robot("SN-001", 120, rueda);
		Console.WriteLine($"Robot inicial: {robot1.NumeroSerie} - Potencia: {robot1.PotenciaBase} - Desgaste: {robot1.TipoTraccion?.DesgastePorUso}");

		robot1.Recorrer(10);
		Console.WriteLine($"Después de recorrer: Potencia: {robot1.PotenciaBase}");

		// Mantener la consola abierta al ejecutar desde IDE/VSCode si lo deseas
		// Console.ReadLine();
	}
}

