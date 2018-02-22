using Oefening3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening4
{
    class Hogeschool
    {
        public Hogeschool()
        {
            this.Klasgroepen = new List<Klasgroep>();
        }

        public List<Klasgroep> Klasgroepen { get; set; }

        public void AddKlasgroep(Klasgroep klas)
        {
            this.Klasgroepen.Add(klas);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Klasgroep klas in this.Klasgroepen)
            {
                sb.Append("Klasgroep:").Append(Environment.NewLine)
                    .Append(klas.ToString()).Append(Environment.NewLine);
            }
            return sb.ToString();
        }

    }
}
