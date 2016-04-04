using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    struct Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int telephoneNumber;

        public int Mobile
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }
        
        private Type type;
        

        public Person(string name, string address, int age, int telephoneNumber, Type type)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.telephoneNumber = telephoneNumber;
            this.type = type;
        }
        public override string ToString()
        {
            return (String.Format("Name: {0}, Address: {1}, Age: {2}, Telephone number: {3}, Type: {4}", name, address, age, telephoneNumber, type));
        }

    }
    enum Type { Home, Workplace, Mobile }
}
