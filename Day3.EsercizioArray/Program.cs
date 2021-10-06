using System;

namespace Day3.EsercizioArray
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //dato array di 5 interi, verificare che gli elementi siano in ordine crescente

            //svolgimento
            //1. inizializzo array
            //2. controllo ordine, es. ciclo for e confronto i vs i+1

            //test 1 già ordinato, test 2 in disordine

           // int[] ar = new int[] { 1, 2, 3, 4, 6 };
            int[] ar = new int[] { 3, 4, 6, 9, 1 };

            bool ordineCorretto = true;

           // int l = ar.Length;
           //  Console.WriteLine(l);

            for (int i=0; i<ar.Length-1; i++) //mi fermo a -1, comunque includo l'ultimo elemento con i+1
            {
                if (ar[i] > ar[i + 1])    //ogni i-esimo deve essere minore o uguale del successivo
                {
                    ordineCorretto = false;
                    // break; //LINEA AGGIUNTA DA ALESSANDRA: BASTA CHE TROVI IL PRIMO CONFRONTO "SBAGLIATO"

                }
            }

            if (ordineCorretto == true)
            {
                Console.WriteLine("array in ordine crescente");
            }

            else
            {
                Console.WriteLine("array non in ordine crescente");
            }

            


        }
    }
}
