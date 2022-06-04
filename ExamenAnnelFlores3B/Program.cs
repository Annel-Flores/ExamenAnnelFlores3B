using System;
using ExamenAnnelFlores3B;
public class program
{
    private static int length;

    private static void Main(string[] args)
    {
        Primaria primaria = new Primaria("Annel", "Flores", "Ruperto Mena", "1351214497", 500);
        Secundaria secundaria = Secundaria("Annel", "Flores", "5 de Junio", "1351214497", 6, 200);
        Universitarios universitarios = new Universitarios("Annel", "Flores", "1351214497", 300, 20);

        for (int i = length + 1; i >= 0; i++)
        {
            primaria.ImprimirDatos();
            primaria.Calcular();
            Console.WriteLine("");
            secundaria.ImprimirDatos();
            secundaria.Calcular();
            Console.WriteLine("");
            universitarios.ImprimirDatos();
            universitarios.Calcular();
        }
    }
}