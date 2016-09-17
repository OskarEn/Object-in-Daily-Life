using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGirlFriend
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is written about Helen. It is for entertainment purposes and will give the user
            //some options over the course of the running of the program to make Helen happy!
            //Written by Oskar Enmalm 17.09.16
            Console.Title = ("Can you make Helen happy?");
            GF Helen = new GF(); //object Helen created in GF class
            Helen.Start(); //calling the start method which calls the other methods within the GF class

            Console.WriteLine("Thanks for playing!" + "\nPress any key to exit");//exit
            Console.ReadKey();


        }
    }
}
