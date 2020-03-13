using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoalphabetic_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "omar salah mohamed";
            Console.Write("Real Name  : ");
            Console.WriteLine(name);
            //  to encrept 
            Console.Write("Encrepted Name  : ");
            Console.WriteLine(Encrept_Ceaser(name, "DKVQFIBJWPESCXHTMYAUOLRGZN"));
            //  to dencrept 
            Console.Write("Dencrepted Name : ");
            Console.WriteLine(Dencrept_Ceaser(Encrept_Ceaser(name, "DKVQFIBJWPESCXHTMYAUOLRGZN"), "DKVQFIBJWPESCXHTMYAUOLRGZN".ToLower()));



        }
        // func to encrept 

        static string Encrept_Ceaser(string name, string key)
        {

            string Result = string.Empty;
            string Alpha = "abcdefghijklmnopqrstuvwxyz";
            //string key = "DKVQFIBJWPESCXHTMYAUOLRGZN";


            // convert name to lower  case 
            string _name = name.ToLower();

            for (int j = 0; j < _name.Length; j++)
            {
                if (_name[j] == ' ')
                {
                    Result += ' ';
                    continue;

                }

                Result += key[(Alpha.IndexOf(_name[j])) ];
            }


            return Result;
        }

        // func to dencrept 

        static string Dencrept_Ceaser(string name ,string key)
        {

            string Result = string.Empty;
            string Alpha = "abcdefghijklmnopqrstuvwxyz";
            //string key = "DKVQFIBJWPESCXHTMYAUOLRGZN";

            // convert name to lower  case 
            string _name = name.ToLower();

            for (int j = 0; j < _name.Length; j++)
            {
                if (_name[j] == ' ')
                {
                    Result += ' ';
                    continue;

                }
             
               
                Result += Alpha[(key.IndexOf(_name[j]) ) ];
            }


            return Result.ToLower();
        }
    }
}
