using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lad06;
class Program
{

    public void Increment(ref int X);
    public static void Add2(ref int x)
    {
        x += 2;
    }
    public static void Add3(ref int x)
    {
        x += 3;
    }
    class Program
    {
        static void Main(string[] args)
        {
   Thermostat thermostat = new Thermostat();
            Heater heater = new Heater(60);
            thermostat.OnTemperatureChange +=
                 heater.OnTemperatureChanged;
            Heater heaterCuong = new Heater(100);
            thermostat.OnTemperatureChange +=
                 heaterCuong.OnTemperatureChanged;

            Cooler cooler = new Cooler(80);
            thermostat.OnTemperatureChange +=
                 cooler.OnTemperatureChanged;

            string temperature;
            Console.Write("Enter temperature: ");
            temperature = Console.ReadLine();
            thermostat.CurrentTemperature = int.Parse(temperature);
            Console.ReadLine();
        }
    }
}

