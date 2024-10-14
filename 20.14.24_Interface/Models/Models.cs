using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._14._24_Interface.Models
{
    interface OperateVehicle //to implement the method how the vehicule operate
    {
        void Operate();//Interface method doestnt have a body

    }

    interface accesibleTransport//To decide if is public accesible vehicule or no
    {
        Boolean isPublicAccesible(); 
    }

    // Interfaces that inherit from OperateVehicle to define different types of vehicles that can operate.
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
