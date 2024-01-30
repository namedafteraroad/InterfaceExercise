using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool IsAutomatic { get; set; }
        public bool IsElectric { get; set; }
        public int NumberOfDoors { get; set; }

        public void DisplayDetails();

    }
}
//In your IVehicle:

/* Create 4 members that Car, Truck, & SUV all have in common.
 * Example: public int NumberOfWheels { get; set; }
 */
//Option for displaying values: 
//Create a stubbed out method called DisplayDetails in your IVehicle interface.
//Implement the stubbed out method in the derived classes.
//In the scope of them method, use string interpolation to display property values.
//In order to also interpolate values from ICompany, research how to extend interfaces.