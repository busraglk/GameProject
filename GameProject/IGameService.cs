using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        void Add(Games games);
        void Delete(Games games);
        void Update(Games games);
    }
}
