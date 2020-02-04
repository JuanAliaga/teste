using System;

namespace EXAluguelVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudantes[] vect = new Estudantes[10];

            int n = int.Parse(Console.ReadLine());

            for(int i =  1; i <= n; i++)
            {
                Console.WriteLine("Nome:");
                string name = Console.ReadLine();
                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto:");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudantes(name, email);

            }
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ":" + vect[i]);
                }
            }
        }
    }
}
