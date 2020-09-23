using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double area,bas,alt;// Variaveis  Double area, bas(BASE), alt(ALTURA)
            Console.Clear();
            Console.Write("+--------------------------+\n");
            Console.Write("| AREA TRIANGULO RETANGULO |\n");
            Console.Write("+--------------------------+\n");

            Console.Write("Base em centimetros :");                  
            bas = Convert.ToDouble(Console.ReadLine());// entrada BASE


            Console.Write("\nAltura em centimetros :");
            alt = Convert.ToDouble(Console.ReadLine());// entrada ALTURA

            area =bas*alt/2; // area=base*altura/2

           Console.WriteLine($"\n Area do triangulo é {area} cm^2");// mostrar resultado

           Console.Write("Pronto ?"); //sair?
           Console.ReadKey();

           Console.Clear();
        }
    }
}
