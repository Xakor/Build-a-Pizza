using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_a_Pizza.Models
{
    public class Meat
    {

        private int _id;
        private int _name;
        private string _picture;
        private float _price;
        public Meat()
        {
        }

        public Meat(int id, int name, string picture, float price)
        {
            _id = id;
            _name = name;
            _picture = picture;
            _price = price;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        
        public override string ToString()
        {
            return string.Format("Id{0},Name{1},Picture{2},Price{3}", Id, Name, Picture, Price);
        }
    }
}
