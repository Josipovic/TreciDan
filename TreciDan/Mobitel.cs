using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciDan
{
    class Mobitel
    {
        public int _Dijagonala { get; set; }
        public float _Ram { get; set; }
        public string _Marka { get; set; }
        public int _BrojProcesora { get; set; }
        public string _Boja { get; set; }


        public int Dijagonala
        {

            get
            {
                return _Dijagonala;
            }
            set
            {
                if (value > 0)
                {
                    _Dijagonala = value;
                }

            }
        }
        public float Ram
        {
            get
            {
                return _Ram;
            }
            set
            {
                if (value % 8 == 0)
                {
                    _Ram = value;
                }
                else
                {
                    Console.WriteLine("ram mora biti djeljiv sa brojem 8");
                }

            }

        }
        public string Marka
        {
            get {
                return _Marka;

            }
            set {
                if (string.IsNullOrEmpty(value) == false)
                {
                    _Marka = value;
                }
                else {
                    Console.WriteLine("error");
                }
            }
        }
        public string Boja {
            
            get {
                return _Boja;
            }
            set {
                if (value.ToLower() == "crna" || value.ToLower() == "bijela")
                {
                    _Boja = value;
                }
                else {
                    Console.WriteLine("boja mora biti crna ili bijela");
                }

            }
        }
        public int BrojProcesora
        {
            get
            {
                return _BrojProcesora;
            }
            set
            {
                if (value % 2 == 0)
                {
                    _BrojProcesora = value;
                }
                else
                {
                    Console.WriteLine("broj procesora mora biti djeljiv sa brojem 8");
                }

            }

        }
    }
}
