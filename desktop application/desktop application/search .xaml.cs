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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        desktop_assiEntities db = new desktop_assiEntities();
        public search()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userprofileee x = new Userprofileee();
            x.Usersp_City = searchbox.Text;
            
            data.ItemsSource=db.Userprofileees.Where(db.Userprofileees.Contains(x=>x.Usersp_City=searchbox.Text)).ToList();
        }
    }
}
