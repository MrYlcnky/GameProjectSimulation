using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    public interface ISaleService
    {
        void BuyGame(Sales sale,Players player);
      
    }
}
