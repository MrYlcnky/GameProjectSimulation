using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    public class CampaignManager : ICampaignsService
    {
        public ArrayList CampaignList=new ArrayList();
        public void NewCampaign(Campaigns campaign)
        {
            CampaignList.Add(campaign);
            foreach (Campaigns cam in CampaignList)
            {
                Console.WriteLine("Eklenen kampanya Adı, Id, ve indirim tutarı : "+cam.CampaignName+cam.CampaignId+cam.CampaingDiscountPrice);
            }
        }

        public void DeleteCampaign(Campaigns campaigns)
        {
            Console.WriteLine("Silinen kampanya Adı ve Id'si"+ campaigns.CampaignName + campaigns.CampaignId);
            CampaignList.Remove(campaigns);
        }

        public void UpdateCampaign(Campaigns campaigns)
        {
            Console.WriteLine("Yeni kampanta tutarını giriniz: ");
            campaigns.CampaingDiscountPrice=double.Parse(Console.ReadLine());

        }
    }
}
