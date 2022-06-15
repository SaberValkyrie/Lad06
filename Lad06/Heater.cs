using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lad06
{
     class Heater
    {
        public Heater(float temperature)
        {
           Temperature = temperature;
        }
        public float Temperature {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        private float _Temperature;
    public void OnTemperatureChanged(float newTemperature)
        {
            if( newTemperature < Temperature)
            {
                Console.Write("Heater: ON");
            }
            else
            {
                Console.Write("Heater: Off");
            }
        }
    }


}
