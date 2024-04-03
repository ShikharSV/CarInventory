using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventory
{
    interface Initro
    {
        void setNitro(int nitro);
        int getNitro();
    }
    public class Car
    {
        public string name;
        public int topSpeed;
        public int acceleration;
        public int handling;
        public int nitro;
        public string carType;

        public virtual string getName() {  return name; }
        public virtual void setSpeed(int speed) {
            topSpeed = speed;
        }
        public virtual int getSpeed() { return topSpeed; }

        public virtual void setAcceleration(int _acceleration) {
            acceleration = _acceleration;
        }
        public virtual int getAcceleration() { return acceleration; }
        public virtual void setHandling(int _handling) {
            handling = _handling;
        }
        public virtual int getHandling() { return handling; }
        //public virtual void setNitro(int nitro) { }
        //public virtual int getNitro() { return nitro; }
        public void details()
        {
            Console.WriteLine("Car details are");
            Console.WriteLine("Name : " +  name);
            Console.WriteLine("Top Speed : " +  topSpeed);
            Console.WriteLine("Acceleration : " + acceleration);
            Console.WriteLine("Handling : " +  handling);
            Console.WriteLine("Nitro : " + nitro);
        }

        public Car(string _name, string _carType)
        {
            this.name = _name;
            this.carType = _carType;
            this.topSpeed = 1;
            this.acceleration = 1;
            this.handling = 1;
            this.nitro = 1;
        }
    }
}
