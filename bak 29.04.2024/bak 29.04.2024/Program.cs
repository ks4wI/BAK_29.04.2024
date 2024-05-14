using System;

class Program
{
    static void Main(string[] args)
    {
        int[] T = new int[20];
        Random random = new Random();
        for (int o = 0; o < T.Length; o++)
        {
            T[o] = random.Next(-99, 100); 
        }

        int ms = int.MinValue; 
        int ip = 0;
        int ik = 0;
        int i, j;

        for (i = 0; i < T.Length; i++)
        {
            int bs = 0; 
            for (j = i; j < T.Length; j++)
            {
                bs += T[j];
                if (bs > ms)
                {
                    ms = bs; 
                    ip = i; 
                    ik = j; 
                }
            }
        }

        Console.WriteLine("Największa suma podciągu: " + ms);
        Console.WriteLine("Indeks pierwszego elementu podciągu: " + ip);
        Console.WriteLine("Indeks ostatniego elementu podciągu: " + ik);
    }
}
