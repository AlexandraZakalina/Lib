using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using VIN_LIB;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vin = "AA345678991234567";
            string mark = "a111aa123";
            string mark1 = "a100aa123";
            string mark2 = "a200aa123";
            
            bool a = VIN_LIB.VIN_LIB.CheckVIN(vin);
            string b = VIN_LIB.VIN_LIB.GetVINCountry(vin);
            string c = VIN_LIB.VIN_LIB.GetTransportYear(vin);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            
        }
    }
}
