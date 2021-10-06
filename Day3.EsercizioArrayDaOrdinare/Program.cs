using System;

namespace Day3.EsercizioArrayDaOrdinare
{
    class Program
    {
        static void Main(string[] args)
        {
            //metodo come Paola

            int[] ar = new int[] { 3, 1, 10, 9, 5 };

            int x;
            for (int j = 0; j < ar.Length; j++)
            {

                for (int i = 0; i < ar.Length - 1; i++)
                {
                    if (ar[i] > ar[i + 1])
                    {
                        x = ar[i];
                        ar[i] = ar[i + 1];
                        ar[i + 1] = x;       //in questo modo alla fine del ciclo in i il max arriva ad essere l'ultimo

                    }
                }


            }

            for (int n = 0; n < ar.Length; n++)
            {
                Console.WriteLine(ar[n]);
            }


            //  int[] arOrdinato = new int[ar.Length];




            /*
            int min = ar[0];
            int box;




            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }


            }

            Console.WriteLine(min);
            */






        }




    }
}

