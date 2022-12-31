using System;

namespace oop_lab_lacyrich
{   

    public class Program
    {     
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your TV Shopping Program!");
            CreateSamsungTV();
            CreatePortableTV();

        }

        static void CreateSamsungTV(){
            //television constructor
            Television samsungTV = new Television(32, "Samsung");
           
            //using the ToString method to write out the details of the TV
            Console.WriteLine("Samsung TV: " + samsungTV.ToString()); 

            //buy the TV
            Console.WriteLine("Let's buy the TV.");
            samsungTV.BuyTV();

            //ask the user how many payments they'd like to make when purchasing the TV
            Console.WriteLine("How many payments would you like to make?");
            int userInput = int.Parse(Console.ReadLine());
            //set number of payments with the User's input
            samsungTV.SetNumPayments(userInput);

           //using the ToString method to write out the details of the TV
            Console.WriteLine(samsungTV.ToString());
            //return the TV
            Console.WriteLine("Turns out you didn't like the TV that much. Let's return it.");
            samsungTV.ReturnTV();
            
            //using the ToString method to write out the details of the TV
            Console.WriteLine(samsungTV.ToString());
        }

         static public void CreatePortableTV(){
             //television constructor - Declare another Television object called portable - Instantiate portable to be a Sharp 19 inch television
            Television portable = new Television(19, "Sharp");
           
            //Use a Console.WriteLine and the ToString method to write out the details of the TV to the console
            Console.WriteLine("Sharp TV: " + portable.ToString()); 

            //Use calls to the mutator methods to decrease the price by 100
            portable.DecreasePrice();
 
            //buy the TV
            portable.BuyTV();

            //ask the user how many payments they'd like to make when purchasing the TV
            Console.WriteLine("How many payments would you like to make?");
            int userInput = int.Parse(Console.ReadLine());
            //set number of payments with the User's input
            portable.SetNumPayments(userInput);

           //Use calls to the accessor methods to print the changed state of portable
            Console.WriteLine(portable.ToString());
        }


    }

}