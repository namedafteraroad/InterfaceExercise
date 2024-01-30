﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
         public bool HasThirdRow { get; set; }
        public bool IsCrossover { get; set; }
        
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }
        public bool IsElectric { get; set; }
        public int NumberOfDoors { get; set; }

        public string CountryOrgin { get; set; }
        public string Logo { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"The SUV or Sport Utility Vehicle");
            Console.WriteLine($"Ask yourself some important questions before you buy");
            Console.WriteLine($"In the mean time, we can answer some basic questions, like");
            Console.WriteLine($"Does my SUV have a third row: {HasThirdRow}");
            Console.WriteLine($"Is it a cross over: {IsCrossover}");
            Console.WriteLine($"How many wheels {NumberOfWheels}");
            Console.WriteLine($"Is my vehicle automatic? {IsAutomatic}");
            Console.WriteLine($"Is my vehicle electric? {IsElectric}");
            Console.WriteLine($"How many doors? {NumberOfDoors}");
            Console.WriteLine($"Where is my vehicle from> {CountryOrgin}");
            Console.WriteLine($"What logo should I look for? {Logo}");
          

            
            
            
            //Console.WriteLine($"{HasThirdRow},{IsCrossover},{NumberOfWheels},{IsAutomatic},{IsElectric},{NumberOfDoors},{CountryOrgin},{Logo}");
        }
    }
}
//In each of your Car, Truck, and SUV classes

/* Create 2 members that are specific to each class
 * Example for Car: public bool HasTrunk { get; set; }
 * Example for SUV: public int NumberOfSeats { get; set; }
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 */