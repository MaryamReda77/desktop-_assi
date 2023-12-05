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
    /// Interaction logic for Sign_in.xaml
    /// </summary>
    public partial class Sign_in : Page
    {
        desktop_assiEntities db = new desktop_assiEntities();
        public Sign_in()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Userprofileee x = new Userprofileee();
            x.Usersp_Age = int.Parse(Age_textbox.Text);
            x.Usersp_Pass = passtext.Name;
            x.Usersp_Name = name_textbox.Text;
            db.Userprofileees.Add(x);
            db.SaveChanges();
            MessageBox.Show("Username added");
            user_profile v = new user_profile();
            this.NavigationService.Navigate(v);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_up x = new sign_up();
            this.NavigationService.GoBack();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forget_pass x = new forget_pass();  
            this.NavigationService.GoForward();
        }
    }
}
