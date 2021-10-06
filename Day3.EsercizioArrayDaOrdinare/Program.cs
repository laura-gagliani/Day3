using System;

namespace Day3.EsercizioArrayDaOrdinare
{
    class Program
    {
        static void Main(string[] args)
        {
            #region bubble sort (Paola)

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

            #endregion




            #region selection sort (come avevo pensato io)
            Console.WriteLine("\n\n");


            int[] v = new int[] { 2, 9, 1, 7, 12, 34, 2, 5 };

            int min;
            int index;
            int y;

            for (int m = 0; m < v.Length - 1; m++)
            {

                min = v[m];
                index = m;   // NB!! inizializzo a 0. questo perché il ciclo for non include nel confronto la posizione v[0], che invece potrebbe essere quella del min



                for (int n = m+1; n < v.Length; n++) //ciclo che trova il minimo tra gli elementi del vettore
                {
                    if (v[n] < min) //se trovi qualcosa minore del "min" assunto
                    {
                        min = v[n];  //sostituiscine il valore in min
                        index = n;   //e annotane la posizione all'interno del vettore in questa variabile
                    }
                }

                // finito questo for ottengo il valore minimo contenuto nel vettore e la sua posizione
                // l'obiettivo è ora di scambiare questo elemento con la prima posizione nel vettore

                y = v[m];
                v[m] = v[index];
                v[index] = y;   //con questi tre passaggi ho fatto lo scambio, il min è ora in prima posizione

                //tutto quanto ora deve essere ripetuto! inscatolamento in ciclo con 2ndo indice
                //ripetuto quante volte? quanti sono gli elementi nel vettore - 1, perché l'ultimo mi va a posto "da sé"

            }


            for (int p = 0; p < v.Length; p++)
            {
                Console.WriteLine(v[p]);
            }

            #endregion







        }




    }
}

