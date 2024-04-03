using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    public class Minivan : Car, Initro
    {
        public static new int nitro;
        public Minivan(string _name, string _carType) : base(_name, _carType)
        {
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
                base.setSpeed(Math.Min(speed, 10));
            }
        }
        public  void setNitro(int _nitro)
        {
            nitro = _nitro;
        }
        public  int getNitro()
        {
            return nitro;   
        }

    }
}
