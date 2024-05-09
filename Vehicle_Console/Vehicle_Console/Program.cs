// See https://aka.ms/new-console-template for more information

using Vehicles_;
using System;
using System.Runtime.ConstrainedExecution;

namespace Vehicle_Console {
    class Program
    {
        static void Main(string[] args)
        {
            string[] bus_53_stations = { "Horticultural Society \"Spring\"", "Vetrovaya", "Stepnaya", "Toyanovskaya", "Yuzhnyye vorota", "Stepanovskiy per", "Volgogradskaya", "Prirechnaya" };
            string[] tram_1_stations = { "Vostochnaya","Michurinskiye sady", "Gorodok stroiteley", "L'va Tolstogo", "Detskaya bol'nitsa №4", "Chkalova", "Lebedeva","pr. Komsomol'skiy", "Yeniseyskaya" };
            string[] trolleybus_2_stations = { "Trolleybusnoye depo", "Kulagina", "Oblastnoy rynok", "L\'va Tolstogo",  "Shevchenko", "pr. Komsomol\'skiy" };

            Public_Transport bus_53 = new Public_Transport("Bus №53", bus_53_stations, 27);
            Public_Transport  tram_1 = new Public_Transport("Tram #1", tram_1_stations, 25);
            Public_Transport trolleybus_2 = new Public_Transport("Trolleybus №2", trolleybus_2_stations, 25);

            Public_Transport[] example_trans_1 = {tram_1, trolleybus_2};
            Marshrut marshrut_1 = new Marshrut("Vostochnaya", "Trolleybusnoye depo", example_trans_1);

            Public_Transport[] example_trans_2 = { bus_53 };
            Marshrut marshrut_2 = new Marshrut("Prirechnaya", "Horticultural Society \"Spring\"", example_trans_2);

            Console.WriteLine((marshrut_1.A_station + "->" + marshrut_1.B_station + "\n" +  "Will cost " + General_logick.General_cost(marshrut_1).ToString() + " rub.").ToString());
           
            Console.WriteLine(("\n" + marshrut_2.A_station + "->" + marshrut_2.B_station + "\n" + "Will cost " + General_logick.General_cost(marshrut_2).ToString() + " rub.").ToString());
        }
    };


 }