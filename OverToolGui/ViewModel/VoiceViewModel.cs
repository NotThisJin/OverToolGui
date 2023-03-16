using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using OverToolGUI.Model;

namespace OverToolGUI.ViewModel
{
    public class VoiceViewModel : INotifyPropertyChanged
    {
        private CollectionViewSource HeroesCollection;
        public ICollectionView HeroSourceCollection => HeroesCollection.View;

        public VoiceViewModel()
        {
            ObservableCollection<Heroes> Hero = new ObservableCollection<Heroes>
            {
                new Heroes { HeroName = "Ana", HeroImage = @"Assets/Ana.Png" },
                new Heroes { HeroName = "Ashe", HeroImage = @"Assets/Ashe.png" },
                new Heroes { HeroName = "Baptiste", HeroImage = @"Assets/Baptiste.png" },
                new Heroes { HeroName = "Bastion", HeroImage = @"Assets/Bastion.png" },
                new Heroes { HeroName = "Brigitte", HeroImage = @"Assets/Brigitte.png" },
                new Heroes { HeroName = "Cassidy", HeroImage = @"Assets/Cassidy.png" },
                new Heroes { HeroName = "Doomfist", HeroImage = @"Assets/Doomfist.png" },
                new Heroes { HeroName = "Dva", HeroImage = @"Assets/Dva.png" },
                new Heroes { HeroName = "Echo", HeroImage = @"Assets/Echo.png" },
                new Heroes { HeroName = "Genji", HeroImage = @"Assets/Genji.png" },
                new Heroes { HeroName = "Hanzo", HeroImage = @"Assets/Hanzo.png" },
                new Heroes { HeroName = "Junker Queen", HeroImage = @"Assets/Junkerqueen.png" },
                new Heroes { HeroName = "Junkrat", HeroImage = @"Assets/Junkrat.png" },
                new Heroes { HeroName = "Kiriko", HeroImage = @"Assets/Kiriko.png" },
                new Heroes { HeroName = "Lucio", HeroImage = @"Assets/Lucio.png" },
                new Heroes { HeroName = "Mei", HeroImage = @"Assets/Mei.png" },
                new Heroes { HeroName = "Mercy", HeroImage = @"Assets/Mercy.png" },
                new Heroes { HeroName = "Moira", HeroImage = @"Assets/Moira.png" },
                new Heroes { HeroName = "Orisa", HeroImage = @"Assets/Orisa.png" },
                new Heroes { HeroName = "Pharah", HeroImage = @"Assets/Pharah.png" },
                new Heroes { HeroName = "Ramattra", HeroImage = @"Assets/Ramattra.png" },
                new Heroes { HeroName = "Reaper", HeroImage = @"Assets/Reaper.png" },
                new Heroes { HeroName = "Reinhardt", HeroImage = @"Assets/Reinhardt.png" },
                new Heroes { HeroName = "Roadhog", HeroImage = @"Assets/Roadhog.png" },
                new Heroes { HeroName = "Sigma", HeroImage = @"Assets/Sigma.png" },
                new Heroes { HeroName = "Sojourn", HeroImage = @"Assets/Sojourn.png" },
                new Heroes { HeroName = "Soldier76", HeroImage = @"Assets/Soldier76.png" },
                new Heroes { HeroName = "Sombra", HeroImage = @"Assets/Sombra.png" },
                new Heroes { HeroName = "Symmetra", HeroImage = @"Assets/Symmetra.png" },
                new Heroes { HeroName = "Torbjorn", HeroImage = @"Assets/Torbjorn.png" },
                new Heroes { HeroName = "Tracer", HeroImage = @"Assets/Tracer.png" },
                new Heroes { HeroName = "Widowmaker", HeroImage = @"Assets/Widowmaker.png" },
                new Heroes { HeroName = "Winston", HeroImage = @"Assets/Winston.png" },
                new Heroes { HeroName = "Wrecking Ball", HeroImage = @"Assets/Wreckingball.png" },
                new Heroes { HeroName = "Zarya", HeroImage = @"Assets/Zarya.png" },
                new Heroes { HeroName = "Zenyatta", HeroImage = @"Assets/Zenyatta.png" },
            };

            HeroesCollection = new CollectionViewSource { Source = Hero };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
