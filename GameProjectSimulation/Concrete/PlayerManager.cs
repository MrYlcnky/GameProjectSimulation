using GameProjectSimulation.Abstract;
using GameProjectSimulation.Adapter;
using GameProjectSimulation.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        public ArrayList PlayerDataList = new ArrayList();

        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public PlayerManager()
        {

        }

        public override void SavePlayer(Players player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                PlayerDataList.Add(player);
                foreach (Players players in PlayerDataList)
                {
                    Console.WriteLine("Save Player First Name and Last Name :" + players.PlayerFirstName + " " + players.PlayerLastName);
                }
            }
            else { throw new Exception("Kullanıcı Bilgileri Yanlış"); }
        }


        public void DeletePlayer(Players player)
        {
            Console.WriteLine("Delete Player Name and Last Name: " + player.PlayerFirstName + " " + player.PlayerLastName);
            PlayerDataList.Remove(player.PlayerId);
        }



        public void UpdatePlayer(Players player)
        {
            Console.WriteLine("Yeni Şifrenizi Giriniz: ");
            player.Sifre = Console.ReadLine();

        }
    }
}
