using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{

    
    public class Shelter
    {
        public static animal[] shelters = new animal[20];
        public void adopt(animal pet,int index)
        {
            if (index <= 20)
            {
                shelters[index] = pet;
            }
        }

        public void release(int serNo)
        {
            if (serNo <= 20 && serNo > 0)
            {
                animal releasedPet = shelters[serNo-1];

                for (int i = serNo-1; i < 20 - 1; i++)
                {
                    shelters[i] = shelters[i + 1];
                }
                shelters[shelters.Length - 1] = null;
                Console.WriteLine("No {0}  {1} the {2} has been released ",releasedPet.serNo,releasedPet.name,releasedPet.Type);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }

    public class mainClass
    {
        public static void Main()
        {
            int stop = 0;
            Console.WriteLine("\t\tWelcome to Our Animal Shelter");

            for (int i = 0; i < 20;)
            {
                Console.WriteLine("\n1.\tRegister a new animal");
                Console.WriteLine("2.\tRelease an animal");
                Console.WriteLine("3.\tI'm done");

                Console.Write("\nYour choice is: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\n\nWhat type of animal are you registering: ");
                        string species = Console.ReadLine();
                        Console.Write("\nWhat is the name of your {0}: ", species);
                        string name = Console.ReadLine();

                        animal pet = null;
                        if (species == animal.species.cat.ToString()) { Cat cat = new Cat(i + 1, species, name); pet = cat; }


                        else if (species == animal.species.dog.ToString()) { Dog dog = new Dog(i + 1, species, name); pet = dog; }

                        Shelter newpet = new Shelter();
                        newpet.adopt(pet,i);
                        i++;
                        break;

                    case 2:
                        Console.Write("\n\nPlease enter the serial no of the pet you'd like to release: ");
                        int serNo = int.Parse(Console.ReadLine());

                        Shelter oldpet = new Shelter();
                        oldpet.release(serNo);
                        i--;
                        break;

                    case 3:
                        stop = i;
                        i = 20;
                        break;
                }

            }


            Console.WriteLine("\nS/N \tSpecies \tName");
            for (int i = 0; i < stop; i++)
            {
                Console.WriteLine("\n{0}. \t{1}   \t\t{2}", Shelter.shelters[i].serNo, Shelter.shelters[i].Type, Shelter.shelters[i].name);
            }
        }
    }
}
