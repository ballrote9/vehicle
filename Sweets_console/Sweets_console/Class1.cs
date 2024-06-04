namespace Sweets_console
{
    public class Sweets
      {
            private string _name;
            private double _weight;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public double Weight
            {
                get { return _weight; }
                set { _weight = value; }
            }
        }
        public class CandiesSweets : Sweets
        {
            private string _type;
            private int _calories;

            public string Type
            {
                get { return _type; }
                set { _type = value; }
            }
            public int Calories
            {
                get { return _calories; }
                set { _calories = value; }
            }
        }
        public class ChocolatesSweets : Sweets
        {
            private string _brand;
            private string _taste;

            public string Brand
            {
                get { return _brand; }
                set { _brand = value; }
            }

            public string Taste
            {
                get { return _taste; }
                set { _taste = value; }
            }
        }
        public class Wrapper : CandiesSweets
        {
            private string _color;

            public string Color
            {
                get { return _color; }
                set { _color = value; }
            }
        }
        public class SweetsGift
        {
            public static List<Sweets> Sweets = new List<Sweets>();

            public void AddSweetS(Sweets item)
            {
                Sweets.Add(item);
            }
        }
    }


