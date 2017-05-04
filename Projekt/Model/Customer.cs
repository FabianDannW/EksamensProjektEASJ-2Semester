using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    class Customer
    {
        private String _name;
        private int _phoneNr;
        private int _customerNr;
        private String _address;
        private String _email;

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

        public int PhoneNr
        {
            get
            {
                return _phoneNr;
            }

            set
            {
                _phoneNr = value;
            }
        }

        public int CustomerNr
        {
            get
            {
                return _customerNr;
            }

            set
            {
                _customerNr = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public Customer()
        {
            
        }

        public Customer(string name, int phoneNr, int customerNr, string address, string email)
        {
            _name = name;
            _phoneNr = phoneNr;
            _customerNr = customerNr;
            _address = address;
            _email = email;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(PhoneNr)}: {PhoneNr}, {nameof(CustomerNr)}: {CustomerNr}, {nameof(Address)}: {Address}, {nameof(Email)}: {Email}";
        }
    }
}
