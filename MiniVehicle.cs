using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MiniVehicle:Vehicle
    {
        public int seatingCapacity { get; set; }
        public MiniVehicle(char fuelType, String vehicleMake, String vehicleType, int noOfKiloMeters, int seatingCapacity ) :
          base(fuelType,vehicleMake,vehicleType,noOfKiloMeters)
        {

        }

      
        public override void  calculateRatePerKiloMeter()
        {
            ratePerKiloMeter =(float)( 4.5 + (seatingCapacity - 4) * 1);
        }
        public override double calculateBill()
        {
            double Bill_Amount;
            Bill_Amount = noOfKiloMeters * ratePerKiloMeter;

            return Bill_Amount;
        }
        public int getSeatingCapacity()
        {
            return seatingCapacity;
        }
    }
}
