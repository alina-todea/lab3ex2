using System;
using System.Collections.Generic;

namespace Lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              
             Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri de caractere fiind citite de la tastatura

         
             */

            Console.WriteLine("Introduceti un string de caractere");

            string message = Console.ReadLine();

            Console.WriteLine("Introduceti un substring de caractere");

            string text = Console.ReadLine();

            //Console.WriteLine(LastChar(text));

            if (message.IndexOf(text)>0)

            { 
                int primaPozitie = message.IndexOf(text);
                int ultimaPozitie = primaPozitie + text.Length-1;
                Console.WriteLine($"substringul \"{text}\" apare prima data in stringul: \"{message}\" intre pozitiile {primaPozitie} - {ultimaPozitie}");
            }
            else
            {
                Console.WriteLine($"substringul \"{text}\" nu apare in stringul \"{message}\" ");
            }


            //List<int> list = GetPositions(message, text);


        }
/*

        static char LastChar(string n)
        {
            
            char lastCharacter = n[n.Length - 1];
            return lastCharacter;
        }


        public List<int> GetPositions(string source, string searchString)
        {
            List<int> ret = new List<int>();
            int len = searchString.Length;
            int start = -len;
            while (true)
            {
                start = source.IndexOf(searchString, start + len);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    ret.Add(start);
                }
            }
            return ret;
            
        }*/
    }

    }



