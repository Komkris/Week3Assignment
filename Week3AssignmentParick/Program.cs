// See https://aka.ms/new-console-template for more information
using System;


namespace Week3Assignment
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //create 3 new Car class to hold user inputs
            Car Uno = new Car();
            Car Dos = new Car();
            Car Tres = new Car();

            //hold user input for speed limit
            int speedLimit;

            //hold demerits if car is speeding
            int demerits;

            //explain the purpose of the program and ask to user to input a speed limit
            Console.WriteLine("This program will calculate speeding penalties\nPlease enter a Speed Limit");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            //begin accepting inputs for cars
            //------------------------------------------------------------------------------------
            //first car
            Console.WriteLine("\nPlease enter the first Car Brand");
            Uno.make = Console.ReadLine();


            Console.WriteLine("Please enter the first Car Model");
            Uno.model = Console.ReadLine();


            Console.WriteLine("Please enter the speed the first Car is going in Miles per Hour");
            Uno.speed = Convert.ToInt32(Console.ReadLine());

            //------------------------------------------------------------------------------------
            //second car
            Console.WriteLine("\nPlease enter the second Car Brand");
            Dos.make = Console.ReadLine();


            Console.WriteLine("Please enter the second Car Model");
            Dos.model = Console.ReadLine();


            Console.WriteLine("Please enter the speed the second Car is going in Miles per Hour");
            Dos.speed = Convert.ToInt32(Console.ReadLine());

            //------------------------------------------------------------------------------------
            //third car
            Console.WriteLine("\nPlease enter the third Car Brand");
            Tres.make = Console.ReadLine();


            Console.WriteLine("Please enter the third Car Model");
            Tres.model = Console.ReadLine();


            Console.WriteLine("Please enter the speed the third Car is going in Miles per Hour");
            Tres.speed = Convert.ToInt32(Console.ReadLine());

            //------------------------------------------------------------------------------------
            
            //output the Speed Limit
            Console.WriteLine("\nSpeed Limit: " + speedLimit + "mph\n");

            //calculate the demerits for each car

            //calculate the first car------------------------------------------------------------------------------------
            if (Uno.speed - speedLimit <= 0) //check if the car is below or equal to the speed limit
            {
                Console.WriteLine(Uno.make + " " + Uno.model + " " + Uno.speed + "mph: OK");
            }
            else if(Uno.speed - speedLimit > 0) //if the car is above the speed limit, calculate the amount of demerits the car will recieve
            {
                demerits = ((Uno.speed - speedLimit)/5);
                if(demerits < 10)
                {
                    Console.WriteLine(Uno.make + " " + Uno.model + " " + Uno.speed + "mph: " + demerits + " demerits");
                }
                else if(demerits >= 10) //if car recieves too many demerits (above or equal to 10), suspend the driver's license
                {
                    Console.WriteLine(Uno.make + " " + Uno.model + " " + Uno.speed + "mph: " + demerits + " demerits <LICENSE SUSPENDED>");
                }

            }

            //calculate the second car------------------------------------------------------------------------------------
            if (Dos.speed - speedLimit <= 0)
            {
                Console.WriteLine(Dos.make + " " + Dos.model + " " + Dos.speed + "mph: OK");
            }
            else if (Dos.speed - speedLimit > 0)
            {
                demerits = ((Dos.speed - speedLimit) / 5);
                if (demerits < 10)
                {
                    Console.WriteLine(Dos.make + " " + Dos.model + " " + Dos.speed + "mph: " + demerits + " demerits");
                }
                else if (demerits >= 10)
                {
                    Console.WriteLine(Dos.make + " " + Dos.model + " " + Dos.speed + "mph: " + demerits + " demerits <LICENSE SUSPENDED>");
                }

            }

            //calculate the third car------------------------------------------------------------------------------------
            if (Tres.speed - speedLimit <= 0)
            {
                Console.WriteLine(Tres.make + " " + Tres.model + " " + Tres.speed + "mph: OK");
            }
            else if (Tres.speed - speedLimit > 0)
            {
                demerits = ((Tres.speed - speedLimit) / 5);
                if (demerits < 10)
                {
                    Console.WriteLine(Tres.make + " " + Tres.model + " " + Tres.speed + "mph: " + demerits + " demerits");
                }
                else if (demerits >= 10)
                {
                    Console.WriteLine(Tres.make + " " + Tres.model + " " + Tres.speed + "mph: " + demerits + " demerits <LICENSE SUSPENDED>");
                }

            }

        }
    }
   
}
public class Car
{
    //hold variables
    public string make;
    public string model;
    public int speed;
}


