using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WomDataInteractor.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AbyssalSire
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Activities
    {
        public LeaguePoints league_points { get; set; }
        public BountyHunterHunter bounty_hunter_hunter { get; set; }
        public BountyHunterRogue bounty_hunter_rogue { get; set; }
        public ClueScrollsAll clue_scrolls_all { get; set; }
        public ClueScrollsBeginner clue_scrolls_beginner { get; set; }
        public ClueScrollsEasy clue_scrolls_easy { get; set; }
        public ClueScrollsMedium clue_scrolls_medium { get; set; }
        public ClueScrollsHard clue_scrolls_hard { get; set; }
        public ClueScrollsElite clue_scrolls_elite { get; set; }
        public ClueScrollsMaster clue_scrolls_master { get; set; }
        public LastManStanding last_man_standing { get; set; }
        public PvpArena pvp_arena { get; set; }
        public SoulWarsZeal soul_wars_zeal { get; set; }
        public GuardiansOfTheRift guardians_of_the_rift { get; set; }
        public ColosseumGlory colosseum_glory { get; set; }
    }

    public class Agility
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class AlchemicalHydra
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Artio
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Attack
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public int? ehp { get; set; }
    }

    public class BarrowsChests
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Bosses
    {
        public AbyssalSire abyssal_sire { get; set; }
        public AlchemicalHydra alchemical_hydra { get; set; }
        public Artio artio { get; set; }
        public BarrowsChests barrows_chests { get; set; }
        public Bryophyta bryophyta { get; set; }
        public Callisto callisto { get; set; }
        public Calvarion calvarion { get; set; }
        public Cerberus cerberus { get; set; }
        public ChambersOfXeric chambers_of_xeric { get; set; }
        public ChambersOfXericChallengeMode chambers_of_xeric_challenge_mode { get; set; }
        public ChaosElemental chaos_elemental { get; set; }
        public ChaosFanatic chaos_fanatic { get; set; }
        public CommanderZilyana commander_zilyana { get; set; }
        public CorporealBeast corporeal_beast { get; set; }
        public CrazyArchaeologist crazy_archaeologist { get; set; }
        public DagannothPrime dagannoth_prime { get; set; }
        public DagannothRex dagannoth_rex { get; set; }
        public DagannothSupreme dagannoth_supreme { get; set; }
        public DerangedArchaeologist deranged_archaeologist { get; set; }
        public DukeSucellus duke_sucellus { get; set; }
        public GeneralGraardor general_graardor { get; set; }
        public GiantMole giant_mole { get; set; }
        public GrotesqueGuardians grotesque_guardians { get; set; }
        public Hespori hespori { get; set; }
        public KalphiteQueen kalphite_queen { get; set; }
        public KingBlackDragon king_black_dragon { get; set; }
        public Kraken kraken { get; set; }
        public Kreearra kreearra { get; set; }
        public KrilTsutsaroth kril_tsutsaroth { get; set; }
        public LunarChests lunar_chests { get; set; }
        public Mimic mimic { get; set; }
        public Nex nex { get; set; }
        public Nightmare nightmare { get; set; }
        public PhosanisNightmare phosanis_nightmare { get; set; }
        public Obor obor { get; set; }
        public PhantomMuspah phantom_muspah { get; set; }
        public Sarachnis sarachnis { get; set; }
        public Scorpia scorpia { get; set; }
        public Scurrius scurrius { get; set; }
        public Skotizo skotizo { get; set; }
        public SolHeredit sol_heredit { get; set; }
        public Spindel spindel { get; set; }
        public Tempoross tempoross { get; set; }
        public TheGauntlet the_gauntlet { get; set; }
        public TheCorruptedGauntlet the_corrupted_gauntlet { get; set; }
        public TheLeviathan the_leviathan { get; set; }
        public TheWhisperer the_whisperer { get; set; }
        public TheatreOfBlood theatre_of_blood { get; set; }
        public TheatreOfBloodHardMode theatre_of_blood_hard_mode { get; set; }
        public ThermonuclearSmokeDevil thermonuclear_smoke_devil { get; set; }
        public TombsOfAmascut tombs_of_amascut { get; set; }
        public TombsOfAmascutExpert tombs_of_amascut_expert { get; set; }
        public TzkalZuk tzkal_zuk { get; set; }
        public TztokJad tztok_jad { get; set; }
        public Vardorvis vardorvis { get; set; }
        public Venenatis venenatis { get; set; }
        public Vetion vetion { get; set; }
        public Vorkath vorkath { get; set; }
        public Wintertodt wintertodt { get; set; }
        public Zalcano zalcano { get; set; }
        public Zulrah zulrah { get; set; }
    }

    public class BountyHunterHunter
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class BountyHunterRogue
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class Bryophyta
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Callisto
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Calvarion
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Cerberus
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class ChambersOfXeric
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class ChambersOfXericChallengeMode
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class ChaosElemental
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class ChaosFanatic
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class ClueScrollsAll
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class ClueScrollsBeginner
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class ClueScrollsEasy
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class ClueScrollsElite
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class ClueScrollsHard
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class ClueScrollsMaster
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class ClueScrollsMedium
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class ColosseumGlory
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class CommanderZilyana
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Computed
    {
        public Ehp ehp { get; set; }
        public Ehb ehb { get; set; }
    }

    public class Construction
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Cooking
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class CorporealBeast
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Crafting
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class CrazyArchaeologist
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class DagannothPrime
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class DagannothRex
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class DagannothSupreme
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Data
    {
        public Skills skills { get; set; }
        public Bosses bosses { get; set; }
        public Activities activities { get; set; }
        public Computed computed { get; set; }
    }

    public class Defence
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public int? ehp { get; set; }
    }

    public class DerangedArchaeologist
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class DukeSucellus
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Ehb
    {
        public string metric { get; set; }
        public double? value { get; set; }
        public int? rank { get; set; }
    }

    public class Ehp
    {
        public string metric { get; set; }
        public double? value { get; set; }
        public int? rank { get; set; }
    }

    public class Farming
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Firemaking
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Fishing
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Fletching
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class GeneralGraardor
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class GiantMole
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class GrotesqueGuardians
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class GuardiansOfTheRift
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class Herblore
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Hespori
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Hitpoints
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Hunter
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class KalphiteQueen
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class KingBlackDragon
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Kraken
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Kreearra
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class KrilTsutsaroth
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class LastManStanding
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class LatestSnapshot
    {
        public int? id { get; set; }
        public int? playerId { get; set; }
        public DateTime? createdAt { get; set; }
        public object importedAt { get; set; }
        public Data data { get; set; }
    }

    public class LeaguePoints
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class LunarChests
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Magic
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Mimic
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Mining
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Nex
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Nightmare
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Obor
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Overall
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class PhantomMuspah
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class PhosanisNightmare
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class Prayer
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class PvpArena
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class Ranged
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Player
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string displayName { get; set; }
        public string type { get; set; }
        public string build { get; set; }
        public string status { get; set; }
        public object country { get; set; }
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
        public LatestSnapshot latestSnapshot { get; set; }
        public int? combatLevel { get; set; }
        public object archive { get; set; }
    }

    public class Runecrafting
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Sarachnis
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Scorpia
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Scurrius
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Skills
    {
        public Overall overall { get; set; }
        public Attack attack { get; set; }
        public Defence defence { get; set; }
        public Strength strength { get; set; }
        public Hitpoints hitpoints { get; set; }
        public Ranged ranged { get; set; }
        public Prayer prayer { get; set; }
        public Magic magic { get; set; }
        public Cooking cooking { get; set; }
        public Woodcutting woodcutting { get; set; }
        public Fletching fletching { get; set; }
        public Fishing fishing { get; set; }
        public Firemaking firemaking { get; set; }
        public Crafting crafting { get; set; }
        public Smithing smithing { get; set; }
        public Mining mining { get; set; }
        public Herblore herblore { get; set; }
        public Agility agility { get; set; }
        public Thieving thieving { get; set; }
        public Slayer slayer { get; set; }
        public Farming farming { get; set; }
        public Runecrafting runecrafting { get; set; }
        public Hunter hunter { get; set; }
        public Construction construction { get; set; }
    }

    public class Skotizo
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Slayer
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Smithing
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class SolHeredit
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class SoulWarsZeal
    {
        public string metric { get; set; }
        public int? score { get; set; }
        public int? rank { get; set; }
    }

    public class Spindel
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Strength
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Tempoross
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class TheatreOfBlood
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class TheatreOfBloodHardMode
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class TheCorruptedGauntlet
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class TheGauntlet
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class TheLeviathan
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class ThermonuclearSmokeDevil
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class TheWhisperer
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Thieving
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class TombsOfAmascut
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class TombsOfAmascutExpert
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class TzkalZuk
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class TztokJad
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Vardorvis
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Venenatis
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Vetion
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Vorkath
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }

    public class Wintertodt
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class Woodcutting
    {
        public string metric { get; set; }
        public int? experience { get; set; }
        public int? rank { get; set; }
        public int? level { get; set; }
        public double? ehp { get; set; }
    }

    public class Zalcano
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public int? ehb { get; set; }
    }

    public class Zulrah
    {
        public string metric { get; set; }
        public int? kills { get; set; }
        public int? rank { get; set; }
        public double? ehb { get; set; }
    }


}
