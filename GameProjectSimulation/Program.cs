using GameProjectSimulation.Abstract;
using GameProjectSimulation.Adapter;
using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;
using System.Collections;

namespace GameProjectSimulation
{
    public class Program
    {

        static void Main(string[] args)
        {

            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            Players player = new Players();

            Campaigns campaign = new Campaigns();
            CampaignManager campaignManager = new CampaignManager();

            Sales sales = new Sales();

            Sales sales1 = new Sales();
            sales1.SaleGameId = 1;
            sales1.SaleGameName = "Cs Go";
            sales1.SaleGamePrice = 10.2;

            Sales sales2 = new Sales();
            sales2.SaleGameId = 2;
            sales2.SaleGameName = "LOL";
            sales2.SaleGamePrice = 15.2;

            Sales sales3 = new Sales();
            sales3.SaleGameId = 3;
            sales3.SaleGameName = "Pubg";
            sales3.SaleGamePrice = 12.2;
            SaleManager saleManager = new SaleManager();


            bool x = true;


            while (x)
            {

                Console.WriteLine("Oyuncu Kayıt => 1 \n" + "Oyuncu Kayıt Sil => 2\n" + "Oyuncu Şifre Güncelle => 3\n" + "Yeni Kampanya Oluştur => 4\n" +
                    "Kampanya Sil => 5\n" + "Kampanya ücreti Güncelleme => 6\n" + "Oyun Satın Alma => 7\n" + "Çıkış => 0\n");
                int secilenIslem = int.Parse(Console.ReadLine());

                if (secilenIslem == 1)
                {
                    player.PlayerId = playerManager.PlayerDataList.Count + 1;
                    Console.WriteLine("Name: ");
                    player.PlayerFirstName = Console.ReadLine();
                    Console.WriteLine("Surname: ");
                    player.PlayerLastName = Console.ReadLine();
                    Console.WriteLine("TCNO: ");
                    player.PlayerTcNo = Console.ReadLine();
                    Console.WriteLine("Doğum Tarihi: ");
                    player.PlayerDateOfBirth = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Kullanıcı Adı: ");
                    player.KullanıcıAdı = Console.ReadLine();
                    Console.WriteLine("Şifre: ");
                    player.Sifre = Console.ReadLine();

                    playerManager.SavePlayer(player);
                }
                else if (secilenIslem == 2)
                {
                    int deleteIdPlayer;
                    Console.WriteLine("Silmek istediğiniz oyuncunun Id'sini Giriniz: ");
                    deleteIdPlayer = int.Parse(Console.ReadLine());
                    foreach (Players p in playerManager.PlayerDataList)
                    {
                        if (deleteIdPlayer.Equals(player.PlayerId))
                        {
                            playerManager.DeletePlayer(player);
                        }
                        else
                        {
                            Console.WriteLine("Kayıt Bulunamadı");
                        }
                    }
                }
                else if (secilenIslem == 3)
                {
                    int updateIdPlayer;
                    Console.WriteLine("Şifrenizi güncellemek için TCNo Giriniz: ");
                    updateIdPlayer = int.Parse(Console.ReadLine());
                    foreach (Players p in playerManager.PlayerDataList)
                    {
                        if (updateIdPlayer.Equals(player.PlayerTcNo))
                        {
                            playerManager.UpdatePlayer(player);
                        }
                        else
                        {
                            Console.WriteLine("Kayıt Bulunamadı");
                        }
                    }

                }
                else if (secilenIslem == 4)
                {
                    campaign.CampaignId = campaignManager.CampaignList.Count + 1;
                    Console.WriteLine("Uygulucanız kampanyanın adını oluşturunuz: ");
                    campaign.CampaignName = Console.ReadLine();
                    Console.WriteLine("Kampanya indiriminde uygulanacak tutarı giriniz: ");
                    campaign.CampaingDiscountPrice = double.Parse(Console.ReadLine());
                    campaignManager.NewCampaign(campaign);
                }
                else if (secilenIslem == 5)
                {
                    int deleteIdCampaign;
                    Console.WriteLine("Kaldırmak istediğiniz kampanya Id'sini giriniz: ");
                    deleteIdCampaign = int.Parse(Console.ReadLine());
                    foreach (Campaigns cam in campaignManager.CampaignList)
                    {
                        if (deleteIdCampaign.Equals(campaign.CampaignId))
                        {
                            campaignManager.DeleteCampaign(cam);
                        }
                        else
                        {
                            Console.WriteLine("Kampanya Bulunamadı");
                        }

                    }
                }
                else if (secilenIslem == 6)
                {
                    int updateIdCampaign;
                    Console.WriteLine("Kampanya ücretini güncellemek istediğiniz kampanya Id'sini giriniz: ");
                    updateIdCampaign = int.Parse(Console.ReadLine());
                    foreach (Campaigns cam in campaignManager.CampaignList)
                    {
                        if (updateIdCampaign.Equals(campaign.CampaignId))
                        {
                            campaignManager.UpdateCampaign(cam);
                        }
                        else
                        {
                            Console.WriteLine("Kampanya Bulunamadı");
                        }

                    }
                }
                else if (secilenIslem == 7)
                {
                    int saleId;
                    Console.WriteLine("Oyun Adı ve Id :" + sales1.SaleGameName + " " + sales1.SaleGameId + "\n" + "Oyun Adı ve Id :" + sales2.SaleGameName + " " + sales2.SaleGameId + "\n" + "Oyun Adı ve Id :" + sales3.SaleGameName + " " + sales3.SaleGameId + "\n");
                    
                    Console.WriteLine("Almak istediğiniz oyun Id'sini giriniz: ");
                    saleId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Kampanyanız varsa Kampanya Id'si giriniz yoksa 0 tuşlayınız!!");
                   int campaignId1 = int.Parse(Console.ReadLine());
                    double indirim=0;
                    foreach (Campaigns camp in campaignManager.CampaignList)
                    {
                        if (campaignId1.Equals(campaign.CampaignId)) 
                        {
                             indirim = campaign.CampaingDiscountPrice;                       
                        }
                    }
                    if (saleId==1 )
                    {
                        Console.WriteLine("Oyuncu Id'nizi Giriniz: ");
                        int oyuncuId = int.Parse(Console.ReadLine());
                        foreach (Players pla in playerManager.PlayerDataList)
                        {
                            if (oyuncuId.Equals(player.PlayerId))
                            {
                                sales1.SaleGamePrice -= indirim;
                                saleManager.BuyGame(sales1,player);  
                            }
                            else
                            {
                                Console.WriteLine("Kayıt Bulunamadı");
                            }
                        }
                    }
                    else if(saleId==2) 
                    {
                        Console.WriteLine("Oyuncu Id'nizi Giriniz: ");
                        int oyuncuId = int.Parse(Console.ReadLine());
                        foreach (Players pla in playerManager.PlayerDataList)
                        {
                            if (oyuncuId.Equals(player.PlayerId))
                            {
                                sales2.SaleGamePrice -= indirim;
                                saleManager.BuyGame(sales2, player);
                            }
                            else
                            {
                                Console.WriteLine("Kayıt Bulunamadı");
                            }
                        }
                    }
                    else if (saleId == 3)
                    {
                        Console.WriteLine("Oyuncu Id'nizi Giriniz: ");
                        int oyuncuId = int.Parse(Console.ReadLine());
                        foreach (Players pla in playerManager.PlayerDataList)
                        {
                            if (oyuncuId.Equals(player.PlayerId))
                            {
                                sales3.SaleGamePrice -= indirim;
                                saleManager.BuyGame(sales3, player);
                            }
                            else
                            {
                                Console.WriteLine("Kayıt Bulunamadı");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kayıtlarda Oyun Yok!!!");
                    }
                }
                else if (secilenIslem == 0)
                {
                    //çıkış
                    x = false;
                }
                else
                {
                    Console.WriteLine(" Geçerli Bir işlem Numarası Giriniz!!! ");
                }
            }
        }
    }
}