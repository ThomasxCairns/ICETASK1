using System;
class Time
{
    static void Main(string[] args)
    {
        int count = 0;
        int N = 0;
        Console.WriteLine("Number of tests");
        int T = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of markers");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of questions");
        int Q = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < Q+1; i++)
        {
            Console.WriteLine("Number of sub for Question "+ i);
            N = Convert.ToInt32(Console.ReadLine());
        }

        int MARKS = N * Q;
        int TICKS = MARKS * 2;
        int FINALSECONDS = TICKS * T;

        if (FINALSECONDS / 60 == 0)
        {
            Console.WriteLine("BLAD BADLD A");
            count++;
        }
        else
        {
            do
            {
                int rem = FINALSECONDS % 60;
                if (rem >=30)
                {
                    count++;
                }
                
            } while (FINALSECONDS / 60 != 0);
        }
        for (int i = 1; i < M+1; i++) {
            Console.WriteLine(" lec " + i + " will mark 0"+T+" papers and it will take "+ count+" minutes");
        }
      

    }
}
