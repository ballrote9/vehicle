using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicles_;

namespace Vehicle_gui
{
    public class Total_sum
    {
        public static double total_sum_func (List <Public_Transport> list_box_items)
        {
            double sum = 0;
            for (int i = 0; i < list_box_items.Count; i++)
                sum += list_box_items[i].Price;
            return sum;
        }
    };
    public partial class Main_form : Form
    {
        public Main_form()
        {
            this.CenterToParent();

            InitializeComponent();

            string[] bus_53_stations = { "Horticultural Society \"Spring\"", "Vetrovaya", "Stepnaya", "Toyanovskaya", "Yuzhnyye vorota", "Stepanovskiy per", "Volgogradskaya", "Prirechnaya" };
            string[] tram_1_stations = { "Vostochnaya", "Michurinskiye sady", "Gorodok stroiteley", "L'va Tolstogo", "Detskaya bol'nitsa №4", "Chkalova", "Lebedeva", "pr. Komsomol'skiy", "Yeniseyskaya" };
            string[] trolleybus_2_stations = { "Trolleybusnoye depo", "Kulagina", "Oblastnoy rynok", "L\'va Tolstogo", "Shevchenko", "pr. Komsomol\'skiy" };

            Public_Transport bus_53 = new Public_Transport();
            Public_Transport tram_1 = new Public_Transport();
            Public_Transport trolleybus_2 = new Public_Transport();
        
            bus_53.Name = "Bus #53"; bus_53.Price = 27; bus_53.Stations = bus_53_stations;
            tram_1.Name = "Tramway #1"; tram_1.Price = 25; tram_1.Stations = tram_1_stations;
            trolleybus_2.Name = "Trolleybus #2";  trolleybus_2.Price = 25; trolleybus_2.Stations = trolleybus_2_stations;

            
            Data_store.public_transport_items.Add(bus_53); listBox1.Items.Add(bus_53.Name);
            Data_store.public_transport_items.Add(tram_1); listBox1.Items.Add(tram_1.Name);
            Data_store.public_transport_items.Add(trolleybus_2); listBox1.Items.Add(trolleybus_2.Name);

            label1.Text = "Total cost: " + Total_sum.total_sum_func(Data_store.public_transport_items).ToString();
        }

        private void button1_Click(object sender, EventArgs e) //Add
        {
            int count_of_public_transport = Data_store.public_transport_items.Count;
            int count_of_ground_vehicles = Data_store.ground_vehicle_items.Count;
            int count_of_vehicles = Data_store.vehicle_items.Count;

            Add_form form2 = new Add_form();
            form2.Owner = this;
            form2.ShowDialog();

            if (count_of_public_transport != Data_store.public_transport_items.Count)
            {
                for (int i = count_of_public_transport; i < Data_store.public_transport_items.Count; i++)
                {
                    listBox1.Items.Add(Data_store.public_transport_items[i].Name);
                }
                label1.Text = "Total cost: " + Total_sum.total_sum_func(Data_store.public_transport_items).ToString();
            }
            if (count_of_ground_vehicles != Data_store.ground_vehicle_items.Count)
            {
                for (int i = count_of_ground_vehicles; i < Data_store.ground_vehicle_items.Count; i++)
                {
                    listBox1.Items.Add(Data_store.ground_vehicle_items[i].Name);
                }
            }
            if (count_of_vehicles != Data_store.vehicle_items.Count)
            {
                for (int i = count_of_ground_vehicles; i < Data_store.vehicle_items.Count; i++)
                {
                    listBox1.Items.Add(Data_store.vehicle_items[i].Name);
                }
            }
        }


        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;
            
                if (ind != -1)
            {    
                string name = listBox1.Items[ind].ToString();
                listBox1.Items.RemoveAt(ind);
               
                for (int i = 0; i < Data_store.vehicle_items.Count; i++)
                    if (Data_store.vehicle_items[i].Name == name)
                    {
                        Data_store.vehicle_items.RemoveAt(i);
                        break;
                    }
               
                for (int i = 0; i < Data_store.ground_vehicle_items.Count; i++)
                    if (Data_store.ground_vehicle_items[i].Name == name)
                    {
                        Data_store.ground_vehicle_items.RemoveAt(i);
                        break;
                    }

                for (int i = 0; i < Data_store.public_transport_items.Count; i++)
                    if (Data_store.public_transport_items[i].Name == name)
                    {
                        Data_store.public_transport_items.RemoveAt(i);
                        break;
                    }
                label1.Text = "Total cost: " + Total_sum.total_sum_func(Data_store.public_transport_items).ToString();
            }

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;

            if (ind != -1)
            {
                string name = listBox1.Items[ind].ToString();

                for (int i = 0; i < Data_store.vehicle_items.Count; i++)
                    if (Data_store.vehicle_items[i].Name == name)
                    {
                        Data_store.Type = "vehicles";
                        Data_store.Ind = i;
                        break;
                    }

                for (int i = 0; i < Data_store.ground_vehicle_items.Count; i++)
                    if (Data_store.ground_vehicle_items[i].Name == name)
                    {
                        Data_store.Type = "ground_vehicles";
                        Data_store.Ind = i;
                        break;
                    }

                for (int i = 0; i < Data_store.public_transport_items.Count; i++)
                    if (Data_store.public_transport_items[i].Name == name)
                    {
                        Data_store.Type = "public_transport";
                        Data_store.Ind = i;
                        break;
                    }
            }

            Edit_form edit_Form = new Edit_form();

            edit_Form.ShowDialog();
            label1.Text = "Total cost: " + Total_sum.total_sum_func(Data_store.public_transport_items).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
