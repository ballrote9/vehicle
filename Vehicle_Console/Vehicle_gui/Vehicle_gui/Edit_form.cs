using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Vehicles_;

namespace Vehicle_gui
{
    public partial class Edit_form : Form
    {
        public Edit_form()
        {
            InitializeComponent();
        }

        private void Edit_form_Load(object sender, EventArgs e)
        {
            int ind = Data_store.Ind;
            switch (Data_store.Type)
            {
                case "vehicles":

                    label2.Text = "Name:"; label3.Text = "Count of sit place:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Fuel:"; label5.Text = "Top speed:";
                    label4.Visible = true; label5.Visible = true;

                    label6.Visible = false; label7.Visible = false;
                    label8.Visible = false; label9.Visible = false;
                    label10.Visible = false;

                    textBox1.Text = Data_store.vehicle_items[ind].Name;
                    textBox2.Text = Data_store.vehicle_items[ind].Count_of_sit_places.ToString();
                    textBox3.Text = Data_store.vehicle_items[ind].Fuel;
                    textBox4.Text = Data_store.vehicle_items[ind].Top_speed.ToString();

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;

                    textBox5.Visible = false; textBox6.Visible = false;
                    textBox7.Visible = false; textBox8.Visible = false;
                    textBox9.Visible = false;
                    break;
                case "ground_transport":
                    label2.Text = "Name:"; label3.Text = "Count of sit place:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Fuel:"; label5.Text = "Top speed:";
                    label4.Visible = true; label5.Visible = true;

                    label8.Visible = false; label9.Visible = false;
                    label10.Visible = false;

                    label6.Text = "Car case:"; label7.Text = "Count of wheels:";
                    label6.Visible = true; label7.Visible = true;

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;
                    textBox5.Visible = true; textBox6.Visible = true;

                    textBox1.Text = Data_store.ground_vehicle_items[ind].Name;
                    textBox2.Text = Data_store.ground_vehicle_items[ind].Count_of_sit_places.ToString();
                    textBox3.Text = Data_store.ground_vehicle_items[ind].Fuel;
                    textBox4.Text = Data_store.ground_vehicle_items[ind].Top_speed.ToString();
                    textBox5.Text = Data_store.ground_vehicle_items[ind].Carcase;
                    textBox6.Text = Data_store.ground_vehicle_items[ind].Сount_of_wheels.ToString();

                    textBox7.Visible = false; textBox8.Visible = false;
                    textBox9.Visible = false;
                    break;
                case "public_transport":
                    label2.Text = "Name:"; label3.Text = "Count of sit place:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Fuel:"; label5.Text = "Top speed:";
                    label4.Visible = true; label5.Visible = true;

                    label6.Text = "Car case:"; label7.Text = "Count of wheels:";
                    label6.Visible = true; label7.Visible = true;

                    label8.Text = "Price:"; label9.Text = "Count of stand places:";
                    label8.Visible = true; label9.Visible = true;
                    label10.Text = "Stations:";
                    label10.Visible = true;

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;
                    textBox5.Visible = true; textBox6.Visible = true;

                    textBox1.Text = Data_store.public_transport_items[ind].Name;
                    textBox2.Text = Data_store.public_transport_items[ind].Count_of_sit_places.ToString();
                    textBox3.Text = Data_store.public_transport_items[ind].Fuel;
                    textBox4.Text = Data_store.public_transport_items[ind].Top_speed.ToString();
                    textBox5.Text = Data_store.public_transport_items[ind].Carcase;
                    textBox6.Text = Data_store.public_transport_items[ind].Сount_of_wheels.ToString();
                    textBox7.Text = Data_store.public_transport_items[ind].Price.ToString();
                    textBox8.Text = Data_store.public_transport_items[ind].Count_of_stay_places.ToString();

                    string stations = "";
                    int len = Data_store.public_transport_items[ind].Stations.Length;
                    for (int i = 0; i < len; i++)
                    {
                        if (Data_store.public_transport_items[ind].Stations.Length - i > 1)
                            stations += Data_store.public_transport_items[ind].Stations[i] + ", ";
                        else
                            stations += Data_store.public_transport_items[ind].Stations[i];
                    }
                    textBox9.Text = stations;

                    textBox7.Visible = true; textBox8.Visible = true;
                    textBox9.Visible = true;
                    break;
                default:
                    label2.Visible = false; label3.Visible = false;
                    label4.Visible = false; label5.Visible = false;

                    label6.Visible = false; label7.Visible = false;
                    label8.Visible = false; label9.Visible = false;
                    label10.Visible = false;

                    textBox1.Visible = false; textBox2.Visible = false;
                    textBox3.Visible = false; textBox4.Visible = false;

                    textBox5.Visible = false; textBox6.Visible = false;
                    textBox7.Visible = false; textBox8.Visible = false;
                    textBox9.Visible = false;
                    break;
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            int ind = Data_store.Ind;

            switch (Data_store.Type)
            {
                case "vehicles":
                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "")
                    {
                        Data_store.vehicle_items[ind].Name = textBox1.Text;
                        Data_store.vehicle_items[ind].Count_of_sit_places = int.Parse(textBox2.Text);
                        Data_store.vehicle_items[ind].Fuel = textBox3.Text;
                        Data_store.vehicle_items[ind].Top_speed = int.Parse(textBox4.Text);
                    }
                    break;
                case "ground_transport":
                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "")
                    {
                        Data_store.ground_vehicle_items[ind].Name = textBox1.Text;
                        Data_store.ground_vehicle_items[ind].Count_of_sit_places = int.Parse((textBox2.Text).Trim());
                        Data_store.ground_vehicle_items[ind].Fuel = textBox3.Text;
                        Data_store.ground_vehicle_items[ind].Top_speed = int.Parse(textBox4.Text);
                        Data_store.ground_vehicle_items[ind].Carcase = textBox5.Text;
                        Data_store.ground_vehicle_items[ind].Сount_of_wheels = int.Parse(textBox6.Text);
                    }
                    break;
                case "public_transport":
                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != ""
                        || textBox7.Text != "" || textBox8.Text != "" || textBox9.Text != "")
                    {
                        Data_store.public_transport_items[ind].Name = textBox1.Text;
                        Data_store.public_transport_items[ind].Count_of_sit_places = int.Parse((textBox2.Text).Trim());
                        Data_store.public_transport_items[ind].Fuel = textBox3.Text;
                        Data_store.public_transport_items[ind].Top_speed = int.Parse(textBox4.Text);
                        Data_store.public_transport_items[ind].Carcase = textBox5.Text;
                        Data_store.public_transport_items[ind].Сount_of_wheels = int.Parse(textBox6.Text);
                        Data_store.public_transport_items[ind].Price = int.Parse(textBox7.Text);
                        Data_store.public_transport_items[ind].Count_of_stay_places = int.Parse((textBox8.Text).Trim());
                        Data_store.public_transport_items[ind].Stations = textBox9.Text.Split(',');
                    }
                    break;
            }

            Data_store.Type = "";
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Data_store.Type = "";
            this.Close();
        }
    }
}
