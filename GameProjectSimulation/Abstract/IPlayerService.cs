using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    public interface IPlayerService
    {

        void SavePlayer(Players player);
        void UpdatePlayer(Players player);
        void DeletePlayer(Players player);
    }
}
