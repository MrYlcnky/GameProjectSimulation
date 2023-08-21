using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void DeletePlayer(Players player)
        {
            
        }

        public virtual void SavePlayer(Players player)
        {

        }

        public virtual void UpdatePlayer(Players player)
        {
           
        }
    }
}
