
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using OverToolGUI.Model;

namespace OverToolGUI.ViewModel
{
    public class SkinViewModel : INotifyPropertyChanged
    {
        private readonly CollectionViewSource CharacterSkinsCollection;
        public ICollectionView SkinSourceCollection => CharacterSkinsCollection.View;

        public SkinViewModel(string character)
        {
            switch (character)
            {
                case "Ana":
                    ObservableCollection<CharacterSkins> anaSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Citrine", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Garnet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Peridot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Turquoise", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Merciful", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Shrike", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cybermedic", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ghoul", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gingerbread", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bastet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Midnight Camo", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wadjet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wasteland", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Captain Amari", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Horus", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sniper", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Night Owl", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cabana", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Corsair", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mummy", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Snow Owl", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Botanist", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Haoeris", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },
                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = anaSkins };
                    break;
                case "Ashe":
                    ObservableCollection<CharacterSkins> asheSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Paintbrush", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sunflower", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tansy", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Yucca", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Posh", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Thorn", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Prosperity", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Winter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mardi Gras", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Deadlock", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Merry Outlaw", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gangster", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mobster", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jungle", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Safari", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tiger Huntress", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Socialite", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Little Red", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Poolside", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Warlock", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Raijin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = asheSkins };
                    break;
                case "Baptiste":
                    ObservableCollection<CharacterSkins> bapSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ble", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vyolet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wouj", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Camouflage", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wasteland", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Terracotta Medic", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vampire", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Combat Medic", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Deluxe", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blue Steel", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Desert Ops", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Spec Ops", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Buccaneer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pirate", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Talon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Funky", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Arctic Ops", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tropical", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Snowboarder", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = bapSkins };
                    break;
                case "Bastion":
                    ObservableCollection<CharacterSkins> bastSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dawn", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Meadow", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sky", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Soot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Defense Matrix", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Omnic Crisis", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rooster", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Null Sector", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sand Castle", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tombstone", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gift Wrap", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blizzcon 2016", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Antique", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Woodbot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gearbot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Steambot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gwishin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dune Buggy", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Stealth", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Coffin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Avalanche", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overgrown", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Brick", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gingerbread", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pirate Ship", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = bastSkins };
                    break;
                case "Brigitte":
                    ObservableCollection<CharacterSkins> BrigSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bla", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gron", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Plommon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rod", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ironclad", SkinImage = @"" },
                        new CharacterSkins { SkinName = "General", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tre Kronor", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Stone", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ice Queen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Peppermint Bark", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pearlescent", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mani", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sol", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Engineer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mechanic", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Opera", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Shieldmaiden", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Riot Police", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Feskarn", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vampire Hunter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Medic", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Goat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = BrigSkins };
                    break;
                case "Cassidy":
                    ObservableCollection<CharacterSkins> CassSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ebony", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lake", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sage", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wheat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "On the Range", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Royal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "White Hat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Xiake", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Masked Man", SkinImage = @"" },
                        new CharacterSkins { SkinName = "American", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Undead", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Scrooge", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch League Gray", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sandstorm", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Forest Ranger", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gambler", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Riverboat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mystery Man", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vigilante", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Magistrate", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blackwatch", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Deadlock", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sherlock", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lifeguard", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Van Helsing", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mountain Man", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Invisible Man", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Space Ranger", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = CassSkins };
                    break;
                case "Doomfist":
                    ObservableCollection<CharacterSkins> doomSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Daisy", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lake", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Plains", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sunset", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Leopard", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Painted", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Monk", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "General", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Kiniun", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Avatar", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Spirit", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Caution", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Irin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blackhand", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Talon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Formal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gladiator", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Karate", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Swamp Monster", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jotunn", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Saitama", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Thunder", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },
                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = doomSkins };
                    break;
                case "Dva":
                    ObservableCollection<CharacterSkins> dvaSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blueberry", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lemon-Lime", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tangerine", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Watermelon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "White Rabbit", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Midnight", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Taegeukgi", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nano", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch League Gray", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Junker", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Scavenger", SkinImage = @"" },
                        new CharacterSkins { SkinName = "B.Va", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Junebug", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Black Cat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Police Officer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Palanquin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cruiser", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Academy", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Varsity", SkinImage = @"" },
                        new CharacterSkins { SkinName = "White Cat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Waveracer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Shin-Ryeong", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sleighing", SkinImage = @"" },
                        new CharacterSkins { SkinName = "EDM", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Turtle Ship", SkinImage = @"" },
                        new CharacterSkins { SkinName = "2020 Pacific All-Stars", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = dvaSkins };
                    break;
                case "Echo":
                    ObservableCollection<CharacterSkins> echoSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Durian", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Marina", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Papaya", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vanda", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hot Rod", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bird of Paradise", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ragdoll", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Camo", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Stealth", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Butterfly", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Moth", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Kkachi", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vampire Bat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Surf's Up", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ice Angel", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Good and Evil", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = echoSkins };
                    break;
                case "Genji":
                    ObservableCollection<CharacterSkins> genjiSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Azurite", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Malachite", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ochre", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Chrome", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nihon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch League Gray", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sparrow", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Young Genji", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bedouin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nomad", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Oni", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Baihu", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blackwatch", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sentai", SkinImage = @"" },
                        new CharacterSkins { SkinName = "2018 Pacific All-Stars", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyber Demon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = genjiSkins };
                    break;
                case "Hanzo":
                    ObservableCollection<CharacterSkins> hanzoSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Azuki", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Kinoko", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Midori", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sora", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cloud", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dragon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nihon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Demon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch League Gray", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Kyogisha", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Kabuki", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Young Hanzo", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Young Master", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Okami", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyberninja", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dark Wolf", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Casual", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Scion", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Huang Zhong", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wave", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dai Tengu", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cupid", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = hanzoSkins };
                    break;
                case "Junker Queen":
                    ObservableCollection<CharacterSkins> jqSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Actinium", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Plutonium", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Radium", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Uranium", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Punker Queen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Beast Hunter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Circuit Breaker", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wastelander", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Executioner", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Black Metal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Zeus", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = jqSkins };
                    break;
                case "Junkrat":
                    ObservableCollection<CharacterSkins> jrSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bleached", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Drowned", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Irradiated", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rusted", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Firework", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Caution", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jailbird", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Toasted", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Fool", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jester", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hayseed", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Scarecrow", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cricket", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dr.Junkenstein", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Beachrat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bilgerat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Krampus", SkinImage = @"" },
                        new CharacterSkins { SkinName = "King Jamison", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = jrSkins };
                    break;
                case "Kiriko":
                    ObservableCollection<CharacterSkins> kirikoSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ajisai", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Fuji", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Take", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tanpopo", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Matsuri", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Visual Kei", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Athleisure", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sukajan", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Witch", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hinotori", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Amaterasu", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = kirikoSkins };
                    break;
                case "Lucio":
                    ObservableCollection<CharacterSkins> lucioSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Azul", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Laranja", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Roxo", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vermelho", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Auditiva", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Synaesthesia", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gorgon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Andes", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bitrate", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Disco", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Capoeira", SkinImage = @"" },
                        new CharacterSkins { SkinName = "HippityHop", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ribbit", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Breakaway", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Slapshot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Selecao", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Striker", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Satyr", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Snow Fox", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Equalizer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jazzy", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Poison Dart", SkinImage = @"" },
                        new CharacterSkins { SkinName = "2019 Pacific All-Stars", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hermes", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = lucioSkins };
                    break;
                case "Mei":
                    ObservableCollection<CharacterSkins> meiSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Chrysanthemum", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Heliotrope", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jade", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Persimmon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Earthen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Snow Plum", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bear", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Zhongguo", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pumpkin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Retro Star", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hu Tou Mao", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ecopoint: Antarctica", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Firefighter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rescue Mei", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Abominable", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Yeti Hunter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Chang'e", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Luna", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pajamei", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Beekeeper", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Honeydew", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sprinkles", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jiangshi", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mei-rry", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Penguin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Empress", SkinImage = @"" },
                        new CharacterSkins { SkinName = "MM-Mei", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = meiSkins };
                    break;
                case "Mercy":
                    ObservableCollection<CharacterSkins> mercySkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Celestial", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mist", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Orchid", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Verdant", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Amber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cobalt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Fortune", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Camouflage", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Eidgenossin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Snow Angel", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch League Gray", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Owl Guardian", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Honey Bee", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sigrun", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Valkyrie", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Devil", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Imp", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Zhuque", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Seolbim", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Combat Medic Ziegler", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dragoon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mage", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Winged Victory", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Witch", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sugar Plum Fairy", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pink", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dr.Ziegler", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Miko", SkinImage = @"" },
                        new CharacterSkins { SkinName = "2019 Atlantic All-Stars", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Royal Knight", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Royal Gladiator", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = mercySkins };
                    break;
                case "Moira":
                    ObservableCollection<CharacterSkins> moiraSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Fiery", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Royal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Selkie", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Whiskey", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ornate", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pale", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Eireannach", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Holly", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch League Gray", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Glam", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Moon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Minister", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Oasis", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mask Dancer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blackwatch", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Scientist", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Venus", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Banshee", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ice Empress", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Demon Queen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mime", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = moiraSkins };
                    break;
                case "Orisa":
                    ObservableCollection<CharacterSkins> orisaSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dawn", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Plains", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sunrise", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Twilight", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Camouflage", SkinImage = @"" },
                        new CharacterSkins { SkinName = "OR15", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sanye", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Immortal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dynastinae", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Megasoma", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Protector", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Referee", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Demon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Reindeer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Null Sector", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Forest Spirit", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bull Demon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Star Sheep", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = orisaSkins };
                    break;
                case "Pharah":
                    ObservableCollection<CharacterSkins> pharahSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Amethyst", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Copper", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Emerald", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Titanium", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Anubis", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jackal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Possessed", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Frostbite", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Punk", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Asp", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mechaqueen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Raptorion", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Raindancer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Thunderbird", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Qinglong", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Aviator", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bedouin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Orbital", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mechatron", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lifeguard", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sunset", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Enchanted Armor", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Security Chief", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sky Centurion", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hades", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = pharahSkins };
                    break;
                case "Ramattra":
                    ObservableCollection<CharacterSkins> ramSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Detachment", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Discipline", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Reverence", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wisdom", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Primordial", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Construction", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Travelling Monk", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wandering Monk", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Biohazard", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Poseidon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = ramSkins };
                    break;
                case "Reaper":
                    ObservableCollection<CharacterSkins> reaperSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blood", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Midnight", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Moss", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Royal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Desert", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wight", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hellfire", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Shiver", SkinImage = @"" },
                        new CharacterSkins { SkinName = "American", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Imperial Guard", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Atlanta Reign", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nevermore", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Plague Doctor", SkinImage = @"" },
                        new CharacterSkins { SkinName = "El Blanco", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mariachi", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Biker", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pumpkin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dracula", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blackwatch Reyes", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rat King", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Solider:24", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lu Bu", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Evermore", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Masquerade", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dusk", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = reaperSkins };
                    break;
                case "Reinhardt":
                    ObservableCollection<CharacterSkins> reinSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Brass", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cobalt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Copper", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Viridian", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bundeswehr", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Paragon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lieutenant Wilhelm", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Coldhardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Festive", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Prideful", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Crusader", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blackhardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bloodhardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lionhardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Stonehardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Balderich", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Greifhardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wujing", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Guan Yu", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gridironhardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Draugr", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Steelhardt", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Minotaur", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = reinSkins };
                    break;
                case "Roadhog":
                    ObservableCollection<CharacterSkins> roadSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Kiwi", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mud", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sand", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Thistle", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pigpen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Stitched", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rudolph", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Butcher", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Islander", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Toa", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mako", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sharkbait", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bajie", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Junkenstein's Monster", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ice Fisherman", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lacrosse", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Noxious", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Toxic", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Militia", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyberhog", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyclops", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Midas", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = roadSkins };
                    break;
                case "Soldier76":
                    ObservableCollection<CharacterSkins> soldierSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Olive", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Russet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Smoke", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bone", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Golden", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Immortal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Venom", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch League Gray", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Commando: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Night Ops: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Daredevil: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Stunt Rider: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyborg: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Grillmaster: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Alpine: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Slasher: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bug Hero", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mumen Rider", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Formal: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Soldier: 1776", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Proteus: 76", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Space Raider", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Strike Commander Morrison", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = soldierSkins };
                    break;
                case "Sombra":
                    ObservableCollection<CharacterSkins> sombraSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Noche", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Incendio", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cidro", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Oro", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Peppermint", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mexicana", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Virus", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Glitch", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Aztec", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Neon Cat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Black Cat", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Talon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Face Changer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rime", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bride", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tulum", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyberspace", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Augmented", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Los Muetros", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Azucar", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mar", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Folklorica", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jester", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = sombraSkins };
                    break;
                case "Symmetra":
                    ObservableCollection<CharacterSkins> symmSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Technomancer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Saffron", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Qipao", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vampire", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Utopaea", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Regal", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Peacock", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Art Deco", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tyrande", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Oasis", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Magician", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hydra", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Figure Skater", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dragon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mermaid", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Goddess", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Devi", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vishkar", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Architech", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hyacinth", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cardamom", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cobra Queen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = symmSkins };
                    break;
                case "Torbjorn":
                    ObservableCollection<CharacterSkins> torbSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Plommon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gron", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Citron", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tre Kronor", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Woodclad", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Captain", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cybjorn", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ironclad", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Chief Engineer Lindholm", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Zhang Fei", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Santaclad", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lumberjack", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Viking", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Surf 'n' Splash", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blackbeard", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Barbarossa", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Deadlock", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Chopper", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Magni", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Bla", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cathode", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = torbSkins };
                    break;
                case "Tracer":
                    ObservableCollection<CharacterSkins> TracerSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Royal Blue", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Neon Green", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hot Pink", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Electrc Purple", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Constable", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lightning", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rose", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sporty", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Posh", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Polar", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Slipstream", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tagged", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cavalry", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cadet Oxton", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nezha", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Hong Gildong", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jingle", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Will-O'-Wisp", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Track and Field", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sprinter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "T.Racer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mach T", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Punk", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Street Urchin", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Graffiti", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ultraviolet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = TracerSkins };
                    break;
                case "Widowmaker":
                    ObservableCollection<CharacterSkins> widowSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Vert", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rose", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ciel", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Electric", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Spider", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tricolore", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Winter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Patina", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Medusa", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyberdevil", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Noire", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Kerrigan", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Talon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mousquetaire", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Black Lily", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Biathlon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Scorpion", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cote d'Azur", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nova", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Huntress", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Odile", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Odette", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nuit", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Pale Serpent", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Comtesse", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = widowSkins };
                    break;
                case "Winston":
                    ObservableCollection<CharacterSkins> wintonSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Red Planet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Forest", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Atmosphere", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Monkey Business", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blizzcon 2017", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Horizon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Desert", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Gargoyle", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Specimen 28", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wukong", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Yeti", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Werewolf", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Catcher", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Safari", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Explorer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Undersea", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Frogston", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Banana", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tactical", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = wintonSkins };
                    break;
                case "Zarya":
                    ObservableCollection<CharacterSkins> zaryaSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Violet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Taiga", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Racer", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Frosted", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Midnight", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dawn", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyberian", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Workout", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Polyanitsa", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Xuanwu", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Snowboarder", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Totally 80's", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Weightlifter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Champion", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cybergoth", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Siberian Front", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Arctic", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Barbarian", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Goldenrod", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Brick", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tactical", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Industrial", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = zaryaSkins };
                    break;
                case "Zenyatta":
                    ObservableCollection<CharacterSkins> zenSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Water", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Leaf", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Earth", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Air", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Skullyatta", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Harmonious", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Takoyaki", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cybermonk", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Clockwork", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Zealot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Huitzilopochtli", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Zhuge Liang", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sanzang", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Toybot", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Nutcracker", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cultist", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Fastball", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sunyatta", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ra", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ifrit", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Djinnyatta", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ascendant", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = zenSkins };
                    break;
                case "Sojourn":
                    ObservableCollection<CharacterSkins> sojournSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Borealis", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Prairie", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Tundra", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Woodland", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Runner", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Firefighter", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Troop Commander", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Captain Chase", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Commando", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Cyber Detetive", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = sojournSkins };
                    break;
                case "Sigma":
                    ObservableCollection<CharacterSkins> sigSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Overwatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Blauw", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Groen", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Oranje", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Roze", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Dr.De Kuiper", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Talon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Carbon Fiber", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Asylum", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Subject Sigma", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Oracle", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Prophet", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Scuba", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Flying Dutchman", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Rime", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Maestro", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = sigSkins };
                    break;
                case "Wrecking Ball":
                    ObservableCollection<CharacterSkins> ballSkins = new ObservableCollection<CharacterSkins>
                    {
                        new CharacterSkins { SkinName = "Overwatch 1", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Ovewatch 2", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Potassium", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lithium", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Chloride", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Sugar Bomb", SkinImage = @"" },
                        new CharacterSkins { SkinName = "High Roller", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Wooden Ball", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Biohazard", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Crustacean", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Submarine", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Snowman", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Jack-O'-Lantern", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lucioball", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Mayham", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Junker", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Lunar", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Horizon", SkinImage = @"" },
                        new CharacterSkins { SkinName = "Smoke", SkinImage = @"" },
                        new CharacterSkins { SkinName = "*", SkinImage = @"" },

                    };

                    CharacterSkinsCollection = new CollectionViewSource { Source = ballSkins };
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
