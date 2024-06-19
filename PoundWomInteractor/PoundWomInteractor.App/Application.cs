using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WomDataInteractor.Model;
using WomDataInteractor.Services;

namespace PoundWomInteractor
{
    public class Application
    {
        private readonly IWiseOldManService WiseOldManService;
        public Clan? Clan { get; set; }
        public Application()
        {
            WiseOldManService = new WiseOldManService();
        }
        public async Task Test()
        {
            if (Clan is null)
            {
                Clan = await GetClan();
            }
            var me = Clan?.memberships?.Where(p => p.player.displayName == "iron aquaman").FirstOrDefault();
            Console.WriteLine(me.player.displayName);
            var player = await WiseOldManService.GetOsrsPlayer(me.player.displayName);
            Console.WriteLine(player.exp);
        }
        public async Task<IEnumerable<Membership>> GetPoundPlayersByEHP(double ehpValue)
        {
            if (Clan is null)
            {
                Clan = await GetClan();
            }
            var members = Clan.memberships.Where(p => p.player.ehp > ehpValue).ToList();
            return members;

        }
        public async Task<IEnumerable<Membership>> GetPoundPlayersByEhb(double ehbValue = 150)
        {
            if (Clan is null)
            {
                Clan = await GetClan();
            }
            var members = Clan.memberships.Where(p => p.player.ehb > ehbValue).ToList();
            return members;

        }
        private async Task<Clan> GetClan()
        {
            return await WiseOldManService.GetPoundRoster();
        }
    }
}
