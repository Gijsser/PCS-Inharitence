﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Dog : Animal
    {
        /// <summary>
        /// The date of the last walk of the dog. Contains null if unknown.
        /// </summary>
        public SimpleDate LastWalkDate { get; set; }
        public override decimal Price { get; set; }

        /// <summary>
        /// Creates a dog.
        /// </summary>
        /// <param name="chipRegistrationNumber">The chipnumber of the animal. 
        ///                                      Must be unique. Must be zero or greater than zero.</param>
        /// <param name="dateOfBirth">The date of birth of the animal.</param>
        /// <param name="name">The name of the animal.</param>
        /// <param name="lastWalkDate">The date of the last walk with the dog or null if unknown.</param>
        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, SimpleDate lastWalkDate) : base (chipRegistrationNumber, dateOfBirth, name)
        {
            LastWalkDate = lastWalkDate;
            Price = GetPrice();
        }

        //public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
        //         string name) : base(chipRegistrationNumber, dateOfBirth, name)
        //{
        //    LastWalkDate = null;
        //    Price = GetPrice();
        //}

        /// <summary>
        /// Retrieve information about this dog
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Dog: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <LastWalkDate>"
        ///          Where: IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 LastWalkDate will be "unknown" if unknown or the date of the last doggywalk otherwise.
        /// </returns>
        public override string ToString()
        {
            string walked = LastWalkDate.ToString();
            if (walked == "01/01/1980" || walked == null)
            {
                walked = "Please Walk!";
            }
            
            return base.ToString() + ", " + walked;
        }

        public override decimal GetPrice()
        {
            decimal price = 350;
            if(ChipRegistrationNumber < 50000)
            {
                price = 200;
            }
            return price;
        }
    }
}
