using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WomDataInteractor.Model
{
    public class Clan
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public string? clanChat { get; set; }
        public string? description { get; set; }
        public int? homeworld { get; set; }
        public bool? verified { get; set; }
        public bool? patron { get; set; }
        public object? profileImage { get; set; }
        public object? bannerImage { get; set; }
        public int? score { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public List<Membership>? memberships { get; set; }
        public SocialLinks? socialLinks { get; set; }
        public List<RoleOrder>? roleOrders { get; set; }
        public int? memberCount { get; set; }
    }
    public class SocialLinks
    {
        public object? website { get; set; }
        public object? discord { get; set; }
        public object? twitter { get; set; }
        public object? youtube { get; set; }
        public object? twitch { get; set; }
    }
    public class Membership
    {
        public int? playerId { get; set; }
        public int? groupId { get; set; }
        public string? role { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public ClanMember? player { get; set; }
    }

    public class ClanMember
    {
        public int? id { get; set; }
        public string? username { get; set; }
        public string? displayName { get; set; }
        public string? type { get; set; }
        public string? build { get; set; }
        public string? status { get; set; }
        public string? country { get; set; }
        public bool? patron { get; set; }
        public int? exp { get; set; }
        public double? ehp { get; set; }
        public double? ehb { get; set; }
        public double? ttm { get; set; }
        public double? tt200m { get; set; }
        public DateTime? registeredAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public DateTime? lastChangedAt { get; set; }
        public DateTime? lastImportedAt { get; set; }
    }

    public class RoleOrder
    {
        public int? groupId { get; set; }
        public string? role { get; set; }
        public int? index { get; set; }
    }
}
