using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // bir Manager sınıfının içerisinde başka bir Manager sınıfını kullanacak isek asla onu newlemeyiz. Onun yerine constructor oluştururuz.( IUserValidationService _userValidationService;) Daha sonra soldan çıkan ampulden Generate Constructor deriz. Bu şu demek GamerManager'ın aslında şu anda bir bağımlılığı var. GamerManager içersinde ben bir doğrulama servisini kullancağım demiş oluruz.
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Edildi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt Yapılamadı!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
