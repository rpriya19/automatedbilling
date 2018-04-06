using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Demo
    {
        static void Main(string[] args)
        {
            getInitializeObjMini("mini");
            getInitializeObjMaxi("maxi");

            Console.Read();

        }

        public static MiniVehicle getInitializeObjMini(String str)
        {
            MiniVehicle mini = new MiniVehicle('P', "Mazda", str, 40, 7);
            mini.validateFuelType();
            mini.calculateRatePerKiloMeter();

            Console.WriteLine("Vehicle Type		    :" + mini.vehicleType);
            Console.WriteLine("BillID               :"+mini.billID);
            Console.WriteLine("Rate per Kilo Meter	:" + mini.ratePerKiloMeter);
            Console.WriteLine("Fuel type		    :"+mini.fuelType);
            Console.WriteLine("Seating Capacity     :"+mini.seatingCapacity);

            mini.calculateBill();

            return mini;
        }

        public static MaxiVehicle getInitializeObjMaxi(String str)
        {
            MaxiVehicle maxi = new MaxiVehicle('D', "Tata", str, 200, 500);
            maxi.validateFuelType();
            maxi.calculateRatePerKiloMeter();
            maxi.calculateRatePerKG();

            Console.WriteLine("Vehicle Type		    :"+maxi.vehicleType);
            Console.WriteLine("BillID 	            :"+maxi.billID);
            Console.WriteLine("Rate per Kilo Meter	:"+maxi.ratePerKiloMeter);
            Console.WriteLine("Fuel type		    :"+maxi.fuelType);
            Console.WriteLine("Load In KG	        :"+maxi.loadInKG);
            Console.WriteLine("Rate per KG 		    :"+maxi.ratePerKG);

            maxi.calculateBill();
            return maxi;
        }
    }
}
