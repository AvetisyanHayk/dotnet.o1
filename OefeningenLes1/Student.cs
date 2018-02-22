using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening3
{
    class Student
        : Persoon
    {
        public Student(int studentennummer, string voornaam, string familienaam, string afstudeerrichting)
            : base(voornaam, familienaam)
        {
            this.Studentennummer = studentennummer;
            this.Afstudeerrichting = afstudeerrichting;
        }

        public int Studentennummer { get; set; }
        public string Afstudeerrichting { get; set; }

        public override string ToString()
        {
            return $"Student: ({this.Studentennummer}) {base.ToString()}, Afstudeerrichting: {this.Afstudeerrichting}";
        }
    }
}
