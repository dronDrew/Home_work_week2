using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using myClass_lib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Soviet_tank = "T34";
                string German_tank = "Pantera";
                int tank_number = 5;
                Tank[] crew_sov = new Tank[tank_number];
                Tank[] crew_ger = new Tank[tank_number];
                for (int i = 0; i < tank_number; i++)
                {
                    crew_sov[i] = new Tank(Soviet_tank);
                    Thread.Sleep(100);
                    crew_ger[i] = new Tank(German_tank);
                }
                for (int i = 0; i < tank_number; i++)
                {
                    Console.WriteLine(crew_sov[i] ^ crew_ger[i]);
                }
            }
            catch (ArgumentException a)
            {
                Console.WriteLine(a.Message);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
