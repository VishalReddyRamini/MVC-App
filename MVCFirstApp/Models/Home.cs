﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstApp.Models
{
    public class Home
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }
    }
}