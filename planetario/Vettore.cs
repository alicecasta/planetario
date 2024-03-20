using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetario
{
    internal class Vettore
    {
        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vettore()
        {
        }

        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString()
        {
            return string.Format("{0}; {1}", X, Y);
        }
        public static Vettore Parse(string s)
        {
            var l = s.Split(';');
            return new Vettore(int.Parse(l[0]), int.Parse(l[1]));
        }

        

        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            Vettore v = new Vettore(v1.X + v2.X, v1.Y + v2.Y);
            return v;
        }
        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);

        }
        public static Vettore operator *(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X * v2.X, v1.Y * v2.Y);
        }
        public static Vettore operator *(Vettore v, double s)
        {
            return new Vettore(v.X * s, v.Y * s);
        }

        public static Vettore operator /(Vettore v, double s)
        {
            return new Vettore(v.X / s, v.Y / s);
        }
        public static Vettore operator +(Vettore v)
        {
            return v;
        }
        public static Vettore operator -(Vettore v)
        {
            return new Vettore(-v.X, -v.Y);

        }
        public static bool operator !=(Vettore v1, Vettore v2)
        {
            return !(v1 == v2);
        }
        public static bool operator ==(Vettore v1, Vettore v2)
        {
            if (object.ReferenceEquals(v1, null))
                return object.ReferenceEquals(v2, null);
            else if (object.ReferenceEquals(v2, null))
                return false;
            else
                return v1.X == v2.X && v1.Y == v2.Y;
        }
        public double modulo()
        {
            return Math.Sqrt((X * X) + (Y * Y));
        }
        public static double distanza(Vettore v1, Vettore v2)
        {
            return Math.Sqrt(Math.Pow((v1.X - v2.X), 2) + Math.Pow((v1.Y - v2.Y), 2));
        }
        public Vettore versore()
        {
            double m = this.modulo();
            return new Vettore(X / m, Y / m);
        }
    }
}
