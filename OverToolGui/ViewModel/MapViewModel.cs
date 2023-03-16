using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using OverToolGUI.Model;

namespace OverToolGUI.ViewModel
{
    public class MapViewModel : INotifyPropertyChanged
    {

        private readonly CollectionViewSource MapCollection;
        public ICollectionView MapSourceCollection => MapCollection.View;


        public MapViewModel()
        {
            ObservableCollection<Maps> maps = new ObservableCollection<Maps>
                    {
                        new Maps { MapName = "Antarctic Peninsula", MapImage = @"Assets/Maps/AntarcticPen.png" },
                        new Maps { MapName = "Ayutthata", MapImage = @"Assets/Maps/Ayutthaya.png" },
                        new Maps { MapName = "Black Forest", MapImage = @"Assets/Maps/Blackforest.png" },
                        new Maps { MapName = "Black Forest (Winter)", MapImage = @"Assets/Maps/Blackforestwinter.png" },
                        new Maps { MapName = "Blizzard World", MapImage = @"Assets/Maps/Blizzardworld.png" },
                        new Maps { MapName = "Blizzard World (Winter)", MapImage = @"Assets/Maps/Blizzardworldwinter.png" },
                        new Maps { MapName = "Busan", MapImage = @"Assets/Maps/Busan.png" },
                        new Maps { MapName = "Busan Downtown (Lunar New Year)", MapImage = @"Assets/Maps/BusanLunar.png" },
                        new Maps { MapName = "Busan Sanctuary (Lunar New Year)", MapImage = @"Assets/Maps/BusanSancLunar.png" },
                        new Maps { MapName = "Castillo", MapImage = @"Assets/Maps/Castillo.png" },
                        new Maps { MapName = "Chateau Guillard", MapImage = @"Assets/Maps/ChateauGuillard.png" },
                        new Maps { MapName = "Circuit Royal", MapImage = @"Assets/Maps/CircuitRoyal.png" },
                        new Maps { MapName = "Colosseo", MapImage = @"Assets/Maps/Colosseo.png" },
                        new Maps { MapName = "Dorado", MapImage = @"Assets/Maps/Dorado.png" },
                        new Maps { MapName = "Ecopoint: Antarctica", MapImage = @"Assets/Maps/EcopointAntarctica.png" },
                        new Maps { MapName = "Ecopoint: Antarctica (Winter)", MapImage = @"Assets/Maps/EcopointAntarcticaWinter.png" },
                        new Maps { MapName = "Eichenwalde", MapImage = @"Assets/Maps/Eichenwalde.png" },
                        new Maps { MapName = "Eichenwalde (Halloween)", MapImage = @"Assets/Maps/EichenwaldeHalloween.png" },
                        new Maps { MapName = "Esperanca", MapImage = @"Assets/Maps/Esperanca.png" },
                        new Maps { MapName = "Hanamura", MapImage = @"Assets/Maps/Hanamura.png" },
                        new Maps { MapName = "Hanamura (Winter)", MapImage = @"Assets/Maps/HanamuraWinter.png" },
                        new Maps { MapName = "Havana", MapImage = @"Assets/Maps/Havana.png" },
                        new Maps { MapName = "Hollywood", MapImage = @"Assets/Maps/Hollywood.png" },
                        new Maps { MapName = "Hollywood (Halloween)", MapImage = @"Assets/Maps/HollwoodHalloween.png" },
                        new Maps { MapName = "Horizon Lunar Colony", MapImage = @"Assets/Maps/HorizonLunarColony.png" },
                        new Maps { MapName = "Ilios", MapImage = @"Assets/Maps/Ilios.png" },
                        new Maps { MapName = "Ilios Lighthouse", MapImage = @"Assets/Maps/IliosLightHouse.png" },
                        new Maps { MapName = "Ilios Ruins", MapImage = @"Assets/Maps/IliosRuins.png" },
                        new Maps { MapName = "Ilios Well", MapImage = @"Assets/Maps/IliosWell.png" },
                        new Maps { MapName = "Junkenstein's Revenge", MapImage = @"Assets/Maps/JunkensteinsRevenge.png" },
                        new Maps { MapName = "Junkertown", MapImage = @"Assets/Maps/Junkertown.png" },
                        new Maps { MapName = "Kanezaka", MapImage = @"Assets/Maps/Kanezaka.png" },
                        new Maps { MapName = "King's Row", MapImage = @"Assets/Maps/KingsRow.png" },
                        new Maps { MapName = "King's Row (Winter)", MapImage = @"Assets/Maps/KingsRowWinter.png" },
                        new Maps { MapName = "Lijiang Control Center", MapImage = @"Assets/Maps/LijiangControlCenter.png" },
                        new Maps { MapName = "Lijiang Control Center (Lunar New Year)", MapImage = @"Assets/Maps/LijiangControlCenterLunarNewYear.png" },
                        new Maps { MapName = "Lijiang Garden", MapImage = @"Assets/Maps/LijiangGarden.png" },
                        new Maps { MapName = "Lijiang Garden (Lunar New Year)", MapImage = @"Assets/Maps/LijiangGardenLunarNewYear.png" },
                        new Maps { MapName = "Lijiang Night Market", MapImage = @"Assets/Maps/LijiangNightMarket.png" },
                        new Maps { MapName = "Lijiang Night Market (Lunar New Year)", MapImage = @"Assets/Maps/LijiangNightMarketLunarNewYear.png" },
                        new Maps { MapName = "Lijiang Tower", MapImage = @"Assets/Maps/LijiangTower.png" },
                        new Maps { MapName = "Lijiang Tower (Lunar New Year)", MapImage = @"Assets/Maps/LijiangTowerLunarNewYear.png" },
                        new Maps { MapName = "Malevento", MapImage = @"Assets/Maps/Malevento.png" },
                        new Maps { MapName = "Midtown", MapImage = @"Assets/Maps/Midtown.png" },
                        new Maps { MapName = "Necropolis", MapImage = @"Assets/Maps/Necropolis.png" },
                        new Maps { MapName = "Nepal", MapImage = @"Assets/Maps/Nepal.png" },
                        new Maps { MapName = "Nepal Sanctum", MapImage = @"Assets/Maps/NepalSanctum.png" },
                        new Maps { MapName = "Nepal Shrine", MapImage = @"Assets/Maps/NepalShrine.png" },
                        new Maps { MapName = "Nepal Village", MapImage = @"Assets/Maps/NepalVillage.png" },
                        new Maps { MapName = "Nepal Village (Winter)", MapImage = @"Assets/Maps/NepalVillageWinter.png" },
                        new Maps { MapName = "New Queen Street", MapImage = @"Assets/Maps/NewQueenStreet.png" },
                        new Maps { MapName = "Numbani", MapImage = @"Assets/Maps/Numbani.png" },
                        new Maps { MapName = "Oasis", MapImage = @"Assets/Maps/Oasis.png" },
                        new Maps { MapName = "Oasis City Center", MapImage = @"Assets/Maps/OasisCityCenter.png" },
                        new Maps { MapName = "Oasis Gardens", MapImage = @"Assets/Maps/OasisGardens.png" },
                        new Maps { MapName = "Oasis University", MapImage = @"Assets/Maps/OasisUniversity.png" },
                        new Maps { MapName = "Paraiso", MapImage = @"Assets/Maps/Paraiso.png" },
                        new Maps { MapName = "Paris", MapImage = @"Assets/Maps/Paris.png" },
                        new Maps { MapName = "Petra", MapImage = @"Assets/Maps/Petra.png" },
                        new Maps { MapName = "Practice Range", MapImage = @"Assets/Maps/PracticeRange.png" },
                        new Maps { MapName = "Rialto", MapImage = @"Assets/Maps/Rialto.png" },
                        new Maps { MapName = "Route 66", MapImage = @"Assets/Maps/Route66.png" },
                        new Maps { MapName = "Shambali Monastery", MapImage = @"Assets/Maps/Shambali.png" },
                        new Maps { MapName = "Temple of Anubis", MapImage = @"Assets/Maps/TempleOfAnubis.png" },
                        new Maps { MapName = "Volskaya Industries", MapImage = @"Assets/Maps/VolskayaIndustries.png" },
                        new Maps { MapName = "Watchpoint: Gibraltar", MapImage = @"Assets/Maps/WatchpointGibraltar.png" },
                        new Maps { MapName = "Workshop Chamber", MapImage = @"Assets/Maps/WorkshopChamber.png" },
                        new Maps { MapName = "Workshop Expanse", MapImage = @"Assets/Maps/WorkshopExpanse.png" },
                        new Maps { MapName = "Workshop Expanse (Night)", MapImage = @"Assets/Maps/WorkshopExpanseNight.png" },
                        new Maps { MapName = "Workshop Island", MapImage = @"Assets/Maps/WorkshopIsland.png" },
                        new Maps { MapName = "Workshop Island (Night)", MapImage = @"Assets/Maps/WorkshopIslandNight.png" },
                    };

            MapCollection = new CollectionViewSource { Source = maps };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
