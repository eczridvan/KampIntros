using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerService
    {
         IUserValidateService _userValidateService;

         public GamerManager(IUserValidateService userValidateService)
         {
             _userValidateService = userValidateService;
         }

         public void Add(Gamer gamer)
        {
            if (_userValidateService.Validate(gamer))
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Bilgiler hatalı");
            }
            
        }

        public void Update(Gamer gamer)
        {
            if (_userValidateService.Validate(gamer))
            {
                Console.WriteLine("Bilgiler güncellendi");
            }

            else
            {
                Console.WriteLine("Bilgiler güncellenemedi.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidateService.Validate(gamer))
            {
                Console.WriteLine("Bilgiler silindi");
            }
            else
            {
                Console.WriteLine("Bilgiler silinemedi.");
            }
        }
    }
}
