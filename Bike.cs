using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class Bike
    {
        //Fields
        private string _brand;
        public enum TypesofBikes { electric, mountain, unicycle };
        public string _color;
        TypesofBikes _type;
        public int _numberOfWheels;

        public Bike(string brand, string color, int numberOfWheels)
        {
            _brand = brand;
            _color = color;
            _numberOfWheels = numberOfWheels;
        }

        //Properties
        public string Brand { get => _brand; set => _brand = value; }
        private TypesofBikes type { get => _type; set => _type = value; }
        public string Color { get => _color; set => _color = value; }
        public int NumberOfWheels { get => _numberOfWheels; set => _numberOfWheels = value; }
        


        public override string ToString()
        {
            return $"Brand: {_brand}, Color: {_color}, Number of Wheels: {_numberOfWheels} ";
        }
    }
}
