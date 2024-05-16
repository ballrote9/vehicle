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
    public partial class Add_form : Form
    {
        public Add_form()
        {
            
            InitializeComponent();
            this.CenterToParent();
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    label2.Text = "Name:"; label3.Text = "Count of sit place:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Fuel:"; label5.Text = "Top speed:";
                    label4.Visible = true; label5.Visible = true;

                    label6.Visible = false; label7.Visible = false;
                    label8.Visible = false; label9.Visible = false;
                    label10.Visible = false;

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;

                    textBox5.Visible = false; textBox6.Visible = false;
                    textBox7.Visible = false; textBox8.Visible = false;
                    textBox9.Visible = false;
                    break;
                case 1:
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

                    textBox7.Visible = false; textBox8.Visible = false;
                    textBox9.Visible = false;
                    break;
                case 2:
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

                    textBox7.Visible = true; textBox8.Visible = true;
                    textBox9.Visible = true;
                    break;
            }
        }

        bool is_valid_int(TextBox textBox)
        {
            bool ok = false;
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] >= '0' && textBox.Text[i] <= '9')
                {
                    ok = true;
                }
            }
            return ok;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (is_valid_int(textBox2) && is_valid_int(textBox4))
                    {
                        if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                            || textBox4.Text != "")
                        {
                            Vehicles vehicles = new Vehicles();
                            vehicles.Name = textBox1.Text;
                            vehicles.Count_of_sit_places = int.Parse(textBox2.Text);
                            vehicles.Fuel = textBox3.Text;
                            vehicles.Top_speed = int.Parse(textBox4.Text);
                            Data_store.vehicle_items.Add(vehicles);
                        }
                    }
                    break;
                case 1:
                    if (is_valid_int(textBox2) && is_valid_int(textBox4) && is_valid_int(textBox6))
                    {
                        if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                            || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "")
                        {
                            Ground_vehciles ground_Vehciles = new Ground_vehciles();
                            ground_Vehciles.Name = textBox1.Text;
                            ground_Vehciles.Count_of_sit_places = int.Parse((textBox2.Text).Trim());
                            ground_Vehciles.Fuel = textBox3.Text;
                            ground_Vehciles.Top_speed = int.Parse(textBox4.Text);
                            ground_Vehciles.Carcase = textBox5.Text;
                            ground_Vehciles.Сount_of_wheels = int.Parse(textBox6.Text);
                            Data_store.ground_vehicle_items.Add(ground_Vehciles);
                        }
                    }
                    break;
                case 2:
                    if (is_valid_int(textBox2) && is_valid_int(textBox4) && is_valid_int(textBox6) && is_valid_int(textBox7) && is_valid_int(textBox8))
                    {
                        if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                            || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != ""
                            || textBox7.Text != "" || textBox8.Text != "" || textBox9.Text != "")
                        {
                            Public_Transport public_transport = new Public_Transport();
                            public_transport.Name = textBox1.Text;
                            public_transport.Count_of_sit_places = int.Parse((textBox2.Text).Trim());
                            public_transport.Fuel = textBox3.Text;
                            public_transport.Top_speed = int.Parse(textBox4.Text);
                            public_transport.Carcase = textBox5.Text;
                            public_transport.Сount_of_wheels = int.Parse(textBox6.Text);
                            public_transport.Price = int.Parse(textBox7.Text);
                            public_transport.Count_of_stay_places = int.Parse((textBox8.Text).Trim());
                            public_transport.Stations = textBox9.Text.Split(',');
                            Data_store.public_transport_items.Add(public_transport);
                        }
                    }
                    break;
            }
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
