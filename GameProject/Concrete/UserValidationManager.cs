using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationService : IUserValidationService
    {

        public bool Validate(Gamer gamer)
        {
            if (gamer.FristName == "Ayşenur" && gamer.LastName == "Elmas" && gamer.NationalityId == "12345678909" && gamer.BirthYear == 2000) 
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
