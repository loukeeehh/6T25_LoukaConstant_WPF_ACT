﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6T25_LoukaConstant_ACT3
{
    class methodesDuProjet
    {
        public void ResoudTrinome(double a, double b, double c, out string message)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c; //discriminant
            if (delta < 0)
            {
                message = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                double x1 = -b / (2 * a);
                message = "Il y a une solution " + x1;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                message = "Il y a deux solutions " + x1 + " et " + x2;
            }
        }
    }
}
