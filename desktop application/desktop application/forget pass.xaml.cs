using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forget_pass.xaml
    /// </summary>
    public partial class forget_pass : Page
    {
        desktop_assiEntities db = new desktop_assiEntities();
        public forget_pass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userprofileee x = new Userprofileee();
            x.Usersp_phone_number = int.Parse(phonebox.Text);
            x.Usersp_Pass = passbox.Name;
            x.Usersp_Pass = passboxx.Name;
            db.Userprofileees.AddOrUpdate(x);
            db.SaveChanges();
            MessageBox.Show("Done updated");
        }
    }
}
