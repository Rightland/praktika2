﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    class mathOperation
    {
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double Minus(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return Multy.MultiplicationTWO(a, b);
        }
        public double Plusik(double a, double b)
        {
            return a + b;
        }
        public double Rem(double a, double b)
        {
            return a % b;
        }
        public double Sin(double a)
        {
            return Math.Sin(a);
        }
        public double Average(double a,double b)
        {
            return (a + b) / 2;
        }
        public double square(double a)
        {
            return a * a ;
        }
    }
}