using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Inserire codice di adesione");

            string codiceIns = Console.ReadLine();

            Console.WriteLine("\n Inserire password");

            string pwIns = Console.ReadLine();

            string codiceCorretto = "123456";
            string pwCorretta = "1234";

            int tentativi = 3;
           

            while (tentativi != 0)
            {
                if (codiceCorretto == codiceIns && pwCorretta == pwIns)
                {
                    Console.WriteLine("login effettuato");
                    return;
                }

                else
                {
                    Console.WriteLine("prova di nuovo");

                    codiceIns = Console.ReadLine();
                    pwIns = Console.ReadLine();

                    tentativi--;

                }
            }
            
            if (codiceCorretto == codiceIns && pwCorretta == pwIns)
            {
                Console.WriteLine("login effettuato");

            }

            else
            {
                Console.WriteLine("account bloccato");
            }


            //do
            //{
            //    if (codiceIns == codiceCorretto && pwIns == pwCorretta)
            //    {
                   
            //        successo = true;
            //        return;

            //    }

            //    else
            //    {
            //        Console.WriteLine($"\n Errore inserimento dati. Tentativi rimasti: {cicli}");
                    

            //        Console.WriteLine("\n Inserire codice di adesione");
            //        codiceIns = Console.ReadLine();

            //        Console.WriteLine("\n Inserire password");
            //        pwIns = Console.ReadLine();

            //        cicli--;
                    

            //    }
            //} while (cicli != 0 && successo == false) ;


            //// commento: riprova come ha fatto Stefania, dove lo if (corretto) non è in cima, e non c'è il problema
            //// di dover "tornar su" dopo che il contatore è andato a zero.
            ////insomma riorganizzare flusso logico


            //if (successo == true)
            //{
            //    Console.WriteLine("\n Codice e password corretti. Login effettuato con successo");
            //}
            //else
            //{
            //    Console.WriteLine("Errore, account bloccato");
            //}


            //if (cicli == 0) 
            //{
            //    Console.WriteLine("\n Tentativi esauriti. Account bloccato");
            //    return;
            //}
            
                

        }
    }
}
