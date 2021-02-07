using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer : IUserService
    {
        public int ID { get; set; }
        public long TC { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DateOfBirth { get; set; }

      

        

    }
}
