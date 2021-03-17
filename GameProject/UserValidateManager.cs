using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidateManager:IUserValidateService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "RIDVAN" && gamer.LastName == "BOZKIR" && gamer.BirthDay == 1991 && gamer.IdentityNumber ==123456789)
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
