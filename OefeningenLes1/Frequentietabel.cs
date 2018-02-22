using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening6
{
    class Frequentietabel
    {
        public Dictionary<string, int> Tabel { get; }

        public Frequentietabel()
        {
            this.Tabel = new Dictionary<string, int>();
        }

        public void Add(string value)
        {
            foreach (string val in value.Split(" "))
            {
                string woord = val.Trim();
                if (!string.Equals(woord, ""))
                {
                    if (this.Tabel.ContainsKey(woord))
                    {
                        this.Tabel[woord]++;
                    }
                    else
                    {
                        this.Tabel.Add(woord, 1);
                    }
                }
            }
        }

        public int Get(string key)
        {
            return this.Tabel[key];
        }
    }
}
