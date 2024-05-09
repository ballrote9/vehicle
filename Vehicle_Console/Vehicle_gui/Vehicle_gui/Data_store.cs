using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles_;

namespace Vehicle_gui
{
    internal static class Data_store
    {
        public static List<Vehicles> vehicle_items = new List<Vehicles>();
        public static List<Ground_vehciles> ground_vehicle_items = new List<Ground_vehciles>();
        public static List<Public_Transport> public_transport_items = new List<Public_Transport>();

        public static string Type;
        public static int Ind;
    }
}
