using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Entities
{
    public class Players
    {
        public int PlayerId { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public string PlayerTcNo { get; set; }
        public DateTime PlayerDateOfBirth { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Sifre { get; set; } 
        public ArrayList? PlayerGames { get; set; }
    }
}
