using Sweets_console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweets_gui
{


    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_form_Load(object sender, EventArgs e)
        {
            int ind = Data_store.Ind;
            switch (Data_store.Type)
            {
                case "Sweets":

                    label2.Text = "Name:"; label3.Text = "Weight:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Visible = false; label5.Visible = false;

                    textBox1.Text = Data_store.sweets_items[ind].Name;
                    textBox2.Text = Data_store.sweets_items[ind].Weight.ToString();

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = false; textBox4.Visible = false;

                    break;

                case "CandiesSweets":
                    label2.Text = "Name:"; label3.Text = "Weight:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Type:"; label5.Text = "Calories:";
                    label4.Visible = true; label5.Visible = true;

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;

                    textBox1.Text = Data_store.candies_items[ind].Name;
                    textBox2.Text = Data_store.candies_items[ind].Weight.ToString();
                    textBox3.Text = Data_store.candies_items[ind].Type;
                    textBox4.Text = Data_store.candies_items[ind].Calories.ToString();
                    break;

                case "ChocolatesSweets":
                    label2.Text = "Name:"; label3.Text = "Weight:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Brand:"; label5.Text = "Tasties:";
                    label4.Visible = true; label5.Visible = true;


                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;

                    textBox1.Text = Data_store.chocolates_items[ind].Name;
                    textBox2.Text = Data_store.chocolates_items[ind].Weight.ToString();
                    textBox3.Text = Data_store.chocolates_items[ind].Brand;
                    textBox4.Text = Data_store.chocolates_items[ind].Taste;
                    break;
                default:
                    label2.Visible = false; label3.Visible = false;
                    label4.Visible = false; label5.Visible = false;

                    textBox1.Visible = false; textBox2.Visible = false;
                    textBox3.Visible = false; textBox4.Visible = false;

                    break;
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            int ind = Data_store.Ind;

            switch (Data_store.Type)
            {
                case "Sweets":
                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "")
                    {
                        Data_store.sweets_items[ind].Name = textBox1.Text;
                        Data_store.sweets_items[ind].Weight = int.Parse(textBox2.Text);
                    }
                    break;
                case "CandiesSweets":
                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "" )
                    {
                        Data_store.candies_items[ind].Name = textBox1.Text;
                        Data_store.candies_items[ind].Weight = int.Parse(textBox2.Text);
                        Data_store.candies_items[ind].Type = textBox3.Text;
                        Data_store.candies_items[ind].Calories = int.Parse((textBox4.Text).Trim());
                    }
                    break;
                case "ChocolatesSweets":
                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "" )
                    {
                        Data_store.chocolates_items[ind].Name = textBox1.Text;
                        Data_store.chocolates_items[ind].Weight = int.Parse(textBox2.Text);
                        Data_store.chocolates_items[ind].Brand = textBox3.Text;
                        Data_store.chocolates_items[ind].Taste = textBox4.Text;
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
