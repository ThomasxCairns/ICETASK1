using System;
using System.Net;
using System.Runtime.InteropServices;

namespace IceTask
{
    class prog
    {
        static void Main(string[] args)
        {
            int Store = 0;
            Console.WriteLine("How many scripts are there ?");
            int Scripts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many lecturers are there ?");
            int Lecturers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many questions are there ?");
            int Questions = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < Questions + 1; i++)
            {
                Console.WriteLine("What is the subtotal of question " + i);
                int subTotal = Convert.ToInt32(Console.ReadLine());
                Store = Store + subTotal;
            }
            int Papers = Scripts / Lecturers;
            int rem = Scripts % Lecturers;
            int TotalSeconds = (Store * Papers) * 2;
            int finalrem = Papers + rem;

            for (int i = 1; i < Lecturers; i++)
            {
                int totaltime = TotalSeconds * Papers;
                int hrs = totaltime / 3600;
                int mnts = totaltime / 60 % 60;
                int scs = totaltime % 60;
                if (scs >= 30)
                {
                    mnts = mnts + 1;
                }
                Console.WriteLine("Lecturer " + i + " is marking " + Papers + " which will take " + hrs + " hours or " + mnts + " minutes ");
            }
            int tltfinal = TotalSeconds * (Papers + rem);
            int hrss = tltfinal / 3600;
            int mntss = tltfinal / 60 % 60;
            int secondss = tltfinal % 60;
            if (secondss >= 30)
            {
                mntss = mntss + 1;
            }
            Console.WriteLine("Lecturer " + Lecturers + " is marking " + finalrem + " which will take " + hrss + " hours or " + mntss + " minutes ");

        }
    }

}