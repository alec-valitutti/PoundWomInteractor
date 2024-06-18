using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WomDataInteractor.Model;

namespace WomDataInteractor.Services
{
    public interface IWiseOldManService
    {
        Task<Clan> GetPoundRoster();
        Task<Player> GetOsrsPlayer(string name);
    }

    public class WiseOldManService : IWiseOldManService
    {
        public HttpRequestHelper Request { get; set; } = new HttpRequestHelper();
        public async Task<Clan?> GetPoundRoster()
        {
            return await Request.MakeGetRequestAsync<Clan>("groups/3576");
        }
        public async Task<Player?>GetOsrsPlayer(string name)
        {
            var targetPlayer = name.ToLower();
            return await Request.MakeGetRequestAsync<Player>($"players/{targetPlayer}");
        }

    }
}
