using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
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

namespace DrumsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string authority = ConfigurationManager.AppSettings["authority"];
        private static string directory = ConfigurationManager.AppSettings["directory"];
        private static string resource = ConfigurationManager.AppSettings["resource"];
        private static string clientId = ConfigurationManager.AppSettings["clientId"];
        private static string redirectUri = ConfigurationManager.AppSettings["redirectUri"];

        public MainWindow()
        {
            InitializeComponent();
        }

        private AuthenticationContext authContext;

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            authContext = new AuthenticationContext(string.Concat(authority, directory));
            //var userAssertion = new UserAssertion(clientId);
            var result = authContext.AcquireTokenAsync(resource, clientId, new Uri(redirectUri), null);
            //var x = await result;
            var httpClient = new HttpClient();
            //httpClient.DefaultRequestHeaders.Authorization = 
            //    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.)
        }
    }
}
