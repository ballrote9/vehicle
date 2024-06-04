using Sweets_console;

namespace Sweets_gui
{
    public partial class Main : Form
    {
        public class Total_weight
        {
            public static double total_weight_func(List<Sweets> sweets, List<CandiesSweets> candies, List<ChocolatesSweets> chocolates)
            {
                double sum = 0;
                for (int i = 0; i < sweets.Count; i++)
                    sum += sweets[i].Weight;
                for (int i = 0; i < candies.Count; i++)
                    sum += candies[i].Weight;
                for (int i = 0; i < chocolates.Count; i++)
                    sum += chocolates[i].Weight;
                return sum;
            }
        };

        public Main()
        {
            InitializeComponent();
            Sweets step = new Sweets();
            step.Weight = 50; step.Name = "Step";
            CandiesSweets candiesSweets = new CandiesSweets();
            candiesSweets.Weight = 15; candiesSweets.Calories = 150;
            candiesSweets.Name = "candies"; candiesSweets.Type = "Smthg";
            Data_store.sweets_items.Add(step); listBox1.Items.Add(Data_store.sweets_items[0].Name);
            Data_store.candies_items.Add(candiesSweets); listBox1.Items.Add(Data_store.candies_items[0].Name);
            label1.Text = "Total weight: " + Total_weight.total_weight_func(Data_store.sweets_items, Data_store.candies_items, Data_store.chocolates_items).ToString();
        }



        private void button1_Click(object sender, EventArgs e) //Add
        {
            int count_of_sweets = Data_store.sweets_items.Count;
            int count_of_candies = Data_store.candies_items.Count;
            int count_of_chocolates = Data_store.chocolates_items.Count;
            
            Add add_Form = new Add();
            add_Form.ShowDialog();

            if (count_of_sweets != Data_store.sweets_items.Count)
            {
                    listBox1.Items.Add(Data_store.sweets_items[count_of_sweets].Name);
            }
            if (count_of_candies != Data_store.candies_items.Count)
            {
                for (int i = count_of_candies; i < Data_store.candies_items.Count; i++)
                {
                    listBox1.Items.Add(Data_store.candies_items[i].Name);
                }
            }
            if (count_of_chocolates != Data_store.chocolates_items.Count)
            {
                for (int i = count_of_chocolates; i < Data_store.chocolates_items.Count; i++)
                {
                    listBox1.Items.Add(Data_store.chocolates_items[i].Name);
                }
            }
            label1.Text = "Total weight: " + Total_weight.total_weight_func(Data_store.sweets_items, Data_store.candies_items, Data_store.chocolates_items).ToString();
        }


        private void óäàëèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;

            if (ind != -1)
            {
                string name = listBox1.Items[ind].ToString();
                listBox1.Items.RemoveAt(ind);

                for (int i = 0; i < Data_store.sweets_items.Count; i++)
                    if (Data_store.sweets_items[i].Name == name)
                    {
                        Data_store.sweets_items.RemoveAt(i);
                        break;
                    }

                for (int i = 0; i < Data_store.candies_items.Count; i++)
                    if (Data_store.candies_items[i].Name == name)
                    {
                        Data_store.candies_items.RemoveAt(i);
                        break;
                    }

                for (int i = 0; i < Data_store.chocolates_items.Count; i++)
                    if (Data_store.chocolates_items[i].Name == name)
                    {
                        Data_store.chocolates_items.RemoveAt(i);
                        break;
                    }
                label1.Text = "Total weight: " + Total_weight.total_weight_func(Data_store.sweets_items, Data_store.candies_items, Data_store.chocolates_items).ToString();
            }

        }

        private void ðåäàêòèðîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;

            if (ind != -1)
            {
                string name = listBox1.Items[ind].ToString();
                label1.Text = name;
                for (int i = 0; i < Data_store.sweets_items.Count; i++)
                    if (Data_store.sweets_items[i].Name == name)
                    {
                        Data_store.Type = "Sweets";
                        Data_store.Ind = i;
                        break;
                    }

                for (int i = 0; i < Data_store.candies_items.Count; i++)
                    if (Data_store.candies_items[i].Name == name)
                    {
                        Data_store.Type = "CandiesSweets";
                        Data_store.Ind = i;
                        break;
                    }

                for (int i = 0; i < Data_store.chocolates_items.Count; i++)
                    if (Data_store.chocolates_items[i].Name == name)
                    {
                        Data_store.Type = "ChocolatesSweets";
                        Data_store.Ind = i;
                        break;
                    }
            }

            Edit edit_Form = new Edit();
            edit_Form.ShowDialog();

            label1.Text = "Total weight: " + Total_weight.total_weight_func(Data_store.sweets_items, Data_store.candies_items, Data_store.chocolates_items).ToString();
        }
    }
}