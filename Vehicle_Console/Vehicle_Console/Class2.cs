using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vehicles_
{
    class General_logick
    {
        public static double General_cost(Marshrut marshrut)
        {
            double sum = 0;
            Public_Transport[] trans = marshrut.Transport;
            for (int i = 0; i < trans.Length; i++)
            {
                sum += trans[i].Price;
            }
            return sum;
        }
    };

    public class logicx
    {
        public static double General_cost(Public_Transport[] trans)
        {
            double sum = 0;
            for (int i = 0; i < trans.Length; i++)
            {
                sum += trans[i].Price;
            }
            return sum;
        }
    };

    class Marshrut
    {
        private string _a_station;
        private string _b_station;
        private Public_Transport[] _transport;

        public Marshrut(string a_station, string b_station, Public_Transport[] transport)
        {
            _transport = transport;
            A_station = a_station;
            B_station = b_station;
        }

        public string A_station
        {
            get { return _a_station; }
            set { _a_station = value; }
        }

        public Public_Transport[] Transport
        {
            get { return _transport; }
            set { _transport = value; }
        }

        public string B_station
        {
            get { return _b_station; }
            set { _b_station = value; }
        }
    }
}
