using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany***************DONE

            //Create 3 classes called Car , Truck , & SUV***************DONE

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.***************DONE
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company*******************DONE
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes******************************DONE

            /* Create 2 members that are specific to each class*********************************DONE
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            


            SUV tahoe = new SUV();

            //suv suv = new SUV() {HasThirdRow = true, ...}

            tahoe.HasThirdRow = true;
            tahoe.IsCrossover = false;
            
            tahoe.NumberOfWheels = 4;
            tahoe.IsAutomatic = true;
            tahoe.IsElectric = false;
            tahoe.NumberOfDoors = 5;
            tahoe.CountryOrgin = "USA";
            tahoe.Logo = "bowtie";
            tahoe.DisplayDetails();

            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");

            Car boxster = new Car();
            boxster.IsConvertible = true;
            boxster.IsSportsCar = true;
            boxster.NumberOfWheels = 4;
            boxster.IsAutomatic = false;
            boxster.IsElectric = false;
            boxster.NumberOfDoors = 2;
            boxster.CountryOrgin = "Germany";
            boxster.Logo = "shield";
            boxster.DisplayDetails();

            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");


            Truck ram = new Truck();
            ram.IsPickup = true;
            ram.HasDualWheels = true;
            ram.NumberOfWheels = 6;
            ram.IsAutomatic = true;
            ram.IsElectric = false;
            ram.NumberOfDoors = 4;
            ram.CountryOrgin = "USA";
            ram.Logo = "Ram";
            ram.DisplayDetails();
            



            






            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
