using System;

namespace PGJP
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] stringArray = { "amerika", "amerikani", "amerikanizmi" };
            

        int n = stringArray.Length;

            String parashtesa = PGJP.parashtesaPerbashket(stringArray, 0, n - 1);

            if (parashtesa.Length != 0)
            {
                Console.Write("Parashtesa me e gjate e perbashket eshte " + parashtesa);

                Console.WriteLine();
            }
            else
            {
                Console.Write("Nuk ka parashtese te perbashket");
            }


        }
    }
}
