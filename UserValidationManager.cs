using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if ((gamer.Name == "Game" && gamer.Surname == "Boi" && gamer.TC == 12345 && gamer.DateOfBirth == 1987)
               || gamer.Name == "Tech" && gamer.Surname == "Girl"  && gamer.TC == 56789 && gamer.DateOfBirth == 1996)
            {
                return true;
            }
            else
                return false;
        }
    }
}
