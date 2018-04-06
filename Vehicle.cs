using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public abstract class Vehicle
    {
        public int billID { get; set; } 
public char fuelType { get; set; }
public string vehicleMake { get; set; }
public string vehicleType { get; set; }
public int noOfKiloMeters { get; set; }
public float ratePerKiloMeter { get; set; }
public static int counter { get; set; }

        public Vehicle(char fuelType,string vehicleMake,string vehicleType,int noOfKiloMeters)
        {
            this.fuelType = fuelType;
            this.vehicleMake = vehicleMake;
            this.vehicleType = vehicleType;
            this.noOfKiloMeters = noOfKiloMeters;

        }
        public int getBillID()
        {
            Random r = new Random();
            billID = r.Next(1001, 100000);

            return billID;
        }
        public char getFuelType()
        {
            if(fuelType!='P'||fuelType!='D')
            {
                fuelType = 'D';
                Console.WriteLine("Invalid fuel type, set the value to D");
            }
            else
            {

            }
            return fuelType;
        }
        public string getVehicleMake()
        {
            return vehicleMake;
        }
        public string getVehicleType()
        {
            return vehicleType;
        }
        public int getNoOfKiloMeters()
        {
            return noOfKiloMeters;
        }
        public  float getRatePerKiloMeter()
        {
            return ratePerKiloMeter;
        }
        public void validateFuelType()
        {

        }
        public abstract void calculateRatePerKiloMeter();

        public abstract double calculateBill();
        


    }
}
