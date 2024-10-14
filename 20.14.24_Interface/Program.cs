// See https://aka.ms/new-console-template for more information
using _20._14._24_Interface.Models;


Bike bike = new Bike();
bike.Ride();

Airplane airplane = new Airplane();
airplane.Operate();// This invokes the Operate method, which in turn calls the Fly method, outputting "Flying..." to the console.