using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    internal class SuperCarModel : CarModel
    { 
        public SuperCarModel (CarManufacturer carManufacturer, 
            CarName carName, CarColor carColor, int carConstructionYear)
            : base(carManufacturer, carName, carColor, carConstructionYear)
        {
            base.carType = CarType.SportAuto;
        }

        public override string ToString()
        {
            string carDescription = base.ToString() + base.MessageCarType();

            return carDescription;
        }
    }
}
