using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    // This a class that represents a Smart Coffee Mug that can heat up coffee and track battery levels.
    public class SmartCoffeeMug
    {
        // Private variables to store the temperature, battery level, and heating status.
        private double temperature;
        private int battery;
        private bool isHeating;

        public SmartCoffeeMug(double startTemperature)
        {
            temperature = startTemperature;
            battery = 100;
            isHeating = false;
        }

        // Method to turn on heating. 
        public void TurnOnHeating()
        {
            if (battery > 10)
            {
                isHeating = true;
                Console.WriteLine("Heating is ON.");
                HeatCoffee();
            }
            else
            {
                Console.WriteLine("Battery too low! Please recharge.");
            }
        }

        // Method to turn off heating.
        public void TurnOffHeating()
        {
            isHeating = false;
            Console.WriteLine("Heating is OFF.");
        }

        // Method to check and display the current temperature of the coffee.
        public void CheckTemperature()
        {
            Console.WriteLine("The coffee temperature is " + temperature + "°C.");
        }

        // Method to check and display the current battery level.
        public void CheckBattery()
        {
            Console.WriteLine("Battery level is " + battery + "%.");
        }

        // Private method that heats the coffee. 
        private void HeatCoffee()
        {
            if (isHeating)
            {
                temperature += 1; 
                battery -= 10; 
                Console.WriteLine("Heating up... Current temperature: " + temperature + "°C");
            }
        }

        // Method to recharge the mug's battery.
        public void Recharge()
        {
            battery = 100;
            Console.WriteLine("Battery is recharged!");
        }

        
        public void IncreaseTemperature()
        {
            if (isHeating)
            {
                temperature += 1; 
                Console.WriteLine("Increasing temperature... Current temperature: " + temperature + "°C");
            }
            else
            {
                Console.WriteLine("Heating is OFF. Please turn on heating to increase the temperature.");
            }
        }

        // Method to decrease the temperature, can be used independently of heating.
        public void DecreaseTemperature()
        {
            if (temperature > 0) // Ensure temperature doesn't go below 0.
            {
                temperature -= 1;
                Console.WriteLine("Decreasing temperature... Current temperature: " + temperature + "°C");
            }
            else
            {
                Console.WriteLine("Temperature is already at the minimum.");
            }
        }
    }

    // Main program class to create an instance of SmartCoffeeMug and interact with it.
    public class Program
    {
        public static void Main()
        {
            // Create a SmartCoffeeMug object with an initial temperature of 60°C
            SmartCoffeeMug mug = new SmartCoffeeMug(60);

            // Loop control variable to keep the program running.
            bool isRunning = true;

            // Program loop that allows the user to choose actions repeatedly until they exit.
            while (isRunning)
            {
                // Displays option to the user
                Console.WriteLine("\nWhat would you like to do with your Smart Coffee Mug!?");
                Console.WriteLine("1 - Turn on heating");
                Console.WriteLine("2 - Turn off heating");
                Console.WriteLine("3 - Check temperature");
                Console.WriteLine("4 - Check battery");
                Console.WriteLine("5 - Recharge");
                Console.WriteLine("6 - Increase temperature");
                Console.WriteLine("7 - Decrease temperature");
                Console.WriteLine("0 - Exit");

                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Switch case to perform actions based on the user input
                switch (input)
                {
                    case "1":
                        mug.TurnOnHeating();
                        break;
                    case "2":
                        mug.TurnOffHeating();
                        break;
                    case "3":
                        mug.CheckTemperature();
                        break;
                    case "4":
                        mug.CheckBattery();
                        break;
                    case "5":
                        mug.Recharge();
                        break;
                    case "6":
                        mug.IncreaseTemperature(); 
                        break;
                    case "7":
                        mug.DecreaseTemperature(); 
                        break;
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Thank you for using our smart coffee mug!");
                        break;
                    default:
                        Console.WriteLine("Please enter a number from 0 to 7.");
                        break;
                }
            }
        }
    }
}
