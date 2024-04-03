using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    public class SUV : Car
    {
        public SUV(string _name, string _carType) : base(_name, _carType) { }

        public override void setHandling(int _handling)
        {
            Console.WriteLine("Cannot modify for SUV");
        }
        public override void setSpeed(int speed)
        {
            if (speed < 1)
            {
                Console.WriteLine("Minimum lvl is 1");
                base.setSpeed(1);
            }
            else
            {
                base.setSpeed(Math.Min(speed, 5));
            }
        }

        public override void setAcceleration(int acceleration)
        {
            if(acceleration < 1)
            {
                Console.WriteLine("Minimum lvl is 1");
                base.setAcceleration(1);
            }
            else
            {
                base.setAcceleration(Math.Min(acceleration, 10));
            }
        }
    }
}
