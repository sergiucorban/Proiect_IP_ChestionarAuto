﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_IP_ChestionarAuto
{
    internal class RandGenerator
    {
        public static List<int> ExtragereNumereRandom(int max, int total)
        {
            var rnd = new Random();
            var nrlist = new List<int>();

            for (var i = 0; i < total; i++)
            {
                var temp = 0;
                temp = rnd.Next(1, max + 1);

                while (nrlist.Contains(temp))
                {
                    temp = rnd.Next(1, max + 1);
                }

                nrlist.Add(temp);
            }

            return nrlist;
        }
    }
}
