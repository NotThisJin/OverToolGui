using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OverToolGUI.Model;
using OverToolGUI.ViewModel;
using Newtonsoft.Json;

namespace OverToolGUI
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            if (!File.Exists("FolderPaths.json"))
            {
                var paths = new Paths()
                {
                    OverwatchPath = NavigationViewModel.OverwatchPath,
                    ExportPath = NavigationViewModel.ExportPath
                };

                using (StreamWriter file = File.CreateText("FolderPaths.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, paths);
                }
            }
            else
            {
                using (StreamReader file = File.OpenText("FolderPaths.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Paths path = (Paths)serializer.Deserialize(file, typeof(Paths));

                    NavigationViewModel.ExportPath = path.ExportPath;
                    NavigationViewModel.OverwatchPath = path.OverwatchPath;

                }
            }

            if (VersionText.Text != GetVersion("https://raw.githubusercontent.com/NotThisJin/OverToolGui/main/Version"))
            {
                VersionText.Foreground = new SolidColorBrush(Colors.Red);
                MessageBox.Show("New OverToolGUI Update is Available!", "Version Notice");
            } 
        }

        public string GetVersion(string url)
        {
            var httpClientHandler = new HttpClientHandler();
            var httpClient = new HttpClient(httpClientHandler)
            {
                BaseAddress = new Uri(url)
            };
            using (var response = httpClient.GetAsync(url))
            {
                string responseBody = response.Result.Content.ReadAsStringAsync().Result;
                return responseBody.Trim();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void DragWithHeader(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
