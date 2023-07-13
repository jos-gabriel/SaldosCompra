internal class Program
{
    private static void Main(string[] args)
    {
        double montoInicial = 13000.0;
        double montoFinal = 0.0;

        UInt16 Tcompras = Convert.ToUInt16(Console.ReadLine());
        double[] ArrayCompras;

        ArrayCompras = new double[Tcompras];

        for (UInt16 f = 0; f < Tcompras; f++)
        {
            Console.WriteLine("Ingrese valor de la compra:");

            //ArrayCompras[f] =  Convert.ToDouble(Console.ReadLine());

            montoInicial -= Convert.ToDouble(Console.ReadLine());


        }



        Console.WriteLine(montoInicial);

    }
}