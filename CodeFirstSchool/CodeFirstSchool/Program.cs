﻿using CodeFirstSchool.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolContext();
            context.Database.EnsureCreated();
        }
    }
}
