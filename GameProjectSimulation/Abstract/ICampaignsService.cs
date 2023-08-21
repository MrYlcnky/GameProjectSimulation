using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    public interface ICampaignsService
    {
        void NewCampaign(Campaigns campaigns);
        void DeleteCampaign(Campaigns campaigns);
        void UpdateCampaign(Campaigns campaigns);
    }
}
