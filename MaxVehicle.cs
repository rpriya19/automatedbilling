using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MaxiVehicle:Vehicle
    {
      public float loadInKG { get; set; }
public float ratePerKG { get; set; }

       public MaxiVehicle(char fuelType, String vehicleMake, String vehicleType, int noOfKiloMeters, float loadInKG):
base(fuelType,vehicleMake,vehicleType,noOfKiloMeters)
            { }

        public bool validateLoadInKG()
        {
            if (loadInKG >= 100 && loadInKG <= 5000)
                return true;
            else
                return false;
        }
        public void calculateRatePerKG()
        {
            if (vehicleMake.ToUpper() == "Ashok Leyland".ToUpper())
            {
                ratePerKG = 1.5f;
            }
            else if (vehicleMake.ToUpper() == "Mahindra".ToUpper())
            {
                ratePerKG = 1.0f;
            }
            else
            {
                ratePerKG = 0.5f;
            }
        }
        public float getLoadInKG()
        {
            return loadInKG;
        }

        public float getRatePerKG()
        {
            return ratePerKG;
        }
        public override void calculateRatePerKiloMeter()
        {
            if (fuelType == 'P')
            {
                ratePerKiloMeter = 6;
            }
            else
                ratePerKiloMeter = 5;
        }
        public override double calculateBill()
        {
            if(!validateLoadInKG())
            {
                Console.WriteLine("Unable to calculate the bill as the entered "+loadInKG+" is incorrect");
                return 0.0;
            }
            else
            {
                double bill_amount = noOfKiloMeters * ratePerKiloMeter + loadInKG * ratePerKG;
                return bill_amount;
            }
        }

    }
}
