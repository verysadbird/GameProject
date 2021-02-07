using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class AccountManager
    {
        IUserValidationService _userValidation;


        public AccountManager(IUserValidationService userValidation)
        {
            _userValidation = userValidation;
        }


        public void Add (Gamer gamer) { 
        
                if(_userValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt başarılı");
            }else
                Console.WriteLine("Kayıt başarısız");
        
        
        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }


        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }







    }
}
