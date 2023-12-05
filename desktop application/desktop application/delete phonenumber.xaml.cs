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
    /// Interaction logic for delete_phonenumber.xaml
    /// </summary>
    public partial class delete_phonenumber : Page
    {
        desktop_assiEntities db = new desktop_assiEntities();
        public delete_phonenumber()
        {
            InitializeComponent();
        }

        readonly string phone = int.Parse(num);
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userprofileee x = new Userprofileee();
            x.Usersp_phone_number = int.Parse(phone_Box.Text);
            db.Userprofileees.Remove(db.Userprofileees.FirstOrDefault(y=>x.Usersp_phone_number = num));
            db.SaveChanges();     
            MessageBox.Show("done deleted");

        }
    }
}
