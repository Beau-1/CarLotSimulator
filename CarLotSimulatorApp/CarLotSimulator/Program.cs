using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car -Completed
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - Done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - Done
            //The methods should take one string parameter: the respective noise property -Done


            //Now that the Car class is created we can instanciate 3 new cars

            BigBeau_sCarLot inventory = new BigBeau_sCarLot();

            

            Car car1= new Car();
            car1.Year = 2004;
            car1.Make = "Kia";
            car1.Model = "Spectra";
            car1.EngineNoise = "Vroom";
            car1.HonkNoise = "Beep";
            car1.IsDriveable = true;

            inventory.CarList.Add(car1);

            Car car2 = new Car() 
            { 
                Year = 2011, 
                Make = "Saturn", 
                Model = "SL7", 
                EngineNoise = "Broom", 
                HonkNoise = "Meep", 
                IsDriveable = false 
            };

            inventory.CarList.Add(car2);


            Car car3 = new Car(2013, "Saturn", "Ion", "Groom", "Haunk", false);
            
            inventory.CarList.Add(car3);

            foreach (var car in inventory.CarList)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

            //Set the properties for each of the cars - Done
            //Call each of the methods for each car - Done

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
