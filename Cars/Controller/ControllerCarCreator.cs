using Cars.Car;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Cars
{
    internal static class ControllerCarCreator
    {
        internal static ArrayList SetCarAttributes(ArrayList cars)
        {
            int type = GetInputForCarAttribute(new CarType(), "Autotyp Eingabe: ");
            int manufacturer = GetInputForCarAttribute(new CarManufacturer(), "Autohersteller Eingabe: ");
            int name = GetInputForCarAttribute(new CarName(), "Autoname Eingabe: ");
            int color = GetInputForCarAttribute(new CarColor(), "Autofarbe Eingabe: ");
            int constructionYear = GetInputForCarAttribute("Baujahr Eingabe: ");
            Console.WriteLine();

            CarModel car;

            if (0 == (int)type)
            {
                car = new CarModel((CarManufacturer)manufacturer, (CarName)name, (CarColor)color, constructionYear);
            }
            else
            {
                car = new SuperCarModel((CarManufacturer)manufacturer, (CarName)name, (CarColor)color, constructionYear);
            }

            cars.Add(car);
            return cars;
        }

        private static int GetInputForCarAttribute(Enum @enum, string outputForNextCarAttribute)
        {
            int userInput;
            string output = outputForNextCarAttribute;
            output += GetEnumItemsToString(@enum);

            Console.WriteLine(output);
            Console.Write("Deine Eingabe: ");

            userInput = ControllerMenu.GetStringToInt();
            userInput = GetAbove0OrBelowLengthOfEnum(userInput, @enum);
            Console.WriteLine("Du hast " + userInput + " gewählt\n");
            return userInput;
        }

        private static int GetInputForCarAttribute(string outputForNextCarAttribute)
        {
            int userInput;
            string output = outputForNextCarAttribute;
            
            Console.WriteLine(output);
            Console.Write("Deine Eingabe: ");

            userInput = ControllerMenu.GetStringToInt();

            return userInput;
        }

        private static string[] GetEnumAsStringArray(Enum @enum)
        {
            string s = "";

            if (@enum is CarType)
            {
                s = string.Join(",", Enum.GetNames(typeof(CarType)));
            }
            else if (@enum is CarManufacturer)
            {
                s = string.Join(",", Enum.GetNames(typeof(CarManufacturer)));
            }
            else if (@enum is CarName)
            {
                s = string.Join(",", Enum.GetNames(typeof(CarName)));
            }
            else if (@enum is CarColor)
            {
                s = string.Join(",", Enum.GetNames(typeof(CarColor)));
            }

            string[] strEnumItems = s.Split(",");
            return strEnumItems;
        }

        private static string GetEnumItemsToString(Enum @enum)
        {
            string[] strEnumItems = GetEnumAsStringArray(@enum);
            string strAllEnumItemsToString = "\n";

            for (int i = 0; i < strEnumItems.Length; i++)
            {
                strAllEnumItemsToString += i + ": " + strEnumItems[i] + "\n";
            }

            return strAllEnumItemsToString;
        }

        private static int GetAbove0OrBelowLengthOfEnum(int value, Enum @enum)
        {
            string[] array = GetEnumAsStringArray(@enum);
            int length = array.Length;

            if (value < 0)
            {
                value = 0;
            }
            else if(value > length - 1)
            {
                value = length - 1;
            }

            return value;
        }
    }
}
