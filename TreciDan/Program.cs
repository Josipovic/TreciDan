﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciDan
{
    class Program
    {
        static void Main(string[] args)   //enkapsulacija
        {

            //Ucenik katarina = new Ucenik();
            //int id = katarina.GetID();
            //Console.WriteLine(id);
            //string ime = katarina.GetIme();

            //Console.WriteLine(ime);

            //poslovna logika ---->

            //ID ne smije biti negativan ili 0
            //ime ne smije biti null ili ""
            //ako ime nije postavljeno vraca se "nije postavljeno"
            //prolazna ocijena se može samo procitati

            //Kuna k = new Kuna();
            //k.Kolicina = 100;
            //Console.WriteLine(k.Euri);
            //Console.WriteLine(k.Dinari);
            //Console.WriteLine(k.Dolari);
            //Console.WriteLine(k.Forinte);

            Mobitel x = new Mobitel();
            x.Boja = "zelena";
            x.BrojProcesora = -1;
            x.Dijagonala = -1;
            x.Marka = "";
            x.Ram = -1;


            Console.ReadLine();

            //odradjeno:
            //tipovi podataka(int,string,double,float..)
            //2 vrste tipova:value,reference
            //operatori :logicki,relacijski,aritmeticki
            //inkrement
            //dekrement
            //pridruzivanje =
            //naredbe grananja if,if else,elseif,switch case
            //naredbe ponavljanja for,while,do while,foreach
            //array---string[]recenica=new string[10];
            //int[]brojevi=new int[6];
            //int[]brojevi2={1,2,3,4,5};
            //komentari
            //klase-slozeni tipovi podataka koji sadrze varijable i funkcije(metode)
            //konstruktor -poziva se prilikom kreiranja instance iz klase
            //preoptereceni konstruktor(parametarski)
            //preopterecivanje metoda
            //metode(primaju parametre,vracaju vrijednosti itd..)
            //method hiding 
            //method override
            //polimorfizam
            //enkapsulacija pomocu getera i setera i pomocu propertija
            //autogenerated property prop+tab+tab
        }
    }
}
