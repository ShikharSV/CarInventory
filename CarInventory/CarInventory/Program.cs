using System;

namespace CarInventory
{
    public class Program
    {
        static Car[] arr = new Car[10];
        static int carCount = 0;
        private static void AddCar(Car car)
        {
            if(carCount < arr.Length)
            {
                arr[carCount++] = car;
                Console.WriteLine($"{car.getName()} added!!!");
                Console.WriteLine("Total cars : " +  carCount );
            }
            else
            {
                Console.WriteLine("Garage is full");
            }
        }
        private static void CreateCar()
        {
            Console.WriteLine("Enter car name");
            string name = Console.ReadLine();
            Console.WriteLine("Choose car type");
            Console.WriteLine("1 : Supercar");
            Console.WriteLine("2 : Sedan");
            Console.WriteLine("3 : SUV");
            Console.WriteLine("4 : Minivan");
            int carType = Convert.ToInt32(Console.ReadLine());
            switch (carType)
            {
                case 1:
                    AddCar(new Supercar(name, "supercar"));
                    break;
                case 2:
                    AddCar(new Sedan(name, "sedan"));
                    break;
                case 3:
                    AddCar(new SUV(name, "suv"));
                    break;
                case 4:
                    AddCar(new Minivan(name, "minivan"));
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        
        private static void ViewCars()
        {
            Console.WriteLine("Select car: ");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine($"{i+1} : {arr[i].getName()}");
                }
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            string name = arr[choice - 1].getName();

            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i].getName() == name)
                {
                    arr[i].details();
                    return;
                }
            }
            Console.WriteLine("Car not found in garage");
        }private static void ModifyCar()
        {
            Console.WriteLine("Select a car to modify");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    Console.WriteLine($"{i + 1} : {arr[i].getName()}");
                }
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            string name = arr[choice - 1].getName();
            
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].getName() + " " + name);
                if (arr[i].getName() == name)
                {
                    Console.WriteLine("Choose property to edit:");
                    Console.WriteLine("1. Top Speed");
                    Console.WriteLine("2. Acceleration");
                    Console.WriteLine("3. Handling");
                    Console.WriteLine("4. Nitro");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Enter new top speed:");
                            int topSpeed = int.Parse(Console.ReadLine());
                            arr[i].setSpeed(topSpeed);
                            break;
                        case 2:
                            Console.WriteLine("Enter Acceleration: ");
                            int acceleration = int.Parse(Console.ReadLine());
                            arr[i].setAcceleration(acceleration);
                            break;
                        case 3:
                            Console.WriteLine("Enter new Handling: ");
                            int handling = int.Parse(Console.ReadLine());
                            arr[i].setHandling(handling);
                            break;
                        case 4:
                            Console.WriteLine("Enter new nitro: ");
                            int nitro = int.Parse(Console.ReadLine());
                            if(name == "minivan")
                            {
                                ((Initro)arr[i]).setNitro(nitro);
                            }
                            else
                            {
                                Console.WriteLine("Nitro can be added only for minivan");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
            }

        }
        private static void RemoveCar()
        {

        }
        static void Main(String[] args)
        {
            while(true)
            {
                Console.WriteLine("Welcome to the Garage");
                Console.WriteLine("1 : Create Car");
                Console.WriteLine("2 : View Cars");
                Console.WriteLine("3 : Modify Car");
                Console.WriteLine("4 : Remove Car");
                Console.WriteLine("5 : Exit");
                int n = Convert.ToInt32(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        CreateCar();
                        break;
                    case 2:
                        ViewCars();
                        break;
                    case 3:
                        ModifyCar();
                        break;
                    case 4:
                        RemoveCar();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}