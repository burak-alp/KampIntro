using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        private UserValidationManager userValidationManager;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public GamerManager(UserValidationManager userValidationManager)
        {
            this.userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                    Console.WriteLine("Kayıt olunamadı");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
