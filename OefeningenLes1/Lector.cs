using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening3
{
    class Lector
        : Persoon
    {
        public Lector(int personeelsnummer, string voornaam, string familienaam) : base(voornaam, familienaam)
        {
            this.Personeelsnummer = personeelsnummer;
        }

        public int Personeelsnummer { get; set; }

        public override string ToString()
        {
            return $"Lector: ({this.Personeelsnummer}) {base.ToString()}";
        }
    }
}
