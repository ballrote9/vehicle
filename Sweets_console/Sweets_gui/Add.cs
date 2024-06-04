using Sweets_console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweets_gui
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    label2.Text = "Name:"; label3.Text = "Weight:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Visible = false; label5.Visible = false;

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = false; textBox4.Visible = false;

                    break;
                case 1:
                    label2.Text = "Name:"; label3.Text = "Weight:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Type:"; label5.Text = "Calories:";
                    label4.Visible = true; label5.Visible = true;

                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;

                    break;
                case 2:
                    label2.Text = "Name:"; label3.Text = "Weight:";
                    label2.Visible = true; label3.Visible = true;

                    label4.Text = "Brand:"; label5.Text = "Tasties:";
                    label4.Visible = true; label5.Visible = true;


                    textBox1.Visible = true; textBox2.Visible = true;
                    textBox3.Visible = true; textBox4.Visible = true;
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
                    if (textBox1.Text != "" || textBox2.Text != "")
                    {
                        Sweets sweets = new Sweets();
                        sweets.Name = textBox1.Text;
                        sweets.Weight = int.Parse(textBox2.Text);
                        Data_store.sweets_items.Add(sweets);
                        Data_store.Type = "Sweets";
                    }

                    break;
                case 1:

                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "")
                    {
                        CandiesSweets candies = new CandiesSweets();
                        candies.Name = textBox1.Text;
                        candies.Weight = int.Parse((textBox2.Text).Trim());
                        candies.Type = textBox3.Text;
                        candies.Calories = int.Parse(textBox4.Text);
                        Data_store.candies_items.Add(candies);
                        Data_store.Type = "CandiesSweets";
                    }

                    break;
                case 2:

                    if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != ""
                        || textBox4.Text != "")
                    {
                        ChocolatesSweets chocolates = new ChocolatesSweets();
                        chocolates.Name = textBox1.Text;
                        chocolates.Weight = int.Parse((textBox2.Text).Trim());
                        chocolates.Brand = textBox3.Text;
                        chocolates.Taste = textBox4.Text;
                        Data_store.chocolates_items.Add(chocolates);
                        Data_store.Type = "ChocolatesSweets";
                    }

                    break;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
