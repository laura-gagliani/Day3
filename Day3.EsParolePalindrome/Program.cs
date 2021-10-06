using System;

namespace Day3.EsParolePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("la parola è palindroma?\n");

            //char[] parola = new char[] { 'o', 'r', 't', 'o' };
            // char[] parola = new char[] { 'o', 't', 't', 'o' };
            //char[] parola = new char[] { 'w', 'o', 'w'};
            char[] parola = new char[] { 'o', 'n', 'o', 'r','a','r','o','n','o' };

            int length = parola.Length;

            bool corrispondenza = true;

            for (int i = 0; i <= length/2; i++)
            {
                if (parola[i] != parola[length - 1 - i])
                {
                    corrispondenza = false;
                }
            }

            if(corrispondenza == true)
            {
                Console.WriteLine("la parola è palindroma");
            }

            else
            {
                Console.WriteLine("la parola non è palindroma");
            }


        }
    }
}
