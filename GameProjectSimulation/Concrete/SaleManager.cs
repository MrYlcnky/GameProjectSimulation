using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    public class SaleManager : ISaleService
    {
        public void BuyGame(Sales sale,Players player)
        {
            Console.WriteLine("Oyun Id'si:"+ sale.SaleGameId+ "Oyuncu: "+ player.PlayerFirstName );
            player.PlayerGames.Add(sale);
        }

       
    }
}
