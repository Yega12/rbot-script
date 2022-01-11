using RBot;

public class Script {

	public void ScriptMain(ScriptInterface bot){
		bot.Options.SafeTimings = true;
		bot.Options.RestPackets = true;
        	bot.Options.InfiniteRange = true;
        	bot.Options.PrivateRooms = true;
        	bot.Options.LagKiller = true;
	
		bot.Skills.StartTimer();
		
		bot.Player.LoadBank();
		bot.Bank.ToInventory("Sapphire Orb");
		bot.Bank.ToInventory("Rumors of the Celestial Commander");
		bot.Bank.ToInventory("Starlit Journal Page 1 Scraps");
		bot.Bank.ToInventory("Starlit Journal Page 2 Scraps");
		bot.Bank.ToInventory("Starlit Journal Page 3 Scraps");
		bot.Bank.ToInventory("Starlit Journal Page 4 Scraps");
		bot.Bank.ToInventory("Map of the Celestial Seas");
		bot.Bank.ToInventory("Coffer of the Stars");
		
		while(!bot.ShouldExit()){
			bot.Quests.EnsureAccept(7713);
			
			bot.Player.Join("frozenlair");
			bot.Player.HuntForItem("Legion Lich Lord", "Sapphire Orb", 5);
			
			bot.Player.Join("lostruinswar");
			bot.Player.HuntForItem("Diabolical Warlord", "Rumors of the Celestial Commander", 5);
			
			bot.Player.Join("iceplane");
			bot.Player.HuntForItem("Animus of Ice", "Starlit Journal Page 1 Scraps", 10);
			
			bot.Player.Join("ivoliss");
			bot.Player.HuntForItem("Ivoliss", "Starlit Journal Page 2 Scraps", 10);
			
			bot.Player.Join("thevoid");
			bot.Player.HuntForItem("Nightbane", "Starlit Journal Page 3 Scraps", 10);
			
			bot.Player.Join("extinction");
			bot.Player.HuntForItem("Ultra SN.O.W", "Starlit Journal Page 4 Scraps", 10);
			
			bot.Player.Join("starsinc");
			bot.Player.HuntForItem("Empowered Prime", "Map of the Celestial Seas", 1);
			
			bot.Player.Join("underlair");
			bot.Player.HuntForItem("Archfiend Dragonlord", "Coffer of the Stars", 1);
			
			bot.Player.Pickup(Bot.Drops.Pickup.ToArray());

			bot.Quests.EnsureCompleteChoose(7713, new[] { 
				"Celestial Pirate Commander", 
				"Celestial Commander's Hat", 
				"Celestial Commander's Locks", 
				"Celestial Commander's Locks + Hat", 
				"Celestial Commander's Wings", 
				"Celestial Commander's Back Blade", 
				"Celestial Commander's Wings+ Blade", 
				"Celestial Commander's Sword", 
				"Celestial Commander's Hat + Morph", 
				"Celestial Commander's Morph + Locks", 
				"Celestial Commander's Plank", 
				"Polly Roger" 
			});
		}
	}
}
