using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening5
{
    class Vierkantsvergelijking
    {
        public Vierkantsvergelijking(float a, float b, float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public float GetDiscriminant()
        {
            return B * B - 4 * A * C;
        }

        public float BerekenWortel1()
        {
            return (float)((-B + Math.Sqrt(GetDiscriminant())) / (2 * A));
        }

        public float BerekenWortel2()
        {
            return (float)((-B - Math.Sqrt(GetDiscriminant())) / (2 * A));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(A).Append("x²");
            if (B > 0)
            {
                sb.Append("+");
            }
            sb.Append(B).Append("x");
            if (C > 0)
            {
                sb.Append("+");
            }
            sb.Append(C).Append("=0").Append(Environment.NewLine)
                .Append($"Discriminant: {GetDiscriminant()}").Append(Environment.NewLine)
                .Append($"Wortel1: {BerekenWortel1()}").Append(Environment.NewLine)
                .Append($"Wortel2: {BerekenWortel2()}"); ;
            return sb.ToString();
        }
    }
}
