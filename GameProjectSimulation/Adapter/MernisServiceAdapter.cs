using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference;

namespace GameProjectSimulation.Adapter
{
    public class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Players player)
        {
           KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrula(Convert.ToInt64(player.PlayerTcNo),
                player.PlayerFirstName.ToUpper(), player.PlayerLastName.ToUpper(), player.PlayerDateOfBirth.Year);
        }
    }
}
