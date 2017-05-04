using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Product
    {
        private String _name;
        private String _content;
        private double _price;
        private int _countMade;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public int CountMade
        {
            get
            {
                return _countMade;
            }

            set
            {
                _countMade = value;
            }
        }

        public Product()
        {
            
        }

        public Product(string name, string content, double price, int countMade)
        {
            _name = name;
            _content = content;
            _price = price;
            _countMade = countMade;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Content)}: {Content}, {nameof(Price)}: {Price}, {nameof(CountMade)}: {CountMade}";
        }
    }
}
