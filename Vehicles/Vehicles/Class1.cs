using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_
{
    class Vehicles
    {
        private string _name;
        private int _count_of_sit_places;
        private string _fuel;
        private int _top_speed;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Count_of_sit_places
        {
            get { return _count_of_sit_places; }
            set { _count_of_sit_places = value; }
        }

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public int Top_speed
        {
            get { return _top_speed; }
            set { _top_speed = value; }
        }
    };

    class Ground_vehciles : Vehicles
    {
        private string _carcase;
        private int _count_of_wheels;

        public string Carcase
        {
            get { return _carcase; }
            set { _carcase = value; }
        }

        public int Сount_of_wheels
        {
            get { return _count_of_wheels; }
            set { _count_of_wheels = value; }
        }
    };

    class Public_Transport : Ground_vehciles
    {
        private double _price;
        private int _count_of_stay_places;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Count_of_stay_places
        {
            get { return _count_of_stay_places; }
            set { _count_of_stay_places = value; }
        }
    };
}
