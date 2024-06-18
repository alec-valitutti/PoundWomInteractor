using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WomDataInteractor.Services;

namespace PoundWomInteractor
{
    public class Application
    {
        public async Task Test()
        {
            IWiseOldManService n = new WiseOldManService();
            var clan = await n.GetPoundRoster();
            var me = clan?.memberships?.Where(p => p.player.displayName == "iron aquaman").FirstOrDefault();
            Console.WriteLine(me.player.displayName);
            var player = await n.GetOsrsPlayer(me.player.displayName);
            Console.WriteLine(player.exp);
        }
    }
}
