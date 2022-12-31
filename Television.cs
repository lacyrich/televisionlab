using System;

namespace oop_lab_lacyrich
{
    public class Television
    {
        private string MANUFACTURER; //holds the brand name. Cannot change once the television is created, so it is a named constant
        private int SCREEN_SIZE;//holds the size of the screen. Cannot change once the television is created, so it is a named constant
        private bool isAvailable = true; //holds the value true if TV is available for purchase and false if the TV has been purchased
        private double price = 500.00; //holds the price value of the TV
        private int numPayments = 1; //holds the user-input value of the amount of payments for the TV

        public Television(int SCREEN_SIZE, string MANUFACTURER) 
        {
            this.SCREEN_SIZE = SCREEN_SIZE;
            this.MANUFACTURER = MANUFACTURER;
        }
        
        //stores the desired price in the price field
        public void SetPrice(double temp) 
        {
            price = temp;
        }
        
        //will return the value stored in the price field
        public double GetPrice() 
        {
            return price;
        }

        //stores the number of payments the user would like to have to pay for the TV
        public void SetNumPayments(int temp) 
        {
            numPayments = temp;
        }
        
        //will return the value of numPayments
        public int GetNumPayments() 
        {
            return numPayments;
        }

        //will return the constant value stored in the MANUFACTURER field
        public string GetManufacturer() 
        {
            return MANUFACTURER;
        }
        
        //will return the constant value stored in the SCREEN_SIZE field 
        public int GetScreenSize() 
        {
            return SCREEN_SIZE;
        }

        //will store if the television is available or not
        public void SetIsAvailable(bool temp) 
        {
            isAvailable = temp;
        }
        
        //will return the value of true or false for isAvailable
        public bool GetIsAvailable() 
        {
            return isAvailable;
        }

        //displays message telling user if the tv is available or if they bought it
        public string ToString()
        {
            if(isAvailable == true)
            {
                return "A " + SCREEN_SIZE + " inch " + MANUFACTURER + " is available for purchase for $" + price;
            }
            else
            {
                return  "You bought a " + SCREEN_SIZE + " inch " + MANUFACTURER + " TV. You’ll pay $" + GetPricePerPayment() + " " + numPayments + " time(s).";
            }
        }

        //BuyTV – changes the isAvailable field to false
        public void BuyTV() 
        {
            isAvailable = false;
        }

        //ReturnTV – changes the isAvailable field to true
        public void ReturnTV() 
        {
            isAvailable = true;
        }
        
        //will increase the value stored in the price field by 100
        public void IncreasePrice()  
        {
            price+= 100;
        }
        
        //will decrease the value stored in the price field by 100
        public void DecreasePrice() 
        {
            price-= 100;
            Console.WriteLine($"The TV went on sale for {price}! Let’s buy it.");
        }
        
        //will return the value of the price per payment (overall price / numPayments)
        public double GetPricePerPayment() 
        {
            return price/numPayments;
        }

    }
}

