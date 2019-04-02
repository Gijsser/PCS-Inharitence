using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        private List<Animal> Animals;

        public Administration()
        {
            Animals = new List<Animal>();
        }

        public bool Add(Animal animal)
        {
            try
            {
                Animals.Add(animal);
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
                foreach (Animal a in Animals)
                {

                    if (a.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        Animals.Remove(a);
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
            foreach(Animal A in Animals)
            {
                if(A.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    currentAnimal = A;
                }
            }
            return currentAnimal;
        }
        public List<Animal> GetAnimals()
        {
            return Animals;
        }
    }
}
