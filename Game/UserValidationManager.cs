using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1985 && gamer.FirtsName=="Engin" && gamer.LastName=="Demiroğ" && gamer.IdentityNumber==12345 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
