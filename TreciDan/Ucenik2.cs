using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciDan
{
    class Ucenik2
    {
        private int _ID;
        private string _Ime;
        private string _Prezime;
        private int _ProlaznaOcijena; //samo za citanje bez set
        public string Email { get; set; } //ako nam ne treba neka dodatna logika,nemamo if
        public int ID {  //property

            get {

                return _ID;
            }
            set {
                if (value > 0)
                {
                    _ID = value;
                }
                else {
                    Console.WriteLine("id mora biti veci od nule");

                }
            }
}
        public string Ime{
            get {
                if (string.IsNullOrEmpty(_Ime) == false)
                {
                    return _Ime;
                }
                else
                {
                    return "Ime nije postavljeno";
                }
            }
            set {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _Ime = value;

                }
                else {
                    Console.WriteLine("ime mora biti postavljeno");
                }
            }


        }


        public string Prezime
        {
            get
            {
                if (string.IsNullOrEmpty(_Prezime) == false)
                {
                    return _Prezime;
                }
                else
                {
                    return "Prezime nije postavljeno";
                }
            }
            set
            {
                if (string.IsNullOrEmpty(_Prezime) == false)
                {
                    _Prezime = value;
                }
                else
                {
                    Console.WriteLine("nije postavljeno");
                }
            }
        }

        public int ProlaznaOcijena {
            get {
                return _ProlaznaOcijena;
            }
        }
        }
    }
