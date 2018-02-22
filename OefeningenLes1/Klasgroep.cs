using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening3
{
    class Klasgroep
    {
        public Klasgroep(Lector lector)
        {
            this.Lector = lector;
            this.Studenten = new List<Student>();
        }

        public Lector Lector { get; set; }
        public List<Student> Studenten { get; set; }

        public void AddStudent(Student student)
        {
            this.Studenten.Add(student);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Lector.ToString()).Append(Environment.NewLine);
            foreach (Student student in this.Studenten)
            {
                sb.Append(student.ToString()).Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
