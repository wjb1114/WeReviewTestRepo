﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class LemonTree
    {
        //member variables
        public int givenLoans = 0;

        //ctor
        public LemonTree()
        {

        }
        //member methods
        
        public int PayBack(int funds)
        {
            givenLoans += funds;
            Console.WriteLine($"You will owe the lemon tree {givenLoans} cents at the end of the game.");

            return givenLoans;
        }
    }
}
