﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserService
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
