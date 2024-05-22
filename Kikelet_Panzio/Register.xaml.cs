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
using System.Windows.Shapes;

namespace Kikelet_Panzio
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
       
        public Register()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            string nevid = TbxUsername.Text.ToLower().Replace(" ","") + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day;
            TbxUserID.Text = nevid;
            MainWindow.ugyfelek.Add(new Ugyfel(TbxUserID.Text, TbxUsername.Text, DateTime.Parse(DtpUserBirth.Text), TbxEmail.Text, CbxIsVIP.IsChecked.Value));
            MessageBox.Show("Regisztrációját rögzítettük! Az ablak bezárul.", "Siker", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();
            
            
            
        }
    }
}
