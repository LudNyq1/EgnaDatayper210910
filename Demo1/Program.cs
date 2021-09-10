using System;
using System.Collections.Generic;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*Car myCar; //Vi berättar att vi från stack tänker använda ett Car objekt (Stacken)
            myCar = new Car(); //Här hämtar ett unikt objekt (Heap)

            myCar.Color = "Red";
            myCar.Make = "Volvo";
            myCar.Model = "V70";

            Console.WriteLine($"Din bil är en {myCar.Color} {myCar.Make} {myCar.Model}.");*/
            //Car[] Cars = new Car[]... detta orkar vi inte göra
            //Bästtre lösning är att använda List<T>
            //List är en inkapsling av Array och ger som metoder
            //för att manipulera listan enklare
            //Vi kallar det nu för en Collection
            List<Car> MyCars = new List<Car>();
            //MyCars.Add(myCar);

            MyCars.Add(new Car() {Color="Blue" , Make = "Testa" , Model = "Model S" });
            MyCars.Add(new Car() { Color = "Silver", Make = "Volvo", Model = "744-GL" });
            MyCars.Add(new Car() { Color = "Blue", Make = "Testa", Model = "Model S" });

            Console.WriteLine($"Vi erbjuder idag {MyCars.Count} bilar");
            Console.WriteLine("====================");

            foreach (Car c in MyCars)
            {
                Console.WriteLine($"{c.Color} {c.Make} {c.Model}");
            }


        }
    }

    public class Car //Car är en data typ
    {
        //Metoder(verb), egenskaper(adjektiv) och händelser.
        //Properties (Egenskaper)
        /*public string Color;
        public string Model;
        public string Make; //Märket, t.ex Tesla volvo volkswagen
        */

        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
    }
}
