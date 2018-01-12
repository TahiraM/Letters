using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LetterCount
{
    public class Program
    {
        private static cars newadd = new cars();

        public static void ViewRecords()
        {
            Console.WriteLine("_______________________________________________________________"); 
 
 
 
            Console.WriteLine("Car ID Number       Price   Model   Colour "); 
 
            Console.WriteLine("_______________________________________________________________"); 
 
 
 
            for (int i = 0; i < 1000; i++) 
            { 
 
                 Console.Write("{0, -5}", i + 1); 
 
                 Console.Write("{0, -19}", newadd.newcars[i].IdNum); 
 
                 Console.Write("{0, -7}", newadd.newcars[i].price); 
 
                 Console.Write("{0, -17}", newadd.newcars[i].model); 
 
                 Console.Write("{0, -7}", newadd.newcars[i].colour);
 
                 Console.WriteLine(); 
 
            } 
    
            Console.WriteLine("_______________________________________________________________");
        }

        static public void InputRecords()
        {
            Console.Write("Car ID Number: ");
            string c = Console.ReadLine();
            int Idnum = Convert.ToInt32(c);

            Console.Write("Car Price: ");
            string p = Console.ReadLine();
            int pri = Convert.ToInt32(p);

            Console.Write("Car Model: ");
            string modl = Console.ReadLine();

            Console.Write("Car Colour: ");
            string color = Console.ReadLine();

            newadd.AddRecord(Idnum,pri,modl,color);

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to add a record (add) or view all records (view)?");
            string reply = Console.ReadLine();

            if (reply == "add")
            {
                Console.WriteLine("how many cars would you like to input?");
                string h = Console.ReadLine();
                int amount = Convert.ToInt32(h);

                for(int i = 1; i <= amount; i++)
                {
                    InputRecords();
                }

                Console.WriteLine("Would you now like to view all the records? (yes/no)");
                string nowview = Console.ReadLine();

                if (nowview == "yes")
                {
                    ViewRecords();
                } 
            }
            
            if (reply == "view")
            {
                ViewRecords();
            }

        }
    }
    }



