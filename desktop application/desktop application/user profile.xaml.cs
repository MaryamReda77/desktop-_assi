using System;
using System.Collections.Generic;
using System.Linq;
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

namespace desktop_application
{
    /// <summary>
    /// Interaction logic for user_profile.xaml
    /// </summary>
    public partial class user_profile : Page
    {
        desktop_assiEntities db = new desktop_assiEntities();
        public user_profile()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Sign_in sign_In = new Sign_in();
            this.NavigationService.Navigate(sign_In);
        }
    }
}
