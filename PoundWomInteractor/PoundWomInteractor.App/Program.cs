﻿using PoundWomInteractor;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Application application = new Application();

        await application.Test();
        var clanMembers = await application.GetPoundPlayersByEHP(2000);

        foreach (var member in clanMembers)
        {
            Console.WriteLine(member.player.displayName);
        }
    }
}