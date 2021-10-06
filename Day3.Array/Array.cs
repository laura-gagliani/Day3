using System;

namespace Day3.Array
{
    class Array
    {
        static void Main(string[] args)
        {
            

            string[] arrayDiStringhe = new string[3]; //array di stringhe di dimensione esplicita pari a 3

            //così come è ora è vuoto
            //riempiamolo (per ora manualmente)

            arrayDiStringhe[0] = "alfa";
            arrayDiStringhe[1] = "beta";
            arrayDiStringhe[2] = "gamma";

            //  arrayDiStringhe[3] = "delta"; //riempimento SBAGLIATO! oltre il limite dimensionale
            // se ne accorge mentre compila, e va in Eccezione

            #region lunghezza array, popolazione e modifica con ciclo for
            // es se sto riempiendo l'array con un ciclo for devo mettere una condizione di uscita
            // che mi assicuri la rottura del loop quando l'array è pieno

            int lunghezzaArray = arrayDiStringhe.Length; // questo restituisce il numero di elementi

            string[] array2 = { "ciao", "buon pomeriggio" }; //dimens implicita 2, già riempito

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] += " Laura";
                Console.WriteLine(array2[i]); //comando di stampa di elemento i-esimo dell'array
            }

            // i[0] diventa ciao Laura
            // i[1] diventa buon pomeriggio Laura

            // nelle condizioni del for posso anche esplicitare un lungArray2 = array2.Length, e poi
            // mettere i < lungArray2 (stessa cosa, passaggio in più)

            #endregion


            #region modificare gli elementi con foreach? DUBBIO


            foreach (string nth in array2)
            {
              // s = s += " Laura";                 col foreach non si possono fare modifiche? non si sa
              //  Console.WriteLine(s);
            }


            // DUBBI connessi all'immutabilità del tipo stringa? giustamente si entra in un casino
            // il foreach di fatto lavora sugli oggetti/certi tipi di raccolte, non itera sugli indici...?
            // insomma vai col ciclo for e vai tranquilla
            #endregion


            #region type inference

            var array3 = new[] { 1, 2, 3 }; //in questo caso VS capisce che è un int[]
            var array4 = new[] { 1.1, 1.3, 4.5 };  // qui lo prende come double

            var array5 = new[] { 1, 2, 3d }; // se voglio che es. questo contenga double devo specificare!!
                                             // sennò lui assume la possibilità più semplice

            // var array6 = new[] { 1, 2.3, "abc" }; // di questo non capisce proprio il senso!! 


            #endregion


            #region array multidimensionali

            int[,] matrice1 = new int[2, 3]; // matrice 2x3

            matrice1[0, 0] = 1; //popolo gli elementi sfruttando gli indici
            matrice1[0, 1] = 2;

            #endregion

        }
    }
}
