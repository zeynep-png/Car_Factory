
using Car_Factory;
using System.Collections.Concurrent;

List<Car> cars = new List<Car>();

ConsoleHelper.WriteLineColored("--------CAR FACTORY---------",ConsoleColor.Yellow);

    while (true)
    {
        string input = string.Empty;
        bool validInput = false;

        // kullanıcıdan geçerli bir girdi alıncaya kadar döngü
        while (!validInput)
        {
            Console.WriteLine("Do you want to produce a car? (y/n)");
            input = Console.ReadLine().Trim().ToLower();

            if (input == "y" || input == "n")
            {
                validInput = true;
            }
            else
            {
                ConsoleHelper.WriteLineColored("[ERROR] Invalid input. Please enter 'y' or 'n'.", ConsoleColor.Red);
            }
        }

        if (input == "y")
        {
            while (true)
            {
                Car car = new Car();
            ConsoleHelper.WriteColored("Production Date: "+car.ProductionDate, ConsoleColor.Cyan);
                ConsoleHelper.WriteColored("\n\nSerial Number: ", ConsoleColor.Cyan);
                car.SerialNumber = Console.ReadLine();
                ConsoleHelper.WriteColored("\nBrand: ", ConsoleColor.Cyan);
                car.Brand = Console.ReadLine();
                ConsoleHelper.WriteColored("\nModel: ", ConsoleColor.Cyan);
                car.Model = Console.ReadLine();
                ConsoleHelper.WriteColored("\nColor: ", ConsoleColor.Cyan);
                car.Color = Console.ReadLine();

                while (true)
                {
                    ConsoleHelper.WriteColored("\nNumber of Doors: ", ConsoleColor.Cyan);
                    try
                    {
                        car.NumberOfDoor = Convert.ToInt32(Console.ReadLine());

                        if (car.NumberOfDoor == 2 || car.NumberOfDoor == 4)
                        {
                            break; // döngüden çık
                        }
                        else
                        {
                            ConsoleHelper.WriteLineColored("[ERROR] Invalid door number. Try again.", ConsoleColor.Red);
                        }
                    }
                    catch (FormatException)
                    {
                        ConsoleHelper.WriteLineColored("[ERROR] Please enter a valid number for the number of doors.", ConsoleColor.Red);
                    }
                }

                cars.Add(car);

                // Yeni bir araba üretmek isteyip istemediğini sor
                ConsoleHelper.WriteLineColored("Do you want to produce another car? (y/n)", ConsoleColor.Yellow);
                string ans = Console.ReadLine().Trim().ToLower();

                if (ans == "y")
                {
                    continue; // Yeni bir araba üretmek için başa dön
                }
                else if (ans == "n")
                {
                    ConsoleHelper.WriteLineColored("--- Cars List ---", ConsoleColor.Magenta);
                    foreach (Car c in cars)
                    {
                        Console.WriteLine("Serial Number: " + c.SerialNumber + "  Brand: " + c.Brand.ToUpper());
                    }
                    return; // Programdan çık
                }
                else
                {
                    ConsoleHelper.WriteLineColored("[ERROR] Invalid input. Please enter 'y' or 'n'.", ConsoleColor.Red);
                }
            }
        }
        else if (input == "n")
        {
            break; // Programdan çık
        }
    }

