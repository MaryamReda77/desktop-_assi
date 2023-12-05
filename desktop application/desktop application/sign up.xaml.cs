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

    public partial class sign_up : Page
    {
        desktop_assiEntities db = new desktop_assiEntities();
        public sign_up()
        {
            InitializeComponent();
        }
        int age = 0;
        int phone = 0;

        public void validage()
        {
            if (age > 18 && age < 60)
                MessageBox.Show("age is valid ");
        }

        public void validpass(string pass)
        {
            bool upper, lower, num, speacial;
            upper = lower = num = speacial = false;


            foreach (char c in pass)
            {
                if (c =< 'A' && c=> 'Z')
                {
                    upper = true;
                }
                else if (c =< 'a' && c=> 'z')
                { lower = true; }



                else if (num =< '0' && num=> '9')
                { num = true; }
            else if (speacial = "!@#$%^&*()")
                {
                    speacial = true; 
                }

                return num = lower = upper = speacial = true;
            }

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Userprofileee x = new Userprofileee();
            x.Usersp_Age = int.Parse(age_textboxx.Text);
            x.Usersp_Name = name_textboxx.Text;
            x.Usersp_Gender = genderbox.Text;
            x.Usersp_Pass = passwordtext.Name;
            x.Usersp_phone_number = int.Parse(phone_textboxx.Text);
            if (phone_textboxx.Text.Length >= 11)
            {

            }
            else
                MessageBox.Show("not valid");

            db.Userprofileees.Add(x);
            db.SaveChanges();
            MessageBox.Show("Username added");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sign_in s = new sign_in();
            this.NavigationService.Navigate(s); 
        }
    }
}
