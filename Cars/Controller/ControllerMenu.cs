using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cars.Car
{
    internal static class ControllerMenu
    {
        internal static void MenuInput()
        {
            int selectionValue = 0;
            ArrayList cars = new ArrayList();

            do {
                PrintGreeting();
                selectionValue = GetStringToInt();
                ExecuteSelection(selectionValue, cars);
            } while (selectionValue == 0 || selectionValue == 1);
        }

        private static void PrintGreeting()
        {
            Console.WriteLine("Willkommen im Automenü:");
            Console.WriteLine("0.) Neues Auto anlegen,\n1.) Alle Autos anzeigen,\nalle andere Zahlen.) Beenden: ");
            Console.Write("Deine Eingabe: ");
        }

        private static void PrintGoodbye()
        {
            Console.WriteLine("Ende der CarsApp.. Aufwiedersehen");
        }

        public static int GetStringToInt()
        {
            int selectionValue = 0;
            int repeatValue = 99;

            try
            {
                selectionValue = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ungültige Wert Zuweisung!!\n");
                selectionValue = repeatValue;
            }
            return selectionValue;
        }

        private static void ExecuteSelection(int selectionValue, ArrayList cars)
        {
            Console.WriteLine();

            switch (selectionValue)
            {
                case 0:
                    ControllerCarCreator.SetCarAttributes(cars);
                    break;
                case 1:
                    PrintCarList(cars);
                    break;
                default:
                    PrintGoodbye();
                    break;
            }
        }

        private static void PrintCarList(ArrayList cars)
        {
            Console.WriteLine("Show Carlist\n");
            foreach (CarModel car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
