﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_u_danu
{
    internal class Sensor
    {
        public Sensor() { }
        public string GetData()
        {
            string vrijednosti = "5,5; 5; 4,5; 4; 3,5; 3; 4; 5; 6; 7; 8; 9; 10,5; 11; 11,5; 11,5; 11,5; 10,5; 10; 8; 7; 6,5; 6; 5,5";
            return vrijednosti;
        } 
    }
}
