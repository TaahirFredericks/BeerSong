using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_BeerSong_
{
    public class BeerSong 
    {
        public static string lyrics()
        {
            int beerNum = 99; //initial number of bottles
            String word = "bottles"; //string name

            while (beerNum > 0) //for the values of "beerNum" being greater than zero (apply below)
            {

                Console.WriteLine(beerNum + " " + word + " of beer on the wall, " + beerNum + " " + word + " of beer"); //insert the value + "bottles" and th rest of the lyrics
                beerNum = beerNum - 1; //minus one beerNum at the end of every sentence

                if (beerNum == 1)
                {
                    word = "bottle"; //only one bottle
                }

                if (beerNum > 0)
                {
                    Console.WriteLine("Take one down, pass it around " + beerNum + " " + word + " of beer on the wall"); //Added the second sentence
                }
            }

            if (beerNum == 0)
            {
                Console.WriteLine("Take one down, pass it around, no more bottles of beer on the wall"); //after "one more bottle", added "no more bottles of beer on the wall
            } 
            return ""; //return quotations
        }

    }
}