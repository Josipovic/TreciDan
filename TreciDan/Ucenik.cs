using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciDan
{
    class Ucenik
    {
        private int ID;
        private string Ime;
        private int ProlaznaOcijena;

        //Geteri i seteri
        //geter funkcija koja dohvaca vrijednosti
        //seter funkcija koja postavlja vrijednosti

        public void SetID(int id) {
            if (id > 0)
            {
                ID = id;
            }
            else {

                Console.WriteLine("id mora biti veci od 0");
            }
        }

        public int GetID() {

            return ID;
        }


        public void SetIme(string ime) {

            if (string.IsNullOrEmpty(ime) == false)
            {
                this.Ime = ime;
            }
            else {

                Console.WriteLine("ime ne smije biti null ili prazno");
            }
        }

        public string GetIme() {


            if(string.IsNullOrEmpty(Ime)==true)
            {
                return "Nije postavljeno";

            }
            else
            {
                return Ime;
            }

        }

        public int GetProlaznaOcijena  () { 

            return ProlaznaOcijena;

        }


        //umjesto getera i setera ima jednostavniji nacin za enkapsulaciju a to je pomocu propertia
    }
}
