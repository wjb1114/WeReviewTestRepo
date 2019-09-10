﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    class Weather
    {
       
        //member variables
        public string todayWeather;
        public int dayOfTheWeek = 0;
        public List<int> WeekWeather = new List<int>();
        public List<string> WordsWeekWeather = new List<string>();

        //ctor
        public Weather()
        {

        }
        //member methods

        public void GenerateForecast()
        {
            int RandomNumber(int min, int max)
            {
                System.Threading.Thread.Sleep(500);
                Random weatherOption = new Random();
                return weatherOption.Next(min, max);
            }

            List<string> WeatherTypes = new List<string>();
            WeatherTypes.Add("sunny");
            WeatherTypes.Add("cloudy");
            WeatherTypes.Add("rainy");
            WeatherTypes.Add("tornado");
            WeatherTypes.Add("heat wave");


            for (int i = 0; i < 7; i++)
            {
                dayOfTheWeek++;
                int theWeather = RandomNumber(0, 5);

                if (theWeather == 0)
                {
                    todayWeather = WeatherTypes[0];
                    WeekWeather.Add(theWeather);
                    WordsWeekWeather.Add("sunny");
                    Console.WriteLine($"Day {dayOfTheWeek} will have {todayWeather} weather.");
                }
                else if (theWeather == 1)
                {
                    todayWeather = WeatherTypes[1];
                    WeekWeather.Add(theWeather);
                    WordsWeekWeather.Add("cloudy");
                    Console.WriteLine($"Day {dayOfTheWeek} will have {todayWeather} weather.");
                }
                else if (theWeather == 2)
                {
                    todayWeather = WeatherTypes[2];
                    WeekWeather.Add(theWeather);
                    WordsWeekWeather.Add("rainy");
                    Console.WriteLine($"Day {dayOfTheWeek} will have {todayWeather} weather.");
                }
                else if (theWeather == 3)
                {
                    todayWeather = WeatherTypes[3];
                    WeekWeather.Add(theWeather);
                    WordsWeekWeather.Add("tornado");
                    Console.WriteLine($"Day {dayOfTheWeek} will have {todayWeather} weather.");
                }
                else if (theWeather == 4)
                {
                    todayWeather = WeatherTypes[4];
                    WeekWeather.Add(theWeather);
                    WordsWeekWeather.Add("heat wave");
                    Console.WriteLine($"Day {dayOfTheWeek} will have {todayWeather} weather.");
                }
            }
            


            //last line of generateforecast method
        }

        //last line of big block
    }
}
