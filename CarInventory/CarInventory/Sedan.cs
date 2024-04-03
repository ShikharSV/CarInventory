using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    public class Sedan : Car
    {
        public Sedan(string _name, string _carType) : base(_name, _carType) { }

        public override void setAcceleration(int _acceleration)
        {
            Console.WriteLine("Cannot modify for Sedan");
        }
        public override void setSpeed(int speed)
        {
            if(speed < 1)
            {
                Console.WriteLine("Minimum lvl is 1");
                base.setSpeed(1);
            }
            else
            {
                base.setSpeed(Math.Min(speed, 5));
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
                base.setHandling(Math.Min(handling, 10)); 
            }
        }
    }
}
