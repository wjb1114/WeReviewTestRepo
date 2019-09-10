﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class Customer
    {
        
        
        //member variables
        public int weatherPref;
        public int sugarPref;
        public int lemonPref;
        public int icePref;
        public int costPref;
        public bool willBuy;
        public int x;
        public int aMoney;
        public double aCup;

        //ctor
        public Customer(int weatherPref, int sugarPref, int lemonPref, int icePref, int costPref)
        {
            this.weatherPref = weatherPref;
            this.sugarPref = sugarPref;
            this.lemonPref = lemonPref;
            this.icePref = icePref;
            this.costPref = costPref;
        }
        //member methods
        public bool DecideToBuy(int theWeather, double theSugar, double theLemons, double theIce, double theCost)
        {
            if (theWeather != weatherPref)
            {
                willBuy = false;
                return willBuy;
            }
            else if (theCost > costPref)
            {
                willBuy = false;
                return willBuy;
            }
            else if (theWeather == weatherPref && theCost <= costPref)
            {
                willBuy = true;
                return willBuy;
            }
            else if (theSugar == sugarPref || theLemons == lemonPref)
            {
                willBuy = true;
                return willBuy;
            }
            else
            {
                willBuy = false;
                return willBuy;
            }
            //last line of decide to buy
        }

        public int MakePurchase(int theCost, int cashRegister)//add cup and cost parameters then put the buy/exchange in
        {
            if (willBuy == true)
            {
                ExchangeMoney(cashRegister, theCost);
                return aMoney;
            }
            else
            {
                return x = 1;
            }
        }

        public double TakeCup(double theCups)
        {
            if (willBuy == true)
            {
                BuyCup(theCups);
                return aCup;
            }
            else
            {
                return x = 1;
            }

        }



        public double BuyCup(double someCups)
        {
            aCup = someCups - 1;
            return aCup;
        }


        public int ExchangeMoney(int someMoney, int someCost)
        {
            aMoney = someMoney + someCost;
            return aMoney;
        }

        //last line of big block
    }
}
