using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Text.Json;
using System.Net;
using Newtonsoft.Json;

namespace ConsoleApp1;
public class Program
{
    static string apiKey = "203e6a5443b533a04d05801ec217cc8a";
    static string defaultCity = "Tomsk, RU";
    class Weather
    {
        public string description { get; set; }
    }
    class Temperature
    {
        public float temp { get; set; }
    }
    class weather
    {
        public string name { get; set; }
        public Weather[] weatherCity { get; set; }
        public Temperature main { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите название города, чтобы получить погоду");
        string city = Console.ReadLine();
        if(city == " ")
        {
            GetWeather(defaultCity);
        }
        else
        {
            GetWeather(city);
        }
    }
    static void GetWeather(string city)
    {
        string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={apiKey}";
        using (WebClient weather = new WebClient())
        {
            string json = weather.DownloadString(url);
            weather weatherToday = JsonConvert.DeserializeObject<weather>(json);
            Console.WriteLine($"Температура в городе {city} сейчас {weatherToday.main.temp} °C, погода {weatherToday.weatherCity[0].description}");
        }
    }
}