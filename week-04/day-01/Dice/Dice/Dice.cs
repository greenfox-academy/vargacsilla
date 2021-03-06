﻿using System;

namespace Dice
{
    public class Dice
    {
        //    You have a Dice class which has 6 dice
        //    You can roll all of them with Roll()
        //    Check the current rolled numbers with GetCurrent()
        //    You can reroll with Reroll()
        //    Your task is to get where all dice is a 6
        
        static int[] Dices = new int[6];

        public int[] Roll(Random RandomValue)
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Dices[i] = RandomValue.Next(1, 6);
            }
            return Dices;
        }

        public int[] GetCurrent()
        {
            return Dices;
        }

        public int GetCurrent(int i)
        {
            return Dices[i];
        }

        //public void Reroll(Random RandomValue)
        //{
        //    for (int i = 0; i < Dices.Length; i++)
        //    {
        //        Dices[i] = RandomValue.Next(1, 6);
        //    }
        //}

        public void Reroll(int k)
        {
            Dices[k] = new Random().Next(1, 6);
        }

        //public static void Main(string[] args)
        //{
        //    RandomValue = new Random();
        //    Dice myDice = new Dice();
        //    myDice.GetCurrent();
        //    myDice.Roll();
        //    myDice.GetCurrent();
        //    myDice.GetCurrent(5);
        //    myDice.Reroll();
        //    myDice.GetCurrent();
        //    myDice.Reroll(4);
        //    myDice.GetCurrent();
        //}
    }
}