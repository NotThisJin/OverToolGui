using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.Win32;
using OverToolGUI.Model;
using OverToolGUI.View;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace OverToolGUI.ViewModel
{
    class NavigationViewModel : INotifyPropertyChanged
    {

        private CollectionViewSource MenuItemsCollection;

        public static string OverwatchPath = "Overwatch Folder Path";
        public static string ExportPath = "Export Folder Path";
        public static string selectedCharacter;
        public static string selectedSkin;
        public static string selectedMap;

        public ICollectionView SourceCollection => MenuItemsCollection.View;

        public NavigationViewModel()
        {
            ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>
            {
                new MenuItems { MenuName = "Skins", MenuImage = "" },
                new MenuItems { MenuName = "Maps", MenuImage = "" },
                new MenuItems { MenuName = "Voices", MenuImage = "" },
                new MenuItems { MenuName = "Settings", MenuImage = "" },
            };

            MenuItemsCollection = new CollectionViewSource { Source = menuItems };

            SelectedViewModel = new StartupViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        // Select ViewModel
        private object _selectedViewModel;
        public object SelectedViewModel
        {
            get => _selectedViewModel;
            set { _selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        // Switch Views
        public void SwitchViews(object parameter)
        {
            switch(parameter)
            {
                case "Skins":
                    SelectedViewModel = new CharacterViewModel();
                    break;
                case "Maps":
                    SelectedViewModel = new MapViewModel();
                    break;
                case "Voices":
                    SelectedViewModel = new VoiceViewModel();
                    break;
                case "Settings":
                    SelectedViewModel = new SettingsViewModel();
                    break;
            }
        }


        // Download DataTool Skin
        public void DownloadSkin()
        {
            if (Process.GetProcessesByName("overwatch").Length > 0)
            {
                System.Windows.MessageBox.Show("Close Overwatch First Please.", "Alert");
                return;
            }
            ProcessStartInfo startInfo = new ProcessStartInfo("Datatool.exe");
            startInfo.Arguments = $"\"{OverwatchPath}\" extract-unlocks \"{ExportPath}\" \"{selectedCharacter}|skin={selectedSkin}\"";
            Process process = Process.Start(startInfo);

        }

        // Download DataTool Map
        public void DownloadMap()
        {
            if (Process.GetProcessesByName("overwatch").Length > 0)
            {
                System.Windows.MessageBox.Show("Close Overwatch First Please.", "Alert");
                return;
            }
            ProcessStartInfo startInfo = new ProcessStartInfo("Datatool.exe");
            startInfo.Arguments = $"\"{OverwatchPath}\" extract-maps \"{ExportPath}\" \"{selectedMap}\"";
            Process process = Process.Start(startInfo);

        }

        // Download DataTool Voice
        public void DownloadVoice()
        {
            if (Process.GetProcessesByName("overwatch").Length > 0)
            {
                System.Windows.MessageBox.Show("Close Overwatch First Please.", "Alert");
                return;
            }
            ProcessStartInfo startInfo = new ProcessStartInfo("Datatool.exe");
            startInfo.Arguments = $"\"{OverwatchPath}\" extract-hero-voice-better \"{ExportPath}\" {selectedCharacter}";
            Process process = Process.Start(startInfo);

        }

        // Select Character
        public void SelectChar(object character)
        {
            selectedCharacter = character.ToString();
        }

        // Select Skin
        public void SelectSkins(object skin)
        {
            selectedSkin = skin.ToString();
        }

        // Select Map
        public void SelectMap(object map)
        {
            selectedMap = map.ToString();
        }

        // Show Home View
        private void ShowHome()
        {
            SelectedViewModel = new CharacterViewModel();
            selectedCharacter = string.Empty;
            selectedSkin = string.Empty;
        }

        // Change Overwatch Folder Path
        public void ChangePathFolder()
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                OverwatchPath = folderPath;
            }
        }

        // Change Export Folder Path
        public void ChangeExportFolder()
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                ExportPath = folderPath;
            }
        }




        /// <summary>
        ///                         Commands!
        /// </summary>


        // Change Overwatch Folder Command
        private ICommand _changeOverwatchCommand;
        public ICommand ChangeOverwatchComamnd
        {
            get
            {
                if (_changeOverwatchCommand == null)
                {
                    _changeOverwatchCommand = new RelayCommand(param => ChangePathFolder());
                }
                return _changeOverwatchCommand;
            }
        }

        private ICommand _changeExportCommand;
        public ICommand ChangeExportCommand
        {
            get
            {
                if (_changeExportCommand == null)
                {
                    _changeExportCommand = new RelayCommand(param => ChangeExportFolder());
                }
                return _changeExportCommand;
            }
        }

        // Switch Hero
        public void SwitchHero(object parameter)
        {
            switch (parameter)
            {
                case "Ana":
                    SelectedViewModel = new SkinViewModel("Ana");
                    SelectChar(parameter);
                    break;
                case "Ashe":
                    SelectedViewModel = new SkinViewModel("Ashe");
                    SelectChar(parameter);
                    break;
                case "Baptiste":
                    SelectedViewModel = new SkinViewModel("Baptiste");
                    SelectChar(parameter);
                    break;
                case "Bastion":
                    SelectedViewModel = new SkinViewModel("Bastion");
                    SelectChar(parameter);
                    break;
                case "Brigitte":
                    SelectedViewModel = new SkinViewModel("Brigitte");
                    SelectChar(parameter);
                    break;
                case "Cassidy":
                    SelectedViewModel = new SkinViewModel("Cassidy");
                    SelectChar(parameter);
                    break;
                case "Doomfist":
                    SelectedViewModel = new SkinViewModel("Doomfist");
                    SelectChar(parameter);
                    break;
                case "Dva":
                    SelectedViewModel = new SkinViewModel("Dva");
                    SelectChar(parameter);
                    break;
                case "Echo":
                    SelectedViewModel = new SkinViewModel("Echo");
                    SelectChar(parameter);
                    break;
                case "Genji":
                    SelectedViewModel = new SkinViewModel("Genji");
                    SelectChar(parameter);
                    break;
                case "Hanzo":
                    SelectedViewModel = new SkinViewModel("Hanzo");
                    SelectChar(parameter);
                    break;
                case "Junker Queen":
                    SelectedViewModel = new SkinViewModel("Junker Queen");
                    SelectChar(parameter);
                    break;
                case "Junkrat":
                    SelectedViewModel = new SkinViewModel("Junkrat");
                    SelectChar(parameter);
                    break;
                case "Kiriko":
                    SelectedViewModel = new SkinViewModel("Kiriko");
                    SelectChar(parameter);
                    break;
                case "Lucio":
                    SelectedViewModel = new SkinViewModel("Lucio");
                    SelectChar(parameter);
                    break;
                case "Mei":
                    SelectedViewModel = new SkinViewModel("Mei");
                    SelectChar(parameter);
                    break;
                case "Mercy":
                    SelectedViewModel = new SkinViewModel("Mercy");
                    SelectChar(parameter);
                    break;
                case "Moira":
                    SelectedViewModel = new SkinViewModel("Moira");
                    SelectChar(parameter);
                    break;
                case "Orisa":
                    SelectedViewModel = new SkinViewModel("Orisa");
                    SelectChar(parameter);
                    break;
                case "Pharah":
                    SelectedViewModel = new SkinViewModel("Pharah");
                    SelectChar(parameter);
                    break;
                case "Ramattra":
                    SelectedViewModel = new SkinViewModel("Ramattra");
                    SelectChar(parameter);
                    break;
                case "Reaper":
                    SelectedViewModel = new SkinViewModel("Reaper");
                    SelectChar(parameter);
                    break;
                case "Reinhardt":
                    SelectedViewModel = new SkinViewModel("Reinhardt");
                    SelectChar(parameter);
                    break;
                case "Roadhog":
                    SelectedViewModel = new SkinViewModel("Roadhog");
                    SelectChar(parameter);
                    break;
                case "Soldier76":
                    SelectedViewModel = new SkinViewModel("Soldier76");
                    SelectChar(parameter);
                    break;
                case "Sombra":
                    SelectedViewModel = new SkinViewModel("Sombra");
                    SelectChar(parameter);
                    break;
                case "Symmetra":
                    SelectedViewModel = new SkinViewModel("Symmetra");
                    SelectChar(parameter);
                    break;
                case "Torbjorn":
                    SelectedViewModel = new SkinViewModel("Torbjorn");
                    SelectChar(parameter);
                    break;
                case "Tracer":
                    SelectedViewModel = new SkinViewModel("Tracer");
                    SelectChar(parameter);
                    break;
                case "Widowmaker":
                    SelectedViewModel = new SkinViewModel("Widowmaker");
                    SelectChar(parameter);
                    break;
                case "Winston":
                    SelectedViewModel = new SkinViewModel("Winston");
                    SelectChar(parameter);
                    break;
                case "Zarya":
                    SelectedViewModel = new SkinViewModel("Zarya");
                    SelectChar(parameter);
                    break;
                case "Zenyatta":
                    SelectedViewModel = new SkinViewModel("Zenyatta");
                    SelectChar(parameter);
                    break;
                case "Sojourn":
                    SelectedViewModel = new SkinViewModel("Sojourn");
                    SelectChar(parameter);
                    break;
                case "Sigma":
                    SelectedViewModel = new SkinViewModel("Sigma");
                    SelectChar(parameter);
                    break;
                case "Wrecking Ball":
                    SelectedViewModel = new SkinViewModel("Wrecking Ball");
                    SelectChar(parameter);
                    break;
                case "Lifeweaver":
                    SelectedViewModel = new SkinViewModel("Lifeweaver");
                    SelectChar(parameter);
                    break;

            }
        }

        // Menu Button Command
        private ICommand _menucommand;
        public ICommand MenuCommand
        {
            get
            {
                if (_menucommand == null)
                {
                    _menucommand = new RelayCommand(param => SwitchViews(param));
                }
                return _menucommand;
            }
        }


        // Select Character Command
        private ICommand _selectCharacterCommand;
        public ICommand SelectCharacter
        {
            get
            {
                if (_selectCharacterCommand == null)
                {
                    _selectCharacterCommand = new RelayCommand(param => SelectChar(param));
                }
                return _selectCharacterCommand;
            }
        }


        // Select Skin Command
        private ICommand _selectSkinCommand;
        public ICommand SelectSkin
        {
            get
            {
                if (_selectSkinCommand == null)
                {
                    _selectSkinCommand = new RelayCommand(param => SelectSkins(param));
                }
                return _selectSkinCommand;
            }
        }


        // Download Skin Command
        private ICommand _downloadSkinCommand;
        public ICommand DownloadSkins
        {
            get
            {
                if (_downloadSkinCommand == null)
                {
                    _downloadSkinCommand = new RelayCommand(param => DownloadSkin());
                }
                return _downloadSkinCommand;
            }
        }

        // Download Map Command
        private ICommand _downloadMapCommand;
        public ICommand DownloadSelectedMap
        {
            get
            {
                if (_downloadMapCommand == null)
                {
                    _downloadMapCommand = new RelayCommand(param => DownloadMap());
                }
                return _downloadMapCommand;
            }
        }


        // Download Map Command
        private ICommand _downloadVoiceCommand;
        public ICommand DownloadSelectedVoice
        {
            get
            {
                if (_downloadVoiceCommand == null)
                {
                    _downloadVoiceCommand = new RelayCommand(param => DownloadVoice());
                }
                return _downloadVoiceCommand;
            }
        }


        // Hero Select Command
        private ICommand _herocommand;
        public ICommand HeroCommand
        {
            get
            {
                if (_herocommand == null)
                {
                    _herocommand = new RelayCommand(param => SwitchHero(param));
                }
                return _herocommand;
            }
        }

        // Hero Select Command
        private ICommand _selectVoiceCommand;
        public ICommand SelectVoice
        {
            get
            {
                if (_selectVoiceCommand == null)
                {
                    _selectVoiceCommand = new RelayCommand(param => SelectChar(param));
                }
                return _selectVoiceCommand;
            }
        }

        // Map Select Command
        private ICommand _selectMapCommand;
        public ICommand SelectMaps
        {
            get
            {
                if (_selectMapCommand == null)
                {
                    _selectMapCommand = new RelayCommand(param => SelectMap(param));
                }
                return _selectMapCommand;
            }
        }

        // Back button Command
        private ICommand _backHomeCommand;
        public ICommand BackHomeCommand
        {
            get
            {
                if (_backHomeCommand == null)
                {
                    _backHomeCommand = new RelayCommand(p => ShowHome());
                }
                return _backHomeCommand;
            }
        }

        // Close App
        public void CloseApp(object obj)
        {
            MainWindow win = obj as MainWindow;
            win.Close();
        }

        // Close App Command
        private ICommand _closeCommand;
        public ICommand CloseAppCommand
        {
            get
            {
                if (_closeCommand == null)
                {
                    _closeCommand = new RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }
       
    }
}
