﻿using System;
using System.Threading;

namespace VirtualPet
{
    class Program
    {
        static Shelter myShelter = new Shelter();
        static void Main(string[] args)
        {
            CatPicture.PrintCatPicture();
            Timer _timer = new Timer(Tick, null, 0, 15000);

            // Kevin and Jay 9/20----------
            // testing the shelter list view pets and interact function
            Shelter myShelter = new Shelter();
            


            
            Pet myPet1 = new Pet("spot", "dog");

            Pet myPet2 = new Pet("muffy", "dog");
            Pet myPet3 = new Pet("charlie", "dog");
            myShelter.ShelterList.Add(myPet1);
            myShelter.ShelterList.Add(myPet2);

            RoboPet Tobor = new RoboPet("Tobor", "robot");
            Tobor.GetStatus();
            Tobor.Name = "Tobor";
            myShelter.ShelterList.Add(Tobor);


            bool playing = true;


            while (playing)
            {
                Console.WriteLine("Hello! Welcome to Virtual Pets");

                Console.WriteLine("Make a Selection");
                Console.WriteLine("1. Add new pet to the shelter.");
                Console.WriteLine("2. Interact with a pet or all pets.");
                Console.WriteLine("3. View Status of all pets");
                Console.WriteLine("4. Adopt a pet.");
                
                
                Console.WriteLine("enter Q to quit");

                string menuinput = Console.ReadLine().ToLower();

                switch (menuinput)

                {
                    case "1":

                        // insert check status of pet here (If there is no pet, print "go to the shelter and get a pet")
                        // insert making your own pet here
                        CreatePet();
                        break;

                    case "2":

                        // insert feed pet here
                        myShelter.Interact();
                        break;

                    case "3":
                        // insert checking status of ALL pets
                        myShelter.GetStatusAll();
                        break;

                    case "4":

                        // Remove the pet in the shelter
                        myShelter.RemovefromShelter(myShelter.ChoosePet());
                        break;

                    case "q":
                        playing = false;
                        break;



                }
                //Tick();

            }
        }
        public static void Tick(object o) 
        {
            //testPet.Tick();
        }
        public static void CreatePet()
        {
            Console.WriteLine("Enter a name for this pet:");
            string petName = Console.ReadLine();
            Console.WriteLine("Enter the pet's species (enter robot to create a robopet):");
            string petSpecies = Console.ReadLine();

            if (petSpecies.ToLower() == "robot")
            {
				Console.WriteLine("Creating a Robot...");
                RoboPet newPet = new RoboPet(petName, petSpecies);
                myShelter.addtoShelter(newPet);
            } else
			{
				Console.WriteLine("Adding your pet...");
                Pet newPet = new Pet(petName, petSpecies);
                myShelter.addtoShelter(newPet);
				Console.WriteLine("Congratulations on your new pet!");
            }

			
            
        }
    }
}
