using System;

namespace GamerProject
{
    public class GamerManager :IGamerService
    {
        readonly IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("kayıt olundu");
            }
            else
            {
                Console.WriteLine("doğrulama başarısız. kayıt olunamadı!");
            }
                
        }

        public void Update(Gamer gamer)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Gamer gamer)
        {
            throw new System.NotImplementedException();
        }
    }
}