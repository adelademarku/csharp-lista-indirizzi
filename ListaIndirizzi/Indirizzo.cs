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
        private string zipcodes;

       
        public Indirizzo(string name, string surname, string street, string city, string province, string zipcodes)
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
        public string GetZipCodes()
        {
            return zipcodes;
        }


        public override string ToString()
        {
            return "Nome: " + this.name + "\tSurname: " + this.surname + "\tStreet: " + this.street + "\tCity: " + this.city+ "\tProvince: " + this.province+ "\tZip Codes: " + this.zipcodes;
        }




     /*   public void StampaIndirizzo()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("surname: " + surname);
            Console.WriteLine("street: " + street);
            Console.WriteLine("city: " + city);
            Console.WriteLine("province: " + province);
            Console.WriteLine("zip codes: " + zipcodes);
        } */




    }
}
