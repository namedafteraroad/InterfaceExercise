﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {

        public string CountryOrgin { get; set; }
        public string Logo { get; set; }


    }
}
//In ICompany: 

/* Create 2 members that are specific to each every company
 * regardless of vehicle type.
 * Example: public string Logo { get; set; }
 */