﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePunkt
{
    class Punkt
    {

        public int X { get; private set; }// właściwość 1
        

        public int Y { get; private set; }// właściwość 2
       


        public Punkt(int wspx, int wspy) //konstruktor
        {
            X = wspx;
            Y = wspy;

        }

        public void Prawo(int ileP) //metoda 1
        {
            X += ileP;

        }

        public void Lewo(int ileL) //metoda 2
        {
            X -= ileL;

        }

        public void Gora(int ileG) //metoda 3
        {
            Y += ileG;

        }

        public void Dol(int ileD) //metoda 4
        {
            Y -= ileD;

        }


        public void Wyswietl()
        {

            Console.WriteLine("Współrzędna X: {0}",X);
            Console.WriteLine("Współrzędna Y: {0}",Y);
        }

        public static Punkt operator +(Punkt p1, Punkt p2) // nie jest to dodawanie fizyczne - jest to tylko definicja operatora "+" dla dodawania klas.
        {
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;

            Punkt result = new Punkt(x, y);
            //Punkt result = new Punkt(p1.X + p2.X, p1.Y + p2.Y); - inny sposób obliczenia
            return result;
        }

        public static Punkt operator -(Punkt p1, Punkt p2) // nie jest to dodawanie fizyczne - jest to tylko definicja operatora "+" dla dodawania klas.
        {
            int x = p1.X - p2.X;
            int y = p1.Y - p2.Y;

            Punkt result = new Punkt(x, y);
            
            return result;
        }

        public static Punkt operator *(Punkt p1, int p2)
        {
            int x = p1.X * p2;
            int y = p1.Y * p2;

            Punkt result = new Punkt(x,y);

            return result;
        }

        public static Punkt operator *(int m, Punkt p1)
        {
            
            return p1 * m; // operator przeciążony "*" jest wykorzystywany z deklaracji powyżej czyli wykonuje mnożenie zdefiniowane w "public static Punkt operator *(Punkt p1, int p2)"
        }

    }
}
