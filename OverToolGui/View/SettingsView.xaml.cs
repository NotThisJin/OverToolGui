
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using Newtonsoft.Json;
using OverToolGUI.Model;
using OverToolGUI.ViewModel;
using UserControl = System.Windows.Controls.UserControl;

namespace OverToolGUI.View
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            if(NavigationViewModel.OverwatchPath != "Overwatch Folder Path")
                FolderPathText.Text = NavigationViewModel.OverwatchPath;
            if (NavigationViewModel.ExportPath != "Export Folder Path")
                FolderExportText.Text = NavigationViewModel.ExportPath;
        }

        private void ChangePathFolder(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Overwatch Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                NavigationViewModel.OverwatchPath = folderPath;
                FolderPathText.Text = folderPath;
            }
        }

        private void Discord(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/XM93ZdB");
        }

        private void BlenderAddon(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/overtools/io_scene_owm/archive/refs/tags/release/3-1-1.zip");
        }

        private void Github(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NotThisJin/OverToolGui");
        }

        private void ChangeExportFolder(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Export Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                NavigationViewModel.ExportPath = folderPath;
                FolderExportText.Text = folderPath;
            }
        }

        private void DataWatch(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/overtools/OWLib");
        }

        private void SaveFolderPaths(object sender, System.Windows.RoutedEventArgs e)
        {
            if (File.Exists("FolderPaths.json"))
            {

                Paths path = JsonConvert.DeserializeObject<Paths>(File.ReadAllText("FolderPaths.json"));

                using (StreamWriter file = File.CreateText("FolderPaths.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    path.OverwatchPath = NavigationViewModel.OverwatchPath;
                    path.ExportPath = NavigationViewModel.ExportPath;
                    serializer.Serialize(file, path);
                }
            }
        }
    }
}
