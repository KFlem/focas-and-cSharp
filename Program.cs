using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sample1
{

    
    class Program
    {   
        
        private static ushort _handle = 0;
        private static short _ret = 0;



        public static void Connect(string ipaddr)
        {

            _ret = Focas1.cnc_allclibhndl3(ipaddr, 8193, 6, out _handle);
            
            // Write the result to the console
            if (_ret == Focas1.EW_OK)
            {

                Console.WriteLine("We are connected!");
            }
            else
            {
                Console.WriteLine("There was an error connecting. Return value: " + _ret);
            }

            // Free the Focas handle
            Focas1.cnc_freelibhndl(_handle);
        }



        static void Main(string[] args)
        {   
            string ipaddr = "";
            Connect(ipaddr);
            







            
            /*
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
            */
        }
    }
}
