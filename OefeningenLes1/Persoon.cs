using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening3
{
    class Persoon
    {
        public Persoon(string voornaam, string familienaam)
        {
            this.Voornaam = voornaam;
            this.Familienaam = familienaam;
        }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public override string ToString()
        {
            return $"{this.Voornaam} {this.Familienaam}";
        }
    }
}
