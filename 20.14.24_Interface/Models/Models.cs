using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._14._24_Interface.Models
{
    interface OperateVehicle
    {
        void Operate();//Interface method doestnt have a body

    }

    interface accesibleTransport
    {
        Boolean isPublicAccesible(); 
    }

    interface Flyiable : OperateVehicle
    {
        void Fly();
    }

    interface Drivable : OperateVehicle
    {
        void Drive();
    }

    interface Rideable : OperateVehicle
    {
        void Ride();
    }


    class Airplane : Flyiable,accesibleTransport
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }

        public void Operate()
        {
            Fly();
        }

        public bool isPublicAccesible()
        {
            return true;
        }
    }

    class Bike : Rideable, accesibleTransport
    {
        public void Ride()
        {
            Console.WriteLine("Riding...");
        }

        public void Operate()
        {
            Ride();
        }

        public bool isPublicAccesible()
        {
            return false;
        }
    }

    public class Truck : Drivable, accesibleTransport 
    {
        public bool isPublicAccesible() 
        {
            return false ;
        }

        public void Drive()
        {
            Console.WriteLine("Driving...");
        }

        public void Operate()
        {
            Drive();
        }

    }

}
