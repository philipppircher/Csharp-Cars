using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Cars
{
    internal class CarModel
    {
        internal CarManufacturer carManufacturer { get; private set; }
        internal CarType carType { get; set; }
        internal CarName carName { get; private set; }
        public CarColor carColor { get; private set; }
        public int CarConstructionYear { get; private set; }

        public CarModel(CarManufacturer carManufacturer, CarName carName, CarColor carColor, int carConstructionYear)
        {
            this.carType = CarType.Auto;
            this.carManufacturer = carManufacturer;
            this.carName = carName;
            this.carColor = carColor;
            this.CarConstructionYear = carConstructionYear;
        }

        public override string ToString()
        {
            string carDescription = "Autotyp: " + this.carType + "\nHersteller: " + this.carManufacturer + "\nName: "
                + this.carName + "\nFarbe: " + this.carColor + "\nBaujahr: " + this.CarConstructionYear;

            carDescription += MessageCarType();

            return carDescription;
        }

        protected string MessageCarType()
        {
            return "\nICH FAHRE EIN " + this.carType + "\n\n";
        }
    }
}
