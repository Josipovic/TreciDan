using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciDan
{
    class Kuna
    {
        public float Kolicina { get; set; }
        

        public float Euri
        {
            get
            {

                return Kolicina / 7.41f;
            }
        }
        public float Dinari
        {
            get
            {
                return Kolicina * 15.91f;
            }
        }
        public float Dolari
        {
            get
            {
                return Kolicina * 0.15f;
            }

        }
        public float Forinte {
            get {
                return Kolicina *43.65f;

            }
        }
    }


}
