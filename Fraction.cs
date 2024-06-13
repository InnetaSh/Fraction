﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Создайте класс Fraction, который представляет собой дробное число и поддерживает основные операции над дробными числами. Класс должен содержать:
//Поля:
//int Numerator -числитель дроби.
//int Denominator - знаменатель дроби.
//Конструкторы:
//Конструктор без параметров, инициализирующий числитель и знаменатель нулями.
//Конструктор с параметрами для задания числителя и знаменателя. При этом, если знаменатель равен нулю, бросить исключение ArgumentException.
//Методы:




namespace Fraction
{
    internal class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не должен быть равен 0");
            }
            Denominator = denominator;
        }
        private int NCD()
        {
            if (Numerator == 0) return 1;
            while (Numerator != 0 && Denominator != 0)
            {
                if (Math.Abs(Numerator) > (Math.Abs(Denominator))
                        Numerator = (Math.Abs(Numerator) % (Math.Abs(Denominator);
                else
                    Denominator = Math.Abs(Denominator) % Math.Abs(Numerator);
            }
            return Math.Abs(Denominator + Numerator);

        }
        //Метод Simplify(), который упрощает дробь (например, дробь 4/8 упрощается до 1/2).
        public void Simplify()
        {
            int nsd = NCD();
            if (nsd > 0)
            {
                Numerator /= nsd;
                Denominator /= nsd;
            }
        }

        //Переопределите метод ToString(), чтобы он возвращал строковое представление дроби в формате "a/b".
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
        //Перегрузка операторов:
        //Перегрузите оператор + для сложения двух дробей.
        //Перегрузите оператор - для вычитания одной дроби из другой.

        public static Fraction operator +(Fraction c1, Fraction c2)
        {
            Fraction drib = new Fraction(c1.Numerator * c2.Denominator + c2.Numerator * c1.Denominator, c1.Denominator * c2.Denominator);
            
            return drib;
        }

        public static Fraction operator -(Fraction c1, Fraction c2)
        {
            Fraction drib = new Fraction(c1.Numerator * c2.Denominator - c2.Numerator * c1.Denominator, c1.Denominator * c2.Denominator);
            //Simplify();
            return drib;
        }


        //Перегрузите оператор * для умножения двух дробей.
        //Перегрузите оператор / для деления одной дроби на другую.

        public static Fraction operator *(Fraction c1, Fraction c2)
        {
            return  new Fraction(c1.Numerator * c2.Numerator , c1.Denominator * c2.Denominator);

        }

        public static Fraction operator /(Fraction c1, Fraction c2)
        {
            return new Fraction(c1.Numerator * c2.Denominator, c1.Denominator * c2.Numerator);
            //Simplify();
            
        }



        //Перегрузите оператор == для сравнения двух дробей.
        //Перегрузите оператор != для проверки на неравенство двух дробей.

        public static bool operator ==(Fraction c1, Fraction c2)
        {
            return (c1.Numerator == c2.Numerator && c1.Denominator == c2.Denominator);
        }

        public static bool operator !=(Fraction c1, Fraction c2)
        {
            return !(c1 == c2);
        }

    }
}
