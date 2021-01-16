﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    [Serializable]
    public class Sponsor : Uzytkownik
    {
        public override string ToString()
        {
            return base.ToString()+ " SPONSOR";
        }
        public Sponsor()
        {

        }
        public Sponsor(string imie, string nazwisko, string dataUrodzenia, string pesel, string email) : base(imie, nazwisko, dataUrodzenia, pesel, email)
        {

        }

    }
}
