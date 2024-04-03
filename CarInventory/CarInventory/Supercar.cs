using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    public class Supercar : Car
    {
        public Supercar(string _name, string _carType) : base(_name, _carType) { }

        public override void setSpeed(int speed)
        {
            Console.WriteLine("Cannot set speed for supercar");
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
                base.setAcceleration(Math.Min(acceleration, 5));
            }
        }
        public override void setHandling(int handling)
        {
            if(handling < 1)
            {
                Console.WriteLine("Minimum lvl is 1");
                base.setHandling(1);
            }
            else
            {
                base.setHandling(Math.Min(handling, 5));
            }
        }
    }
}
