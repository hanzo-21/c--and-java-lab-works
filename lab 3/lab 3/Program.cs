using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //wap to illustrate the concept of class , object , method in c

            EverestEngineering _eec = new EverestEngineering("Aayush", "imadol", 44, "Umesh");
            Console.WriteLine(_eec.introduceString());
            Console.ReadKey();

            */

            EncapsulationExample _example = new EncapsulationExample();

            _example.Name = "Sato Nakamura";
            _example.Location = "Nipon, Tokyo, Ikebukuro.";

            Console.WriteLine("Hello, My name is "+_example.Name+".\nI live in "+_example.Location);
            Console.ReadKey();

            /*
             *  This is a demonstration of encaspaluation as program.cs dosn't direcly change the
             *  private value of class( name , location ) but indirectly through public value
             *  ( Name, Location ).
             */

        }
    }
}
