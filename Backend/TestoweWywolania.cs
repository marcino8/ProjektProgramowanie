﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    class TestoweWywolania
    {
       
        public static void Main(string[] args)
        {
            //public Uzytkownik(string imie, string nazwisko, string dataUrodzenia, string pesel, string email)
            Pracownik p1 = new Pracownik("Kornelia", "Kłopecka", "10-10-2000", "99900022211", "korneliakl@gmail.com");
            Pracownik p2 = new Pracownik("Jola", "Pront", "10-01-2010", "99111154611", "jopr@gmail.com");
            Pracownik p3 = new Pracownik("Agnieszka", "Mazik", "12-10-2022", "99901562211", "agumaz@gmail.com");
            Pracownik p4 = new Pracownik("Julia", "Mala", "10-11-2001", "22412663451", "jumal@gmail.com");

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Manager m1 = new Manager("Filip", "Twardy", "12-12-1999", "99901122211", "szefszefow@gmail.com");
            Manager m2 = new Manager("Krzysztof", "Jarzyna", "01-01-1967", "99906666211", "krzysztofjarzyna@gmail.com");

            Sponsor s1 = new Sponsor("Zuzanna", "Szewczyk", "12-12-1989", "99901122314", "sponsoruje@gmail.com");

            Console.WriteLine(m1);
            Console.WriteLine(m2);

            Console.WriteLine(s1);

            Zadanie z1 = new Zadanie("20-01-2021", "12-02-2021", "Skonczyc budowe fortepianu",
                "Naprawić struny, wymienić klawisze", new List<Pracownik>(new Pracownik[] { p1, p2 }),
                new List<Uwaga>(), Enumy.WaznoscZadania.Mało_istotne);
            Zadanie z2 = new Zadanie("20-02-2021", "24-02-2021", "Skonczyc budowe tabelki",
               "Zebrac wszystkie pliki z projektu i wrzucic w tabele", new List<Pracownik>(new Pracownik[] { p1, p3 }),
               new List<Uwaga>(), Enumy.WaznoscZadania.Istotne);
            Zadanie z3 = new Zadanie("20-02-2021", "24-03-2021", "Przygotowanie GUI aplikacji",
               "Naprawić struny, wymienić klawisze", new List<Pracownik>(new Pracownik[] { p1, p2, p4 }),
               new List<Uwaga>(), Enumy.WaznoscZadania.Krytycznie_ważne);

            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine(z3);

            Console.ReadKey();
        }
       
    }
}
