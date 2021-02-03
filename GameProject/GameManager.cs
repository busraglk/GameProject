using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.GameName + " " + "oyunu eklendi.");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.GameName + " " + "oyunu silindi.");
        }

        public void Update(Games games)
        {
            Console.WriteLine(games.GameName + " " + "oyunu güncellendi.");
        }
    }
}
