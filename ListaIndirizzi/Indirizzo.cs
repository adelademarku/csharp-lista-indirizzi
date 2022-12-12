using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    public class Indirizzo
    {
        //PROPRITA'

        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private int zipcodes;

        public Indirizzo(string name, string surname, string street, string city, string province, int zipcodes)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zipcodes = zipcodes;

        }
        //GETTERS

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetStreet()
        {
            return street;
        }
        public string GetCity()
        {
            return city;
        }
        public string GetProvince()
        {
            return province;
        }
        public int GetZipCodes()
        {
            return zipcodes;
        }
    }
}
