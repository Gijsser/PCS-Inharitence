using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {

        private List<Animal> ReservedAnimals;
        private List<Animal> UnreservedAnimals;

        public Administration()
        {
            ReservedAnimals = new List<Animal>();
            UnreservedAnimals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            try
            {
                if(animal.IsReserved == true)
                {
                    ReservedAnimals.Add(animal);
                }
                else
                {
                    UnreservedAnimals.Add(animal);
                }
                ReservedAnimals.Sort();
                UnreservedAnimals.Sort();
                return true;
            }
            catch
            {
                return false;
            }
            

       }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            try
            {
                foreach (Animal a in ReservedAnimals) 
                {

                    if (a.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        ReservedAnimals.Remove(a);
                        return true;
                    }

                }
                foreach(Animal a in UnreservedAnimals)
                {
                    if (a.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        UnreservedAnimals.Remove(a);
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            Animal currentAnimal = null;
            foreach(Animal A in UnreservedAnimals)
            {
                if(A.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    currentAnimal = A;
                }
            }
            foreach (Animal A in ReservedAnimals)
            {
                if (A.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    currentAnimal = A;
                }
            }

            return currentAnimal;
        }
        public List<Animal> GetReservedAnimals()
        {
            return ReservedAnimals;
        }
        public List<Animal> GetUnReservedAnimals()
        {
            return UnreservedAnimals;
        }
    }
}
