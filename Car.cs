using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        //Fields
        public string _make;
        public string _model;
        public int _year;
        public string _color;
        public int _mileage;



        //Properties
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                _mileage = value;
            }
        }

        public Car(string make, string model, int year, string color, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _color = color;
            _mileage = mileage;
        }

        public override string ToString()
        {
            return $"Make: {_make}, Model: {_model}, Year: {_year}, Color: {_color}, Mileage: {_mileage}";
        }

    }
}
