using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesService
    {
        void Sales(Games games, Gamer gamer, Campaign campaign);
    }
}
